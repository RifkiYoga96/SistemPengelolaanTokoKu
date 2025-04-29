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
    public partial class Pendapatan_UC : UserControl
    {
        private readonly PendapatanDal _pendapatanDal;
        public static DateTime _date1 = DateTime.Today;
        public static DateTime _date2 = DateTime.Today;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        private string _periode = string.Empty;
        private CultureInfo _culture;
        public Pendapatan_UC()
        {
            InitializeComponent();
            _pendapatanDal = new PendapatanDal();
            _culture = new CultureInfo("id-ID");

            InitComponent();
            RegisterEvent();
            LoadData();
            CustomGrid();
        }

        #region INIT COMPONENT
        private void InitComponent()
        {
            var now = DateTime.Today;
            comboTimeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            List<RangeTimeModel> listTime = new List<RangeTimeModel>
            {
                new RangeTimeModel{NameFilter = "Hari ini", TimeFilter1 = now, TimeFilter2 = now.AddDays(1)},
                new RangeTimeModel{NameFilter = "Kemarin", TimeFilter1 = now.AddDays(-1), TimeFilter2 = now},
                new RangeTimeModel{NameFilter = "7 hari lalu", TimeFilter1 = now.AddDays(-6), TimeFilter2 = now.AddDays(1)},
                new RangeTimeModel{NameFilter = "30 hari lalu", TimeFilter1 = now.AddDays(-29), TimeFilter2 = now.AddDays(1)},
                new RangeTimeModel{NameFilter = "90 hari lalu", TimeFilter1 = now.AddDays(-89), TimeFilter2 = now.AddDays(1)},
                new RangeTimeModel{NameFilter = "Atur rentang tanggal", TimeFilter1 = now, TimeFilter2 = now},
            };
            comboTimeFilter.DataSource = listTime;
            comboTimeFilter.DisplayMember = "NameFilter";
            _periode = "Periode : Hari ini";
            lblPeriode.Text = _periode;

            _indexFilterTimeActive = comboTimeFilter.SelectedIndex;

            comboSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSorting.Items.Add("Terbaru ke terlama");
            comboSorting.Items.Add("Terlama ke terbaru");
            comboSorting.SelectedIndex = 0;

            comboTotal.Items.Add("Total Pendapatan Bersih");
            comboTotal.Items.Add("Total Pendapatan Kotor");
            comboTotal.Items.Add("Total Modal");
            comboTotal.SelectedIndex = 0;
        }

        #endregion

        #region EVENT
        private void RegisterEvent()
        {
            comboTimeFilter.SelectedIndexChanged += ComboTimeFilter_SelectedIndexChanged;
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            comboTotal.SelectedIndexChanged += (s,e) => Hitung_TotalPendapatan();

            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            comboSorting.SelectedIndexChanged += ComboSorting_SelectedIndexChanged;
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
            var selectedItem = ((RangeTimeModel)comboTimeFilter.SelectedItem);
            
            if (indexTime == 5)
            {
                var filterForm = new Filter_Form();
                filterForm.Location = new Point(Cursor.Position.X, Cursor.Position.Y - comboTimeFilter.DropDownHeight);
                if (filterForm.ShowDialog() == DialogResult.OK)
                    _periode = $"Periode : {_date1.ToString("d/M/yyyy")} - {_date2.ToString("d/M/yyyy")}";
                else
                    comboTimeFilter.SelectedIndex = _indexFilterTimeActive;
            }
            else
            {
                if (indexTime < 2)
                    _periode = $"Periode : {selectedItem.NameFilter}";
                else
                    _periode = $@"Periode : {selectedItem.TimeFilter1.ToString("d/M/yyyy")} - {selectedItem.TimeFilter2.AddDays(-1).ToString("d/M/yyyy")}";
            }
            ResetPage();
            LoadData();
            _indexFilterTimeActive = comboTimeFilter.SelectedIndex;

            lblPeriode.Text = _periode;
        }

        #endregion

        #region LOADDATA & FILTER

        private FilterModel CreateFilter()
        {
            string search = txtSearch.Text;
            int indexTime = comboTimeFilter.SelectedIndex;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if (search != string.Empty)
            {
                listFilter.Add("(pr.Nama_Produk LIKE '%'+@search+'%')");
                filter.param.Add("@search", search);
            }

            if (indexTime == 5)
            {
                listFilter.Add("(p.Tanggal_Input BETWEEN @date1 AND @date2)");
                filter.param.Add("@date1", _date1);
                filter.param.Add("@date2", _date2);
            }
            else
            {
                listFilter.Add("(p.Tanggal_Input BETWEEN @date1 AND @date2)");
                DateTime date1 = ((RangeTimeModel)comboTimeFilter.SelectedItem).TimeFilter1;
                DateTime date2 = ((RangeTimeModel)comboTimeFilter.SelectedItem).TimeFilter2;
                filter.param.Add("@date1", date1);
                filter.param.Add("@date2", date2);
            }

            if (listFilter.Count > 0)
            {
                filter.sql = " WHERE " + string.Join(" AND ", listFilter);
            }

            return filter;
        }

        private void LoadData()
        {
            var filterData = CreateFilter();
            int totalData = _pendapatanDal.CountData(filterData);
            _totalPage = (int)Math.Ceiling((double)totalData / (int)numericUpDown1.Value); //pembulatan keatas

            int fetch = (int)numericUpDown1.Value;
            int offset = (_pageNow - 1) * fetch;

            filterData.param.Add("@fetch", fetch);
            filterData.param.Add("@offset", offset);

            if (comboSorting.SelectedIndex == 0)
                filterData.sql += " ORDER BY p.Tanggal_Input DESC, p.ID_Pendapatan DESC";
            else
                filterData.sql += " ORDER BY p.Tanggal_Input ASC, p.ID_Pendapatan ASC";

            var listData = _pendapatanDal.ListData(filterData)
                .Select((x, index) => new
                {
                    x.ID_Pendapatan,
                    No = index + 1 + offset,
                    x.Nama_Produk,
                    Pendapatan_Kotor = x.Pendapatan_Kotor.ToString("C0", _culture),
                    Modal = x.Modal.ToString("C0", _culture),
                    Pendapatan_Bersih = x.Pendapatan_Bersih.ToString("C0", _culture),
                    x.Tanggal_Input,
                    x.Jumlah_Produk
                }).ToList();
            dataGridView1.DataSource = listData;

            lblPage.Text = _pageNow.ToString();
            int end_show = Math.Min(offset + fetch, totalData);
            int start_show = end_show == 0 ? 0 : offset + 1;
            lblPaginationInfo.Text = $"Showing {start_show} to {end_show} of {totalData} entries";
            Hitung_TotalPendapatan();
        }

        #endregion

        #region HELPER
        private void CustomGrid()
        {
            var dgv = dataGridView1;
            dgv.CustomDataGrid();

            dgv.Columns["No"].HeaderText = "  No";
            dgv.Columns["Nama_Produk"].HeaderText = "Produk";
            dgv.Columns["Pendapatan_Kotor"].HeaderText = "Pendapatan Kotor";
            dgv.Columns["Pendapatan_Bersih"].HeaderText = "Pendapatan Bersih";
            dgv.Columns["Tanggal_Input"].HeaderText = "Tanggal";
            dgv.Columns["Jumlah_Produk"].HeaderText = "Jumlah Pembelian";

            dgv.Columns["ID_Pendapatan"].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 7;
            dgv.Columns["Nama_Produk"].FillWeight = 23;
            dgv.Columns["Pendapatan_Kotor"].FillWeight = 15;
            dgv.Columns["Modal"].FillWeight = 15;
            dgv.Columns["Pendapatan_Bersih"].FillWeight = 15;
            dgv.Columns["Tanggal_Input"].FillWeight = 12;
            dgv.Columns["Jumlah_Produk"].FillWeight = 13;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15,0,0,0);
            dgv.Columns["Jumlah_Produk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        

        private void Hitung_TotalPendapatan()
        {
            int indexComboTotal = comboTotal.SelectedIndex;
            string fieldName = indexComboTotal == 0 ? "Pendapatan_Bersih"
                : indexComboTotal == 1 ? "Pendapatan_Kotor"
                : "Modal";

            int totalPedapatan = _pendapatanDal.TotalPendapatan(CreateFilter(), fieldName);

            lblPendapatan.Text = totalPedapatan.ToString("C", _culture);
        }

        private void ResetPage()
        {
            _pageNow = 1;
        }
        #endregion
    }
}
