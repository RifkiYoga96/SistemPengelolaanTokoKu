using Dapper;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class KomponenProduk_UC : UserControl
    {
        private readonly BindingList<KomponenItem> _daftarList = new();
        private readonly BindingList<KebutuhanItem> _kebutuhanList = new();
        private readonly BindingSource _bindingDaftar = new();
        private readonly BindingSource _bindingKebutuhan = new();
        private readonly KomponenProdukDal _komponenProdukDal = new();
        private readonly KomponenDal _komponenDal = new();
        private readonly ProdukDal _produkDal = new();
        private bool _editMode = true;
        private readonly CultureInfo _culture = new CultureInfo("id-ID");
        private decimal _angka = 1000m;

        public KomponenProduk_UC()
        {
            InitializeComponent();
            InitBinding();
            InitCombo();
            InitGrid();
            RegisterEvents();
        }

        #region Init Components

        private void InitBinding()
        {
            _bindingDaftar.DataSource = _daftarList;
            _bindingKebutuhan.DataSource = _kebutuhanList;

            DaftarGrid.DataSource = _bindingDaftar;
            KebutuhanGrid.DataSource = _bindingKebutuhan;

            DaftarGrid.AllowUserToAddRows = false;
            DaftarGrid.AllowUserToDeleteRows = false;
            KebutuhanGrid.AllowUserToAddRows = false;
            KebutuhanGrid.AllowUserToDeleteRows = false;
        }

        private void InitCombo()
        {
            var listProduk = new List<ProdukModel>
            {
                new ProdukModel { id_produk = -1, nama_produk = "--- Pilih Produk ---" }
            };

            listProduk.AddRange(_produkDal.ListProdukCombo());

            comboProduk.DataSource = listProduk;
            comboProduk.DisplayMember = "nama_produk";
            comboProduk.ValueMember = "id_produk";
        }

        private void InitGrid()
        {
            CustomKebutuhanGrid();
            CustomDaftarGrid();
        }

        #endregion

        #region Event & Load Data
        private void RegisterEvents()
        {
            comboProduk.SelectedIndexChanged += ComboProduk_SelectedIndexChanged;
            DaftarGrid.CellDoubleClick += DaftarGrid_CellDoubleClick;
            KebutuhanGrid.CellDoubleClick += KebutuhanGrid_CellDoubleClick;
            btnSave.Click += SaveData;
            editModeTool.Click += EditModeTool_Click;
            normalModeTool.Click += NormalModeTool_Click;
            RegisterMouseClickEvent(this);
        }

        private void RegisterMouseClickEvent(Control control)
        {
            control.MouseClick += KomponenProduk_MouseClick;
            foreach (Control child in control.Controls)
                RegisterMouseClickEvent(child);
        }

        private void KomponenProduk_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void NormalModeTool_Click(object? sender, EventArgs e)
        {
            normalModeTool.Text = "Normal Mode ✔";
            editModeTool.Text = "Edit Mode";
            _editMode = false;
        }

        private void EditModeTool_Click(object? sender, EventArgs e)
        {
            editModeTool.Text = "Edit Mode ✔";
            normalModeTool.Text = "Normal Mode";
            _editMode = true;
        }

        private void ComboProduk_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            int idProduk = (int)comboProduk.SelectedValue;
            if (idProduk == -1)
            {
                _daftarList.Clear();
                _kebutuhanList.Clear();
                return;
            }

            var listAllKomponen = _komponenDal.ListData(new FilterModel())?.ToList() ?? new();
            var listKomponenProduk = _komponenProdukDal.ListData(idProduk)?.ToList() ?? new();
            var komponenUsed = listKomponenProduk.Select(x => x.id_komponen).ToHashSet();

            listAllKomponen.RemoveAll(x => komponenUsed.Contains(x.id_komponen));

            _daftarList.Clear();
            int no = 1;
            foreach (var item in listAllKomponen)
            {
                _daftarList.Add(new KomponenItem
                {
                    KomponenId = item.id_komponen,
                    No = no++,
                    KomponenName = item.nama_komponen,
                    Harga = item.harga,
                    HargaStr = item.harga.ToString("C0", _culture)
                });
            }

            _kebutuhanList.Clear();
            no = 1;
            foreach (var item in listKomponenProduk)
            {
                _kebutuhanList.Add(new KebutuhanItem
                {
                    KomponenId = item.id_komponen,
                    No = no++,
                    KomponenName = item.nama_komponen,
                    Harga = item.harga,
                    HargaStr = item.harga.ToString("C0", _culture),
                    Jumlah = item.jumlah
                });
            }

            SetTotalHarga();
        }

        private void DaftarGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = _daftarList[e.RowIndex];
            _daftarList.RemoveAt(e.RowIndex);

            _kebutuhanList.Add(new KebutuhanItem
            {
                No = _kebutuhanList.Count + 1,
                KomponenId = item.KomponenId,
                KomponenName = item.KomponenName,
                Harga = item.Harga,
                HargaStr = item.Harga.ToString("C0", _culture),
                Jumlah = 1
            });

            ReorderNo(_daftarList);
            SetTotalHarga();
        }

        private void KebutuhanGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _editMode) return;

            var item = _kebutuhanList[e.RowIndex];
            _kebutuhanList.RemoveAt(e.RowIndex);

            _daftarList.Add(new KomponenItem
            {
                No = _daftarList.Count + 1,
                KomponenId = item.KomponenId,
                KomponenName = item.KomponenName,
                Harga = item.Harga,
                HargaStr = item.Harga.ToString("C0",_culture)
            });

            ReorderNo(_kebutuhanList);
            SetTotalHarga();
        }

        private void SaveData(object? sender, EventArgs e)
        {
            int idProduk = (int)comboProduk.SelectedValue;

            if (idProduk == -1)
            {
                MessageBoxShow.Warning("Pilih produk terlebih dahulu");
                return;
            }

            if (_kebutuhanList.Count == 0)
            {
                MessageBoxShow.Warning("Tidak ada komponen yang dipilih");
                return;
            }

            if (!MessageBoxShow.Confirmation("Apakah anda yakin ingin menyimpan data?")) return;

            _komponenProdukDal.DeleteData(idProduk);

            foreach (var item in _kebutuhanList)
            {
                var komponenProduk = new KomponenProdukModel
                {
                    id_produk = idProduk,
                    id_komponen = item.KomponenId,
                    jumlah = item.Jumlah
                };
                _komponenProdukDal.InsertData(komponenProduk);
            }

            MessageBoxShow.Information("Data berhasil disimpan");
        }

        #endregion

        #region Helper

        private void ReorderNo<T>(BindingList<T> list) where T : KomponenItem
        {
            for (int i = 0; i < list.Count; i++)
                list[i].No = i + 1;
        }

        private void SetTotalHarga()
        {
            var total = _kebutuhanList.Sum(x => x.Jumlah * x.Harga);
            txtTotalHarga.Text = total.ToString("C0",_culture);
        }

        private void CustomKebutuhanGrid()
        {
            CustomGrids(KebutuhanGrid);

            // Atur urutan kolom
            KebutuhanGrid.Columns["KomponenId"].DisplayIndex = 0;
            KebutuhanGrid.Columns["No"].DisplayIndex = 1;
            KebutuhanGrid.Columns["KomponenName"].DisplayIndex = 2;
            KebutuhanGrid.Columns["HargaStr"].DisplayIndex = 3;
            KebutuhanGrid.Columns["Jumlah"].DisplayIndex = 4;

            //sembunyikan kolom
            KebutuhanGrid.Columns["KomponenId"].Visible = false;
            KebutuhanGrid.Columns["Harga"].Visible = false;

            // Atur nama kolom
            KebutuhanGrid.Columns["No"].HeaderText = "  No";
            KebutuhanGrid.Columns["KomponenName"].HeaderText = "Nama Komponen";
            KebutuhanGrid.Columns["Jumlah"].HeaderText = "    Jumlah";
            KebutuhanGrid.Columns["HargaStr"].HeaderText = "Harga Satuan";


            // Atur Fill dan lebar kolom
            KebutuhanGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KebutuhanGrid.Columns["No"].FillWeight = 10;
            KebutuhanGrid.Columns["KomponenName"].FillWeight = 40;
            KebutuhanGrid.Columns["HargaStr"].FillWeight = 30;
            KebutuhanGrid.Columns["Jumlah"].FillWeight = 20;

            // Atur padding & Alignment
            KebutuhanGrid.Columns["No"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            KebutuhanGrid.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CustomDaftarGrid()
        {
            CustomGrids(this.DaftarGrid);

            //sembunyikan kolom
            DaftarGrid.Columns["KomponenId"].Visible = false;
            DaftarGrid.Columns["Harga"].Visible = false;

            // Atur nama kolom
            DaftarGrid.Columns["No"].HeaderText = "  No";
            DaftarGrid.Columns["KomponenName"].HeaderText = "Nama Komponen";
            DaftarGrid.Columns["HargaStr"].HeaderText = "Harga Satuan";

            // Atur Fill dan lebar kolom
            DaftarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaftarGrid.Columns["No"].FillWeight = 10;
            DaftarGrid.Columns["KomponenName"].FillWeight = 40;
            DaftarGrid.Columns["HargaStr"].FillWeight = 30;

            // Atur padding
            DaftarGrid.Columns["No"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
        }

        private void CustomGrids(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Mengatur ukuran font header kolom
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Silver;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Mengatur warna header kolom
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ForeColor = Color.DimGray;


            // Menonaktifkan warna seleksi untuk sel
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;

            dgv.ColumnHeadersHeight = 35;
            dgv.RowTemplate.Height = 40;

            dgv.RowHeadersVisible = false;

            // Mencegah penggeseran kolom
            dgv.AllowUserToOrderColumns = false;

            // Mencegah pengubahan ukuran kolom
            dgv.AllowUserToResizeColumns = true;

            // Mencegah pengubahan ukuran baris
            dgv.AllowUserToResizeRows = false;

            // Mencegah penambahan baris baru
            dgv.AllowUserToAddRows = false;

            dgv.RowPrePaint += (s, e) =>
            {
                if (e.RowIndex % 2 == 0) // Baris genap (putih)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                else // Baris ganjil (abu-abu)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(251, 251, 251);
            };
        }

        #endregion
    }
}

public class KomponenItem
{
    public int KomponenId { get; set; }
    public int No { get; set; }
    public string KomponenName { get; set; }
    public int Harga { get; set; }
    public string HargaStr { get; set; }
}

public class KebutuhanItem : KomponenItem //Inheritance (Pewarisan)
{
    public int Jumlah { get; set; }
}