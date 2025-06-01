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
    public partial class Operasional_UC : UserControl
    {
        // Fields
        private readonly OperasionalDal _operasionalDal;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        private readonly CultureInfo _culture;

        // Constructor
        public Operasional_UC()
        {
            InitializeComponent();
            _operasionalDal = new OperasionalDal();
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
            var currentRow = dataGridView1.CurrentRow;

            if (currentRow.Cells["nama_pengeluaran"].Value.ToString() == "Biaya Iklan")
            {
                MessageBoxShow.Warning("Biaya Iklan tidak dapat dihapus!");
                return;
            }

            if (!MessageBoxShow.Confirmation()) return;

            int id = (int)currentRow.Cells[0].Value;
            _operasionalDal.DeleteData(id);
            LoadData();
        }

        private void ShowEditForm(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (new InputOperasionalForm(id).ShowDialog() != DialogResult.OK) return;
            LoadData();
        }

        private void ShowMenuStrip(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]; // agar current row pindah
            dataGridView1.Rows[e.RowIndex].Selected = true;

            if (e.Button == MouseButtons.Left) return;
            menuStrip.Show(Cursor.Position);
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            if (new InputOperasionalForm().ShowDialog() == DialogResult.OK)
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

            listFilter.Add("(nama_pengeluaran <> 'Biaya Admin')");

            if (!string.IsNullOrEmpty(search))
            {
                listFilter.Add("(nama_pengeluaran LIKE '%'+@search+'%')");
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
            int totalData = _operasionalDal.CountData(filterData);
            _totalPage = (int)Math.Ceiling((double)totalData / (int)numericUpDown1.Value);

            int fetch = (int)numericUpDown1.Value;
            int offset = (_pageNow - 1) * fetch;

            filterData.param.Add("@fetch", fetch);
            filterData.param.Add("@offset", offset);

            var listData = _operasionalDal.ListData(filterData)
                .Select((x, index) => new
                {
                    x.id_pengeluaran,
                    No = index + 1 + offset,
                    x.nama_pengeluaran,
                    biaya = x.jumlah_pengeluaran.ToString("C0", _culture)
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
            dgv.Columns["nama_pengeluaran"].HeaderText = "Nama Pengeluaran";
            dgv.Columns["biaya"].HeaderText = "Biaya";

            dgv.Columns["id_pengeluaran"].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 7;
            dgv.Columns["nama_pengeluaran"].FillWeight = 20;
            dgv.Columns["biaya"].FillWeight = 17;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
        }

        private void ResetPage()
        {
            _pageNow = 1;
        }

        #endregion
    }
}
