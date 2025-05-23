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
    public partial class TransaksiUC : UserControl
    {
        // Fields
        private readonly TransaksiDal _transaksiDal;
        public static DateTime _date1 = DateTime.Today;
        public static DateTime _date2 = DateTime.Today;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        private string _periode = string.Empty;
        private readonly CultureInfo _culture;
        private readonly ImageCustomize _imageCustomize;

        // Constructor
        public TransaksiUC()
        {
            InitializeComponent();
            _transaksiDal = new TransaksiDal();
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
            var now = DateTime.Today;

            // Time Filter ComboBox
            comboTimeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTimeFilter.DataSource = GetTimeFilterOptions(now);
            comboTimeFilter.DisplayMember = "NameFilter";
            _periode = "Periode : Hari ini";
            lblPeriode.Text = _periode;
            _indexFilterTimeActive = comboTimeFilter.SelectedIndex;

            // Sorting ComboBox
            comboSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSorting.Items.AddRange(new[] { "Terbaru ke terlama", "Terlama ke terbaru" });
            comboSorting.SelectedIndex = 0;

            // Total ComboBox
            comboTotal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTotal.Items.AddRange(new[] { "Total Pendapatan Bersih", "Total Pendapatan Kotor", "Total Modal", "Total Pengeluaran" });
            comboTotal.SelectedIndex = 0;
        }

        private List<RangeTimeModel> GetTimeFilterOptions(DateTime now)
        {
            return new List<RangeTimeModel>
                {
                    new RangeTimeModel { NameFilter = "Hari ini", TimeFilter1 = now, TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "Kemarin", TimeFilter1 = now.AddDays(-1), TimeFilter2 = now },
                    new RangeTimeModel { NameFilter = "7 hari lalu", TimeFilter1 = now.AddDays(-6), TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "30 hari lalu", TimeFilter1 = now.AddDays(-29), TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "90 hari lalu", TimeFilter1 = now.AddDays(-89), TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "Atur rentang tanggal", TimeFilter1 = now, TimeFilter2 = now }
                };
        }

        #endregion

        #region Event Registration

        private void RegisterEvent()
        {
            comboTimeFilter.SelectedIndexChanged += ComboTimeFilter_SelectedIndexChanged;
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            comboTotal.SelectedIndexChanged += (s, e) => Hitung_TotalPendapatan();
            btnAddData.Click += BtnAddData_Click;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            comboSorting.SelectedIndexChanged += ComboSorting_SelectedIndexChanged;
            dataGridView1.CellMouseClick += ShowMenuStrip;
            deleteMenuStrip.Click += DeleteData;
        }

        #endregion

        #region Event Handlers
        private void DeleteData(object? sender, EventArgs e)
        {
            if (!MessageBoxShow.Confirmation()) return;

            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _transaksiDal.DeleteData(id);
            LoadData();
        }

        private void ShowEditForm(object? sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;
            int index = currentRow.Cells["pengeluaran"].Value == null
                ? 0 : 1;
            int id = (int)currentRow.Cells[0].Value;

            var modal = new InputTransaksiForm(index, id);
            if (modal.ShowDialog() != DialogResult.OK) return;

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
            if (new InputTransaksiForm(0).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ComboSorting_SelectedIndexChanged(object? sender, EventArgs e)
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

        private void ComboTimeFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int indexTime = comboTimeFilter.SelectedIndex;
            var selectedItem = (RangeTimeModel)comboTimeFilter.SelectedItem;

            if (indexTime == 5)
            {
                var filterForm = new RentangTanggalForm
                {
                    Location = new Point(Cursor.Position.X, Cursor.Position.Y - comboTimeFilter.DropDownHeight)
                };

                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    _periode = $"Periode : {_date1:dd/MM/yyyy} - {_date2:dd/MM/yyyy}";
                }
                else
                {
                    comboTimeFilter.SelectedIndex = _indexFilterTimeActive;
                }
            }
            else
            {
                _periode = indexTime < 2
                    ? $"Periode : {selectedItem.NameFilter}"
                    : $"Periode : {selectedItem.TimeFilter1:dd/MM/yyyy} - {selectedItem.TimeFilter2.AddDays(-1):dd/MM/yyyy}";
            }

            ResetPage();
            LoadData();
            _indexFilterTimeActive = comboTimeFilter.SelectedIndex;
            lblPeriode.Text = _periode;
        }

        #endregion

        #region Data Loading and Filtering

        private FilterModel CreateFilter()
        {
            string search = txtSearch.Text;
            int indexTime = comboTimeFilter.SelectedIndex;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                listFilter.Add("(t.nama_transaksi LIKE '%'+@search+'%')");
                filter.param.Add("@search", search);
            }

            if (indexTime == 5)
            {
                listFilter.Add("(t.tanggal BETWEEN @date1 AND @date2)");
                filter.param.Add("@date1", _date1);
                filter.param.Add("@date2", _date2);
            }
            else
            {
                var selectedItem = (RangeTimeModel)comboTimeFilter.SelectedItem;
                listFilter.Add("(t.tanggal BETWEEN @date1 AND @date2)");
                filter.param.Add("@date1", selectedItem.TimeFilter1);
                filter.param.Add("@date2", selectedItem.TimeFilter2);
            }

            if (listFilter.Any())
            {
                filter.sql = " WHERE " + string.Join(" AND ", listFilter);
            }

            return filter;
        }

        private void LoadData()
        {
            Image pendapatan = Properties.Resources.Pendapatan;
            Image pengeluaran = Properties.Resources.Pengeluaran;

            var filterData = CreateFilter();
            int totalData = _transaksiDal.CountData(filterData);
            _totalPage = (int)Math.Ceiling((double)totalData / (int)numericUpDown1.Value);

            int fetch = (int)numericUpDown1.Value;
            int offset = (_pageNow - 1) * fetch;

            filterData.param.Add("@fetch", fetch);
            filterData.param.Add("@offset", offset);

            filterData.sql += comboSorting.SelectedIndex == 0
                ? " ORDER BY t.tanggal DESC, t.id_transaksi DESC"
                : " ORDER BY t.tanggal ASC, t.id_transaksi ASC";

            var listData = _transaksiDal.ListData(filterData)
                .Select((x, index) => new
                {
                    x.id_transaksi,
                    No = index + 1 + offset,
                    x.nama_transaksi,
                    x.tanggal_input,
                    pendapatan_kotor = x.pendapatan_kotor?.ToString("C0", _culture),
                    admin = x.admin.ToString() + "%",
                    modal = x.modal?.ToString("C0", _culture),
                    pendapatan_bersih = x.pendapatan_bersih?.ToString("C0", _culture),
                    pengeluaran = x.pengeluaran?.ToString("C0", _culture),
                    x.jumlah,
                    tipe = x.tipe ? 
                        _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(pendapatan, 15)) 
                        : _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(pengeluaran, 15))
                }).ToList();

            dataGridView1.DataSource = listData;

            lblPage.Text = _pageNow.ToString();
            int endShow = Math.Min(offset + fetch, totalData);
            int startShow = endShow == 0 ? 0 : offset + 1;
            lblPaginationInfo.Text = $"Showing {startShow} to {endShow} of {totalData} entries";

            Hitung_TotalPendapatan();
        }

        #endregion

        #region Helpers

        private void CustomGrid()
        {
            var dgv = dataGridView1;
            dgv.CustomDataGrid();

            dgv.Columns["No"].HeaderText = "  No";
            dgv.Columns["nama_transaksi"].HeaderText = "Nama Transaksi";
            dgv.Columns["tanggal_input"].HeaderText = "Tanggal";
            dgv.Columns["pendapatan_kotor"].HeaderText = "Pendapatan Kotor";
            dgv.Columns["pendapatan_bersih"].HeaderText = "Pendapatan Bersih";
            dgv.Columns["pengeluaran"].HeaderText = "Pengeluaran";
            dgv.Columns["jumlah"].HeaderText = "Jumlah";
            dgv.Columns["tipe"].HeaderText = "     Tipe";
            dgv.Columns["admin"].HeaderText = "Admin Fee";

            dgv.Columns["id_transaksi"].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 6;
            dgv.Columns["nama_transaksi"].FillWeight = 13;
            dgv.Columns["tanggal_input"].FillWeight = 11;
            dgv.Columns["pendapatan_kotor"].FillWeight = 11;
            dgv.Columns["modal"].FillWeight = 8;
            dgv.Columns["admin"].FillWeight = 10;
            dgv.Columns["pendapatan_bersih"].FillWeight = 11;
            dgv.Columns["pengeluaran"].FillWeight = 8;
            dgv.Columns["jumlah"].FillWeight = 11;
            dgv.Columns["tipe"].FillWeight = 11;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
            dgv.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["tipe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns["jumlah"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Hitung_TotalPendapatan()
        {
            int indexComboTotal = comboTotal.SelectedIndex;
            string fieldName = indexComboTotal switch
            {
                0 => "td.pendapatan_bersih",
                1 => "td.harga",
                2 => "td.modal",
                _ => "t.pengeluaran"
            };

            bool isLabaBersih = indexComboTotal == 0;

            int totalPendapatan = _transaksiDal.TotalPendapatan(CreateFilter(), fieldName, isLabaBersih);
            lblPendapatan.Text = totalPendapatan.ToString("C", _culture);
        }

        private void ResetPage()
        {
            _pageNow = 1;
        }

        #endregion
    }
}
