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
    public partial class Pendapatan_UC : UserControl
    {
        private readonly PendapatanDal _pendapatanDal;
        public static DateTime _date1 = DateTime.Today; 
        public static DateTime _date2 = DateTime.Today;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        public Pendapatan_UC()
        {
            InitializeComponent();
            _pendapatanDal = new PendapatanDal();

            InitComponent();
            RegisterEvent();
            LoadData();
        }

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

            _indexFilterTimeActive = comboTimeFilter.SelectedIndex;

            comboSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSorting.Items.Add("Terbaru ke terlama");
            comboSorting.Items.Add("Terlama ke terbaru");
            comboSorting.SelectedIndex = 0;
        }

        private void RegisterEvent()
        {
            comboTimeFilter.SelectedIndexChanged += ComboTimeFilter_SelectedIndexChanged;
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
        }

        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            if(_pageNow > 1)
            {
                _pageNow--;
                LoadData();
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if(_pageNow < _totalPage)
            {
                _pageNow++;
                LoadData();
            }
        }

        private void ComboTimeFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(comboTimeFilter.SelectedIndex == 5)
            {
                var filterForm = new Filter_Form();
                filterForm.Location = new Point(Cursor.Position.X, Cursor.Position.Y - comboTimeFilter.DropDownHeight);
                if(filterForm.ShowDialog() != DialogResult.OK)
                    comboTimeFilter.SelectedIndex = _indexFilterTimeActive;
            }
            LoadData();
            _indexFilterTimeActive = comboTimeFilter.SelectedIndex;
        }

        #region LOADDATA & FILTER

        private FilterModel CreateFilter()
        {
            string search = txtSearch.Text;
            int indexTime = comboTimeFilter.SelectedIndex;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if(search != string.Empty)
            {
                listFilter.Add("(pr.Nama_Produk LIKE '%'+@search+'%')");
                filter.param.Add("@search", search);
            }

            if(indexTime == 5)
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

            if(listFilter.Count > 0)
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
                .Select((x,index) => new
                {
                    No = index + 1 + offset,
                    x.Nama_Produk,
                    x.Pendapatan_Kotor,
                    x.Modal,
                    x.Pendapatan_Bersih,
                    x.Tanggal_Input,
                    x.Jumlah_Produk
                }).ToList();
            dataGridView1.DataSource = listData;
        }

        #endregion


    }
}
