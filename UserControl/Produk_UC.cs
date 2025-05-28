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
    public partial class Produk_UC : UserControl
    {
        // Fields
        private readonly ProdukDal _produkDal;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        private readonly CultureInfo _culture;

        // Constructor
        public Produk_UC()
        {
            InitializeComponent();
            _produkDal = new ProdukDal();
            _culture = new CultureInfo("id-ID");

            RegisterEvent();
            LoadData();
            CustomGrid();
        }

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
        }
        #endregion

        #region Event Handlers
        private void DeleteData(object? sender, EventArgs e)
        {
            if (!MessageBoxShow.Confirmation()) return;

            try
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                _produkDal.DeleteData(id);
            }
            catch (Exception ex)
            {
                MessageBoxShow.Error("Produk tidak dapat dihapus \nkarena terdapat data yang terhubung!");
                return;
            }
            LoadData();
        }

        private void ShowEditForm(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (new InputProdukForm(id).ShowDialog() != DialogResult.OK) return;
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
            if (new InputProdukForm().ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
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

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                listFilter.Add("(nama_produk LIKE '%'+@search+'%')");
                filter.param.Add("@search", search);
            }

            if (listFilter.Any())
            {
                filter.sql = " WHERE " + string.Join(" AND ", listFilter);
            }

            return filter;
        }

        private void LoadData()
        {
            var filterData = CreateFilter();
            int totalData = _produkDal.CountData(filterData);
            _totalPage = (int)Math.Ceiling((double)totalData / (int)numericUpDown1.Value);

            int fetch = (int)numericUpDown1.Value;
            int offset = (_pageNow - 1) * fetch;

            filterData.param.Add("@fetch", fetch);
            filterData.param.Add("@offset", offset);

            var listData = _produkDal.ListData(filterData)
                .Select((x, index) => new
                {
                    x.id_produk,
                    No = index + 1 + offset,
                    x.nama_produk,
                    harga = x.harga.ToString("C0", _culture)
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
            dgv.Columns["nama_produk"].HeaderText = "Nama Produk";
            dgv.Columns["harga"].HeaderText = "Harga";

            dgv.Columns["id_produk"].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 7;
            dgv.Columns["nama_produk"].FillWeight = 20;
            dgv.Columns["harga"].FillWeight = 17;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
        }

        private void ResetPage()
        {
            _pageNow = 1;
        }

        #endregion
    }
}
