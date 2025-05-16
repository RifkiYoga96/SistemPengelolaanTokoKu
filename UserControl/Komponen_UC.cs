using Dapper;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class Komponen_UC : UserControl
    {
        private readonly BindingList<KomponenItem> _daftarList = new();
        private readonly BindingList<KebutuhanItem> _kebutuhanList = new();
        private readonly BindingSource _bindingDaftar = new();
        private readonly BindingSource _bindingKebutuhan = new();
        private readonly KomponenProdukDal _komponenProdukDal = new();
        private readonly KomponenDal _komponenDal = new();
        private readonly ProdukDal _produkDal = new();
        private bool _editMode = true;

        public Komponen_UC()
        {
            InitializeComponent();
            InitBinding();
            InitCombo();
            InitGrid();
            RegisterEvents();
        }

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
            // Atur urutan kolom
            KebutuhanGrid.Columns["KomponenId"].DisplayIndex = 0;
            KebutuhanGrid.Columns["No"].DisplayIndex = 1;
            KebutuhanGrid.Columns["KomponenName"].DisplayIndex = 2;
            KebutuhanGrid.Columns["Harga"].DisplayIndex = 3;
            KebutuhanGrid.Columns["Stok"].DisplayIndex = 4;
            KebutuhanGrid.Columns["Jumlah"].DisplayIndex = 5; // pastikan ini terakhir
        }

        private void RegisterEvents()
        {
            comboProduk.SelectedIndexChanged += ComboProduk_SelectedIndexChanged;
            DaftarGrid.CellDoubleClick += DaftarGrid_CellDoubleClick;
            KebutuhanGrid.CellDoubleClick += KebutuhanGrid_CellDoubleClick;
            btnSave.Click += BtnSave_Click;
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

            var listAllKomponen = _komponenDal.ListData()?.ToList() ?? new();
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
                    Stok = item.stok
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
                    Harga = item.harga * item.jumlah,
                    Stok = item.stok,
                    Jumlah = item.jumlah
                });
            }
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
                Stok = item.Stok,
                Jumlah = 1
            });

            ReorderNo(_daftarList);
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
                Stok = item.Stok
            });

            ReorderNo(_kebutuhanList);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
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

        private void ReorderNo<T>(BindingList<T> list) where T : KomponenItem
        {
            for (int i = 0; i < list.Count; i++)
                list[i].No = i + 1;
        }

        private void SetTotalHarga()
        {
            var total = _kebutuhanList.Sum(x => x.Jumlah * x.Harga);
        }
    }
}

public class KomponenItem
{
    public int KomponenId { get; set; }
    public int No { get; set; }
    public string KomponenName { get; set; }
    public int Harga { get; set; }
    public int Stok { get; set; }
}

public class KebutuhanItem : KomponenItem //Inheritance (Pewarisan)
{
    public int Jumlah { get; set; }
}