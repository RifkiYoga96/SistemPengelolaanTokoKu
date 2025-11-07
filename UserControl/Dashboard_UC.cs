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
        private ToolTip _toolTip = new ToolTip();
        private int _indexFilterTimeActive = 0;
        public static DateTime _date1 = DateTime.Today;
        public static DateTime _date2 = DateTime.Today;
        public Dashboard_UC()
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();
            LoadData();
            CustomGrids();

            button1.Click += (_, _) =>
            {
                Form n = new PopupSwitchStore();
                n.Show();
            };
        }

        private void InitComponent()
        {
            comboRangeTime.DropDownStyle = ComboBoxStyle.DropDownList;

            comboRangeTime.DataSource = GetTimeFilterOptions(DateTime.Today);
            comboRangeTime.DisplayMember = "NameFilter";
            comboRangeTime.ValueMember = "NameFilter";
            comboRangeTime.SelectedIndex = 3;
            //lblPeriode.Text = "Periode : ";
            _indexFilterTimeActive = comboRangeTime.SelectedIndex;

            _toolTip.SetToolTip(infoProfit, "Daftar produk profit tertinggi.\nTidak termasuk nominal diskon dan biaya proses pesanan");
            _toolTip.SetToolTip(infoAdmin, "Persentase biaya iklan setiap kali \nterjadi transaksi");
            _toolTip.SetToolTip(infoRoas, "ROAS (Return on Ad Spend) adalah rasio pendapatan\n yang dihasilkan dibanding biaya iklan.");
            _toolTip.SetToolTip(infoPrecentBersih, "Persentase pendapatan bersih terhadap pendapatan kotor");
            _toolTip.SetToolTip(infoACOS, "Persentase biaya iklan terhadap pendapatan kotor");
        }

        private List<RangeTimeModel> GetTimeFilterOptions(DateTime now)
        {
             return new List<RangeTimeModel>
                {
                    new RangeTimeModel { NameFilter = "Hari ini", TimeFilter1 = now, TimeFilter2 = now},
                    new RangeTimeModel { NameFilter = "Kemarin", TimeFilter1 = now.AddDays(-1), TimeFilter2 = now.AddDays(-1) },
                    new RangeTimeModel { NameFilter = "7 hari lalu", TimeFilter1 = now.AddDays(-6), TimeFilter2 = now },
                    new RangeTimeModel { NameFilter = "30 hari lalu", TimeFilter1 = now.AddDays(-29), TimeFilter2 = now },
                    new RangeTimeModel { NameFilter = "90 hari lalu", TimeFilter1 = now.AddDays(-89), TimeFilter2 = now },
                    new RangeTimeModel { NameFilter = "Atur rentang tanggal", TimeFilter1 = now, TimeFilter2 = now }
                };
        }

        private void RegisterEvent()
        {
            comboRangeTime.SelectedIndexChanged += (s,e) => SetPeriode();
            numericAdmin.ValueChanged += UpdateAdmin;
            this.Load += (s, e) => SetPeriode();
        }


        private void UpdateAdmin(object? sender, EventArgs e)
        {
            var admin = Convert.ToDecimal(100 - (decimal)numericAdmin.Value) / 100;
            _dashboardDal.UpdateAdminFee(admin);
        }

        private void SetPeriode()
        {
            int indexTime = comboRangeTime.SelectedIndex;
            var selectedItem = (RangeTimeModel)comboRangeTime.SelectedItem;

            if (indexTime == 5)
            {
                var filterForm = new RentangTanggalForm("dashboard")
                {
                    Location = new Point(Cursor.Position.X, Cursor.Position.Y - comboRangeTime.DropDownHeight)
                };

                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    lblPeriode.Text = $"Periode : {_date1:dd/MM/yyyy} - {_date2:dd/MM/yyyy}";
                }
                else
                {
                    comboRangeTime.SelectedIndex = _indexFilterTimeActive;
                }
            }
            else
            {
                lblPeriode.Text = indexTime < 2
                    ? $"Periode : {selectedItem.NameFilter}"
                    : $"Periode : {selectedItem.TimeFilter1:dd/MM/yyyy} - {selectedItem.TimeFilter2.AddDays(-1):dd/MM/yyyy}";
            }

            LoadData();
            _indexFilterTimeActive = comboRangeTime.SelectedIndex;
        }

        private FilterModel CreateFilter()
        {
            var indexTime = comboRangeTime.SelectedIndex;
            var filterTime = comboRangeTime.SelectedItem;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if (indexTime == 5)
            {
                filter.param.Add("@tanggal1", _date1);
                filter.param.Add("@tanggal2", _date2);
            }
            else
            {
                var selectedItem = (RangeTimeModel)comboRangeTime.SelectedItem;
                filter.param.Add("@tanggal1", selectedItem.TimeFilter1);
                filter.param.Add("@tanggal2", selectedItem.TimeFilter2);
            }

            return filter;
        }

        private void LoadData()
        {
            var filter = CreateFilter();

            LoadChart(filter);
            LoadAdmin();
            LoadTabels(filter);
            LoadIklan(filter);
        }

        private void LoadChart(FilterModel filter)
        {
            int produkTerjual = _dashboardDal.GetProdukTerjual(filter);
            int pendapatanKotor = _dashboardDal.GetPendapatanKotor(filter);
            int pendapatanBersih =
                (_dashboardDal.GetPemasukanBersih(filter)) - (_dashboardDal.GetPengeluaran(filter));

            lblProdukTerjual.Text = produkTerjual.ToString();
            lblPendapatanKotor.Text = pendapatanKotor.ToString("C0", _culture);
            lblPendapatanBersih.Text = pendapatanBersih.ToString("C0", _culture);
            lblPercentBersih.Text = CalculatePercent(pendapatanBersih, pendapatanKotor);
        }

        private string CalculatePercent(decimal value, decimal total)
        {
            decimal percent = total == 0 ? 0 : (value / total) * 100;
            return percent.ToString("0.00") + "%";
        }

        private void LoadAdmin()
        {
            decimal admin = _dashboardDal.GetAdminFee();
            decimal adminPercent = Convert.ToDecimal((1 - admin) * 100);

            numericAdmin.Value = adminPercent;
        }

        private void LoadIklan(FilterModel filter)
        {
            int pendapatanKotor = _dashboardDal.GetPendapatanKotor(filter);

            int biayaIklan = _dashboardDal.GetBiayaIklan(filter);
            lblBiayaIklan.Text = biayaIklan.ToString("C0", _culture);
            lblACOS.Text = CalculatePercent(biayaIklan, pendapatanKotor);

            decimal roas = biayaIklan == 0 ? 0.00m : pendapatanKotor/(decimal)biayaIklan;

            lblRoas.Text = roas.ToString("N2");
        }

        private void LoadTabels(FilterModel filter)
        {
            filter.sql += " AND tipe = 1";

            //Top Produk Terjual
            var listTerjual = _dashboardDal.TopProdukTerjual(filter);
            gridProdukTerjual.DataSource = listTerjual.
                Select((x, index) => new
                {
                    No = index + 1,
                    NamaProduk = x.nama_transaksi,
                    Terjual = x.jumlah
                }).ToList();

            //Top Produk Profit
            var listProfit = _dashboardDal.TopProdukProfit(filter);
            gridProdukProfit.DataSource = listProfit.
                Select((x, index) => new
                {
                    No = index + 1,
                    NamaProduk = x.nama_transaksi,
                    Keuntungan = x.pendapatan_bersih?.ToString("C0", _culture)
                }).ToList();
        }

        private void CustomGrids()
        {
            CustomGridPenjualan();
            CustomGridProfit();
        }

        private void CustomGridPenjualan()
        {
            var dgv = gridProdukTerjual;
            CustomComponent.CustomDataGrid(dgv);

            dgv.Columns["No"].HeaderText = "   No";
            dgv.Columns["NamaProduk"].HeaderText = "Nama Produk";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 20;
            dgv.Columns["NamaProduk"].FillWeight = 50;
            dgv.Columns["Terjual"].FillWeight = 30;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);

            // Menonaktifkan warna seleksi untuk sel
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
        }

        private void CustomGridProfit()
        {
            var dgv = gridProdukProfit;
            CustomComponent.CustomDataGrid(dgv);

            dgv.Columns["No"].HeaderText = "   No";
            dgv.Columns["NamaProduk"].HeaderText = "Nama Produk";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 20;
            dgv.Columns["NamaProduk"].FillWeight = 50;
            dgv.Columns["Keuntungan"].FillWeight = 30;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);

            // Menonaktifkan warna seleksi untuk sel
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
        }
    }
}
