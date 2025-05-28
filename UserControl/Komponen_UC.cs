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
    public partial class Komponen_UC : UserControl
    {
        // Fields
        private readonly KomponenDal _komponenDal;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        private readonly CultureInfo _culture;
        private readonly ImageCustomize _imageCustomize;

        // Constructor
        public Komponen_UC()
        {
            InitializeComponent();
            _komponenDal = new KomponenDal();
            _culture = new CultureInfo("id-ID");
            _imageCustomize = new ImageCustomize();

            InitComponent();
            RegisterEvent();
            LoadData();
            CustomGrid();
        }

        #region Initialization

        private void InitComponent()
        {
            // Keterangan Stok ComboBox
            comboKeteranganStok.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKeteranganStok.Items.AddRange(new[] { "Semua(All)", "Stok Menipis", "Stok Habis" });
            comboKeteranganStok.SelectedIndex = 0;
        }

        #endregion

        #region Event Registration

        private void RegisterEvent()
        {
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnAddData.Click += BtnAddData_Click;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            dataGridView1.CellMouseClick += ShowMenuStrip;
            editMenuStrip.Click += ShowEditForm;
            deleteMenuStrip.Click += DeleteData;
            comboKeteranganStok.SelectedIndexChanged += ComboKeteranganStok_SelectedIndexChanged;
        }



        #endregion

        #region Event Handlers
        private void DeleteData(object? sender, EventArgs e)
        {
            if (!MessageBoxShow.Confirmation()) return;

            try
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                _komponenDal.DeleteData(id);
            }
            catch (Exception ex)
            {
                MessageBoxShow.Error("Komponen tidak dapat dihapus \nkarena terdapat data yang terhubung!");
                return;
            }
            LoadData();
        }

        private void ShowEditForm(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (new InputKomponenForm(id).ShowDialog() != DialogResult.OK) return;
            LoadData();
        }

        private void ShowMenuStrip(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;

            menuStrip.Show(Cursor.Position);
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            if (new InputKomponenForm().ShowDialog() == DialogResult.OK)
            {
                LoadData();
            } 
        }

        private void ComboKeteranganStok_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ResetPage();
            LoadData();
        }

        private void NumericUpDown1_ValueChanged(object? sender, EventArgs e)
        {
            ResetPage();
            LoadData();
        }

        private async void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            ResetPage();
            LoadData();
        }

        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            if (_pageNow > 1)
            {
                _pageNow--;
                LoadData();
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if (_pageNow < _totalPage)
            {
                _pageNow++;
                LoadData();
            }
        }

        #endregion

        #region Data Loading and Filtering

        private FilterModel CreateFilter()
        {
            string search = txtSearch.Text;
            int indexFilter = comboKeteranganStok.SelectedIndex;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                listFilter.Add("(nama_komponen LIKE '%'+@search+'%')");
                filter.param.Add("@search", search);
            }

            if (indexFilter is 1 or 2)
                listFilter.Add(indexFilter == 1 ? 
                    "(stok < stok_minimum AND stok > 0)" : "(stok = 0)");

            if (listFilter.Any())
            {
                filter.sql = " WHERE " + string.Join(" AND ", listFilter);
            }

            return filter;
        }

        private void LoadData()
        {
            Image tersedia = Properties.Resources.Tersedia;
            Image menipis = Properties.Resources.Menipis;
            Image habis = Properties.Resources.Habis;

            byte[] tersediaByte = _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(tersedia, 15));
            byte[] menipisByte = _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(menipis, 15));
            byte[] habisByte = _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(habis, 15));

            var filterData = CreateFilter();
            int totalData = _komponenDal.CountData(filterData);
            _totalPage = (int)Math.Ceiling((double)totalData / (int)numericUpDown1.Value);

            int fetch = (int)numericUpDown1.Value;
            int offset = (_pageNow - 1) * fetch;

            filterData.param.Add("@fetch", fetch);
            filterData.param.Add("@offset", offset);

            var listData = _komponenDal.ListData(filterData)
                .Select((x, index) => new
                {
                    x.id_komponen,
                    No = index + 1 + offset,
                    x.nama_komponen,
                    harga = x.harga.ToString("C0",_culture),
                    x.stok,
                    x.stok_minimum,
                    keterangan_stok = x.stok < x.stok_minimum && x.stok > 0 ?menipisByte
                        : x.stok == 0 ? habisByte : tersediaByte,
                }).ToList();

            dataGridView1.DataSource = listData;

            lblPage.Text = _pageNow.ToString();
            int endShow = Math.Min(offset + fetch, totalData);
            int startShow = endShow == 0 ? 0 : offset + 1;
            lblPaginationInfo.Text = $"Showing {startShow} to {endShow} of {totalData} entries";
        }

        #endregion

        #region Helpers

        private void CustomGrid()
        {
            var dgv = dataGridView1;
            dgv.CustomDataGrid();

            dgv.Columns["No"].HeaderText = "  No";
            dgv.Columns["nama_komponen"].HeaderText = "Nama Komponen";
            dgv.Columns["harga"].HeaderText = "Harga";
            dgv.Columns["stok"].HeaderText = " Stok";
            dgv.Columns["stok_minimum"].HeaderText = " Stok Minimum";
            dgv.Columns["keterangan_stok"].HeaderText = "Keterangan Stok";

            dgv.Columns["id_komponen"].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 7;
            dgv.Columns["nama_komponen"].FillWeight = 20;
            dgv.Columns["harga"].FillWeight = 17;
            dgv.Columns["stok"].FillWeight = 17;
            dgv.Columns["stok_minimum"].FillWeight = 17;
            dgv.Columns["keterangan_stok"].FillWeight = 22;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
            dgv.Columns["stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["stok_minimum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["keterangan_stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["stok"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["stok_minimum"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["keterangan_stok"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ResetPage()
        {
            _pageNow = 1;
        }

        #endregion
    }
}
