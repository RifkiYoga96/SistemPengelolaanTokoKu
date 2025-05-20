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
    public partial class Dashboard_UC : UserControl
    {
        private readonly DashboardDal _dashboardDal = new();
        private readonly CultureInfo _culture = new CultureInfo("id-ID");
        public Dashboard_UC()
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();
        }

        private void InitComponent()
        {
            comboRangeTime.DropDownStyle = ComboBoxStyle.DropDownList;

            comboRangeTime.DataSource = GetTimeFilterOptions(DateTime.Now);
            comboRangeTime.DisplayMember = "NameFilter";
            comboRangeTime.ValueMember = "NameFilter";
            comboRangeTime.SelectedIndex = 3;
        }

        private List<RangeTimeModel> GetTimeFilterOptions(DateTime now)
        {
            return new List<RangeTimeModel>
                {
                    new RangeTimeModel { NameFilter = "Hari ini", TimeFilter1 = now, TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "Kemarin", TimeFilter1 = now.AddDays(-1), TimeFilter2 = now },
                    new RangeTimeModel { NameFilter = "7 hari lalu", TimeFilter1 = now.AddDays(-6), TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "30 hari lalu", TimeFilter1 = now.AddDays(-29), TimeFilter2 = now.AddDays(1) },
                    new RangeTimeModel { NameFilter = "90 hari lalu", TimeFilter1 = now.AddDays(-89), TimeFilter2 = now.AddDays(1) }
                };
        }

        private void RegisterEvent()
        {
            comboRangeTime.SelectedIndexChanged += (s, e) => LoadData();
        }

        private FilterModel CreateFilter()
        {
            var filterTime = comboRangeTime.SelectedItem;
            var tanggal1 = ((RangeTimeModel)filterTime).TimeFilter1;
            var tanggal2 = ((RangeTimeModel)filterTime).TimeFilter2;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            listFilter.Add($"tanggal_input BETWEEN @tanggal1 AND @tanggal2");
            filter.param.Add("@tanggal1", tanggal1);
            filter.param.Add("@tanggal2", tanggal2);

            if (listFilter.Any())
            {
                filter.sql = " WHERE " + string.Join(" AND ", listFilter);
            }

            return filter;
        }

        private void LoadData()
        {
            var filter = CreateFilter();

            LoadChart(filter);
        }

        private void LoadChart(FilterModel filter)
        {
            int produkTerjual = _dashboardDal.GetProdukTerjual(filter);
            int pendapatanKotor = _dashboardDal.GetPendapatanKotor(filter);
            int pendapatanBersih = _dashboardDal.GetPendapatanBersih(filter);

            lblProdukTerjual.Text = produkTerjual.ToString();
            lblPendapatanKotor.Text = pendapatanKotor.ToString("C0", _culture);
            lblPendapatanBersih.Text = pendapatanBersih.ToString("C0", _culture);
        }
    }
}
