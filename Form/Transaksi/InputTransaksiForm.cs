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

            InitializePendapatan();
            InitializePengeluaran();

            if (_id != 0)
                LoadUpdateData(tabIndex);
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

        #region PENDAPATAN

        private void InitializePendapatan()
        {
            InitComponentPendapatan();
            RegisterEventPendapatan();
            SetupPendapatanGrid();
        }

        private void InitComponentPendapatan()
        {
            comboProdukPendapatan.DataSource = _produkDal.ListProdukCombo();
            comboProdukPendapatan.DisplayMember = "Nama_Produk";
            comboProdukPendapatan.ValueMember = "ID_Produk";
            UpdateHargaProduk();
        }

        private void RegisterEventPendapatan()
        {
            btnSavePendapatan.Click += SaveDataPendapatan;
            btnAddPendapatan.Click += AddPendapatan;
            comboProdukPendapatan.SelectedIndexChanged += (_, _) => UpdateHargaProduk();
            gridPendapatan.CellMouseClick += GridPendapatan_CellMouseClick;
            deletePendapatan.Click += DeletePendapatan_Click;
        }

        private void DeletePendapatan_Click(object? sender, EventArgs e)
        {
            int index = gridPendapatan.CurrentCell?.RowIndex ?? -1;
            if (index < 0 || index >= _listTransaksiPendapatan.Count)
            {
                MessageBoxShow.Warning("Tidak ada data yang dipilih untuk dihapus.");
                return;
            }
            _listTransaksiPendapatan.RemoveAt(index);
        }

        private void GridPendapatan_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            menuStripPendapatan.Show(Cursor.Position);
        }

        private void AddPendapatan(object? sender, EventArgs e)
        {
            if (comboProdukPendapatan.SelectedItem is not ProdukModel produk)
            {
                MessageBoxShow.Warning();
                return;
            }

            var namaTransaksi = produk.nama_produk;
            var jumlah = Convert.ToInt32(numericJumlahPendapatan.Value);
            var harga = Convert.ToInt32(numericHargaPendapatan.Value);
            var modal = _produkDal.GetModal(produk.id_produk);

            var transaksiDetail = new TransaksiDetailModel
            {
                nama_transaksi = namaTransaksi,
                harga = harga,
                modal = modal,
                jumlah = jumlah
            };

            _listTransaksiPendapatan.Add(transaksiDetail);
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

        private void LoadDataPendapatan(int id)
        {
            var data = _transaksiDal.GetData(id);
            if (data == null) return;

            dtPendapatan.Value = data.tanggal;
            comboProdukPendapatan.SelectedItem = comboProdukPendapatan.Items
                .OfType<ProdukModel>()
                .FirstOrDefault(p => p.nama_produk == data.nama_transaksi);
            numericJumlahPendapatan.Value = Convert.ToInt32(data.jumlah);
            numericHargaPendapatan.Value = Convert.ToInt32(data.harga);
        }

        private void UpdateHargaProduk()
        {
            if (comboProdukPendapatan.SelectedItem is ProdukModel produk)
                numericHargaPendapatan.Value = produk.harga;
        }

        private void SetupPendapatanGrid()
        {
            var dgv = gridPendapatan;
            dgv.DataSource = _listTransaksiPendapatan;
            CustomizeGridStyle(dgv);

            foreach (var colName in new[] { "id_transaksi", "modal" })
                dgv.Columns[colName].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["nama_transaksi"].FillWeight = 60;
            dgv.Columns["harga"].FillWeight = 20;
            dgv.Columns["jumlah"].FillWeight = 20;

            dgv.Columns["nama_transaksi"].HeaderText = "  Nama Produk";
            dgv.Columns["harga"].HeaderText = "Harga";
            dgv.Columns["jumlah"].HeaderText = "Jumlah";

            dgv.Columns["nama_transaksi"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["jumlah"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion


        #region PENGELUARAN

        private void InitializePengeluaran()
        {
            InitComponentPengeluaran();
            RegisterEventPengeluaran();
            SetupPengeluaranGrid();
        }

        private void InitComponentPengeluaran()
        {
            comboPengeluaran.DataSource = _pengeluaranDal.ListPengeluaranCombo();
            comboPengeluaran.DisplayMember = "nama_pengeluaran";
            comboPengeluaran.ValueMember = "id_pengeluaran";
            UpdateBiayaPengeluaran();
        }


        private void RegisterEventPengeluaran()
        {
            btnSavePengeluaran.Click += SaveDataPengeluaran;
            comboPengeluaran.SelectedIndexChanged += (_, _) => UpdateBiayaPengeluaran();
            btnAddPengeluaran.Click += AddPengeluaran;
            gridPengeluaran.CellMouseClick += GridPengeluaran_CellMouseClick;
            deletePengeluaran.Click += DeletePengeluaran_Click;
        }

        private void DeletePengeluaran_Click(object? sender, EventArgs e)
        {
            int index = gridPengeluaran.CurrentCell?.RowIndex ?? -1;
            if (index < 0 || index >= _listTransaksiPengeluaran.Count)
            {
                MessageBoxShow.Warning("Tidak ada data yang dipilih untuk dihapus.");
                return;
            }
            _listTransaksiPengeluaran.RemoveAt(index);
        }

        private void GridPengeluaran_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            menuStripPengeluaran.Show(Cursor.Position);
        }

        private void AddPengeluaran(object? sender, EventArgs e)
        {
            if (comboPengeluaran.SelectedItem is not OperasionalModel operasional)
            {
                MessageBoxShow.Warning();
                return;
            }

            var namaTransaksi = operasional.nama_pengeluaran;
            var jumlah = (int)numericJumlahPengeluaran.Value;
            var harga = Convert.ToInt32(numericHargaPengeluaran.Value);

            var transaksiDetail = new TransaksiDetailModel
            {
                nama_transaksi = namaTransaksi,
                harga = harga,
                modal = null,
                jumlah = jumlah
            };

            _listTransaksiPengeluaran.Add(transaksiDetail);
        }

        private void SaveDataPengeluaran(object? sender, EventArgs e)
        {
            if (_listTransaksiPengeluaran.Count == 0)
            {
                MessageBoxShow.Warning("Transaksi masih kosong!");
                return;
            }

            var tanggal = dtPengeluaran.Value.Date;

            var transaksi = new TransaksiModel
            {
                tanggal = tanggal,
                admin = null,
                tipe = false, // false karena pengeluaran
                nominal_diskon = null
            };

            int id_transaksi = _transaksiDal.InsertData(transaksi); //data induk

            foreach (var transaksiDetail in _listTransaksiPengeluaran)
            {
                transaksiDetail.id_transaksi = id_transaksi;
                _transaksiDetailDal.InsertData(transaksiDetail); // data detail
            }

            DialogResult = DialogResult.OK;
            Close();
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

        private void UpdateBiayaPengeluaran()
        {
            if (comboPengeluaran.SelectedItem is OperasionalModel item)
                numericHargaPengeluaran.Value = Convert.ToInt32(item.jumlah_pengeluaran);
        }

        private void SetupPengeluaranGrid()
        {
            var dgv = gridPengeluaran;
            dgv.DataSource = _listTransaksiPengeluaran;
            CustomizeGridStyle(dgv);

            foreach (var colName in new[] { "id_transaksi", "modal" })
                dgv.Columns[colName].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["nama_transaksi"].FillWeight = 60;
            dgv.Columns["harga"].FillWeight = 20;
            dgv.Columns["jumlah"].FillWeight = 20;

            dgv.Columns["nama_transaksi"].HeaderText = "  Nama Produk";
            dgv.Columns["harga"].HeaderText = "Harga";
            dgv.Columns["jumlah"].HeaderText = "Jumlah";

            dgv.Columns["nama_transaksi"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["jumlah"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion

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