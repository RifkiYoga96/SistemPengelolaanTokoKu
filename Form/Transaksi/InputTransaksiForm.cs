using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shopee.Input_Iklan;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Shopee
{
    public partial class InputTransaksiForm : Form
    {
        private readonly ProdukDal _produkDal = new();
        private readonly OperasionalDal _pengeluaranDal = new();
        private readonly TransaksiDal _transaksiDal = new();
        private readonly TransaksiDetailDal _transaksiDetailDal = new();
        private readonly int _id;
        private readonly BindingList<TransaksiDetailModel> _listTransaksiPendapatan = new();
        private readonly BindingList<TransaksiDetailModel> _listTransaksiPengeluaran = new();

        public InputTransaksiForm(int tabIndex, int id = 0)
        {
            InitializeComponent();
            this.IsDialogForm();

            _id = id;

            InitComponents();
            RegisterEvents();
            SetupPendapatanGrid();

            if (_id != 0)
                LoadUpdateData(tabIndex);
        }

        private void InitComponents()
        {
            // Pendapatan
            comboProduk.DataSource = _produkDal.ListProdukCombo();
            comboProduk.DisplayMember = "Nama_Produk";
            comboProduk.ValueMember = "ID_Produk";
            UpdateHargaProduk();

            // Pengeluaran
            comboPengeluaran.DataSource = _pengeluaranDal.ListPengeluaranCombo();
            comboPengeluaran.DisplayMember = "nama_pengeluaran";
            comboPengeluaran.ValueMember = "id_pengeluaran";
            UpdateBiayaPengeluaran();
        }

        private void RegisterEvents()
        {
            btnSavePendapatan.Click += SaveDataPendapatan;
            btnSavePengeluaran.Click += SaveDataPengeluaran;
            btnAddPendapatan.Click += AddPendapatan;

            comboProduk.SelectedIndexChanged += (_, _) => UpdateHargaProduk();
            comboPengeluaran.SelectedIndexChanged += (_, _) => UpdateBiayaPengeluaran();
        }

        private void AddPendapatan(object? sender, EventArgs e)
        {
            if (comboProduk.SelectedItem is not ProdukModel produk)
            {
                MessageBoxShow.Warning();
                return;
            }
            
            var namaTransaksi = produk.nama_produk;
            var jumlah = (int)numericJumlahPendapatan.Value;
            var harga = produk.harga;
            var modal = _produkDal.GetModal(produk.id_produk);

            var transaksiDetail = new TransaksiDetailModel
            {
                nama_transaksi = namaTransaksi,
                harga = harga,
                modal = modal,
                jumlah = jumlah
            };

            _listTransaksiPendapatan.Add(transaksiDetail);
            gridPendapatan.DataSource = _listTransaksiPendapatan;
        }

        private void SaveDataPendapatan(object? sender, EventArgs e)
        {
            if (_listTransaksiPendapatan.Count == 0)
            {
                MessageBoxShow.Warning("Transaksi masih kosong!");
                return;
            }

            var tanggal = dtPendapatan.Value.Date;
            var nominalDiskon = (int)numericNominalDiskon.Value;
            var admin = _pengeluaranDal.GetAdmin();

            var transaksi = new TransaksiModel
            {
                tanggal = tanggal,
                admin = admin,
                tipe = true, // true karena pendapatan
                nominal_diskon = nominalDiskon
            };

            int id_transaksi = _transaksiDal.InsertData(transaksi); //data induk

            foreach (var transaksiDetail in _listTransaksiPendapatan)
            {
                transaksiDetail.id_transaksi = id_transaksi;
                _transaksiDetailDal.InsertData(transaksiDetail); // data detail
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SaveDataPengeluaran(object? sender, EventArgs e)
        {
            if (comboPengeluaran.SelectedItem is not OperasionalModel pengeluaran) return;

            if (!MessageBoxShow.Confirmation()) return;

            var data = new TransaksiModel
            {
                nama_transaksi = pengeluaran.nama_pengeluaran,
                tanggal = dtPendapatan.Value.Date,
                harga = (int)numericPengeluaran.Value,
                tipe = false
            };

            _transaksiDal.InsertData(data);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateHargaProduk()
        {
            if (comboProduk.SelectedItem is ProdukModel produk)
                numericHargaPendapatan.Value = produk.harga;
        }

        private void UpdateBiayaPengeluaran()
        {
            if (comboPengeluaran.SelectedItem is OperasionalModel item)
                numericPengeluaran.Value = Convert.ToInt32(item.jumlah_pengeluaran);
        }

        private void LoadUpdateData(int tabIndex)
        {
            if (tabIndex == 0)
            {
                LoadDataPendapatan(_id);
                tabControl1.SelectedTab = tabPendapatan;
            }
            else
            {
                LoadDataPengeluaran(_id);
                tabControl1.SelectedTab = tabPengeluaran;
            }

            tabControl1.Selecting += (_, e) => e.Cancel = true;
        }

        private void LoadDataPendapatan(int id)
        {
            var data = _transaksiDal.GetData(id);
            if (data == null) return;

            dtPendapatan.Value = data.tanggal;
            comboProduk.SelectedItem = comboProduk.Items
                .OfType<ProdukModel>()
                .FirstOrDefault(p => p.nama_produk == data.nama_transaksi);
            numericJumlahPendapatan.Value = Convert.ToInt32(data.jumlah);
            numericHargaPendapatan.Value = Convert.ToInt32(data.harga);
        }

        private void LoadDataPengeluaran(int id)
        {
            var data = _transaksiDal.GetData(id);
            if (data == null) return;

            dtPengeluaran.Value = data.tanggal;
            comboPengeluaran.SelectedItem = comboPengeluaran.Items
                .OfType<OperasionalModel>()
                .FirstOrDefault(p => p.nama_pengeluaran == data.nama_transaksi);
        }

        private void SetupPendapatanGrid()
        {
            var dgv = gridPendapatan;
            dgv.DataSource = _listTransaksiPendapatan;
            CustomizeGridStyle(dgv);

            foreach (var colName in new[] {
                "id_transaksi", "tanggal", "modal", "harga",
                "pendapatan_bersih", "tipe", "admin", "nominal_diskon" })
                dgv.Columns[colName].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["nama_transaksi"].FillWeight = 70;
            dgv.Columns["jumlah"].FillWeight = 30;

            dgv.Columns["nama_transaksi"].HeaderText = "  Nama Produk";
            dgv.Columns["jumlah"].HeaderText = "Jumlah";
            dgv.Columns["nama_transaksi"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["jumlah"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CustomizeGridStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Silver;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ForeColor = Color.DimGray;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;

            dgv.ColumnHeadersHeight = 35;
            dgv.RowTemplate.Height = 40;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;

            dgv.RowPrePaint += (s, e) =>
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    e.RowIndex % 2 == 0 ? Color.White : Color.FromArgb(251, 251, 251);
            };
        }

    }
}