using Dapper;
using System.ComponentModel;
using System.Data;
using System.Security;
using System.Diagnostics;


namespace Shopee
{
    public partial class KomponenProduk : Form
    {
        private BindingSource _bindingDaftar = new();
        private BindingSource _bindingKebutuhan = new();
        private DataTable _dtDaftar = new();
        private DataTable _dtKebutuhan = new();
        private readonly DbDapper _dbDapper = new DbDapper();
        private bool _editMode = true;
        public KomponenProduk()
        {
            InitializeComponent();
            _bindingDaftar.DataSource = _dtDaftar;
            _bindingKebutuhan.DataSource = _dtKebutuhan;

            DaftarGrid.DataSource = _bindingDaftar;
            KebutuhanGrid.DataSource = _bindingKebutuhan;

            DaftarGrid.AllowUserToAddRows = false;
            DaftarGrid.AllowUserToDeleteRows = false;
            KebutuhanGrid.AllowUserToAddRows = false;
            KebutuhanGrid.AllowUserToDeleteRows = false;

            InitDataTable();
            InitCombo();
            RegisterEvent();
            InitGrid();
        }

        private void RegisterEvent()
        {
            comboProduk.SelectedIndexChanged += ComboProduk_SelectedIndexChanged;
            DaftarGrid.CellDoubleClick += DaftarGrid_CellDoubleClick;
            KebutuhanGrid.CellDoubleClick += KebutuhanGrid_CellDoubleClick;
            btnSave.Click += BtnSave_Click;
            editModeTool.Click += EditModeTool_Click;
            normalModeTool.Click += NormalModeTool_Click;

            RegisterMouseClickEvent(this);
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

        private void RegisterMouseClickEvent(Control control)
        {
            //Debug.WriteLine($"Adding event to control: {control.Name}");
            control.MouseClick += KomponenProduk_MouseClick;
            foreach (Control child in control.Controls)
            {
                //Debug.WriteLine($"Processing child: {child.Name}");
                RegisterMouseClickEvent(child);
            }

        }
        private void KomponenProduk_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void InitDataTable()
        {
            _dtDaftar.Columns.Add("No",typeof(int));
            _dtDaftar.Columns.Add("BahanId",typeof(int));
            _dtDaftar.Columns.Add("BahanName",typeof(string));
            _dtDaftar.Columns.Add("KebutuhanId",typeof(int));
            _dtDaftar.Columns.Add("Jumlah",typeof(int));

            _dtKebutuhan.Columns.Add("No", typeof(int));
            _dtKebutuhan.Columns.Add("BahanId", typeof(int));
            _dtKebutuhan.Columns.Add("BahanName", typeof(string));
            _dtKebutuhan.Columns.Add("KebutuhanId", typeof(int));
            _dtKebutuhan.Columns.Add("Jumlah", typeof(int));

        }


        private void KebutuhanGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _editMode) return;
            var currentRow = _dtKebutuhan.Rows[e.RowIndex];

            var NewRow = _dtDaftar.NewRow();
            NewRow["No"] = _dtDaftar.Rows.Count + 1;
            NewRow["BahanId"] = currentRow["BahanId"];
            NewRow["BahanName"] = currentRow["BahanName"];
            _dtDaftar.Rows.Add(NewRow);

            _dtKebutuhan.Rows.RemoveAt(e.RowIndex);

            for (int i = 0; i < _dtKebutuhan.Rows.Count; i++)
                _dtKebutuhan.Rows[i]["No"] = i + 1;
        }

        
        private void DaftarGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var currentRow = _dtDaftar.Rows[e.RowIndex];

            var NewRow = _dtKebutuhan.NewRow();
            NewRow["No"] = _dtKebutuhan.Rows.Count + 1;
            NewRow["BahanId"] = currentRow["BahanId"];
            NewRow["BahanName"] = currentRow["BahanName"];
            NewRow["Jumlah"] = currentRow["Jumlah"];
            _dtKebutuhan.Rows.Add(NewRow);

            _dtDaftar.Rows.RemoveAt(e.RowIndex);

            for (int i = 0; i < _dtDaftar.Rows.Count; i++)
                _dtDaftar.Rows[i]["No"] = i + 1;
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            int idProduk = (int)comboProduk.SelectedValue;
            var cekAvaible = _dbDapper.ListKebutuhan(idProduk);
            const string sql = @"INSERT INTO Kebutuhan(ID_Produk,ID_Bahan,Jumlah)
                                 VALUES(@ID_Produk,@ID_Bahan,@Jumlah)";
            _dbDapper.InsertUpdateDelete("DELETE Kebutuhan WHERE ID_Produk = @idProduk", new {idProduk = idProduk });

            for(int i = 0; i < _dtKebutuhan.Rows.Count; i++)
            {
                var row = _dtKebutuhan.Rows[i];

                var dp = new DynamicParameters();
                dp.Add(@"ID_Produk", idProduk, DbType.Int32);
                dp.Add(@"ID_Bahan", row["BahanId"], DbType.Int32);
                dp.Add(@"Jumlah", row["Jumlah"], DbType.Int32);
                _dbDapper.InsertUpdateDelete(sql, dp);
            }

            MessageBox.Show("Data Berhasil Disimpan","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ComboProduk_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadGrid();
        }

        private void InitCombo()
        {
            var listProduk = new List<produkModel>()
            {
                new produkModel{ID_Produk = -1, Nama_Produk = "--- Pilih Produk ---"}
            };
            listProduk.AddRange(_dbDapper.ListProduk(0).Select(x => new produkModel
            {
                ID_Produk = x.ID_Produk,
                Nama_Produk = x.Nama_Produk
            }).ToList());

            comboProduk.DataSource = listProduk;
            comboProduk.DisplayMember = "Nama_Produk";
            comboProduk.ValueMember = "ID_Produk";
        }

        private void LoadGrid()
        {
            int idProduk = (int)comboProduk.SelectedValue;
            if (idProduk == -1)
            {
                DaftarGrid.DataSource = null;
                return;
            }
            var listAllBahan = _dbDapper.ListBahan(0)?.ToList() ?? new();
            var listBahan = _dbDapper.ListKebutuhan(idProduk)?.ToList() ?? new();
            var IdBahanInProduk = listBahan.Select(x => x.ID_Bahan)?.ToList() ?? new();

            listAllBahan.RemoveAll(x => IdBahanInProduk.Contains(x.ID_Bahan));

            _dtDaftar.Rows.Clear();
            foreach(var item in listAllBahan)
            {
                var NewRowDaftar = _dtDaftar.NewRow();
                NewRowDaftar["No"] = _dtDaftar.Rows.Count + 1;
                NewRowDaftar["BahanId"] = item.ID_Bahan;
                NewRowDaftar["BahanName"] = item.Nama_Bahan;
                _dtDaftar.Rows.Add(NewRowDaftar);
            }

            _dtKebutuhan.Rows.Clear();
            foreach (var item in listBahan)
            {
                var NewRow = _dtKebutuhan.NewRow();
                NewRow["No"] = _dtKebutuhan.Rows.Count + 1;
                NewRow["BahanId"] = item.ID_Bahan;
                NewRow["BahanName"] = item.Nama_Bahan;
                NewRow["Jumlah"] = item .Jumlah;
                _dtKebutuhan.Rows.Add(NewRow);
            }
        }

        private void InitGrid()
        {
            DaftarGrid.Columns[1].Visible = false;
            DaftarGrid.Columns[3].Visible = false;
            DaftarGrid.Columns[4].Visible = false;

            KebutuhanGrid.Columns[1].Visible = false;
            KebutuhanGrid.Columns[3].Visible = false;

            DaftarGrid.Columns[0].Width = 35;
            DaftarGrid.Columns[2].Width = 150;

            KebutuhanGrid.Columns[0].Width = 35;
            KebutuhanGrid.Columns[2].Width = 150;
            KebutuhanGrid.Columns[4].Width = 80;
        }
    }
}

public class DaftarKebutuhan
{
    public int No { get; set; }
    public int BahanId { get; set; }
    public string BahanName { get; set; }
    public int KebutuhanId { get; set; }
    public int Jumlah {  get; set; }
}
