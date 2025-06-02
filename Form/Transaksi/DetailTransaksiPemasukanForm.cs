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
    public partial class DetailTransaksiPemasukanForm : Form
    {
        private readonly TransaksiDal _transaksiDal = new();
        private readonly TransaksiDetailDal _transaksiDetailDal = new();
        private CultureInfo _culture = new CultureInfo("id-ID");
        public DetailTransaksiPemasukanForm(int id)
        {
            InitializeComponent();
            this.IsDialogForm();
            GetData(id);
            SetupGridPendapatan();
        }

        private void GetData(int id)
        {
            var transaksi = _transaksiDal.GetData(id);
            var listTransaksiDetail = _transaksiDetailDal.ListData(id);

            gridPendapatan.DataSource = listTransaksiDetail
                .Select((x, index) => new
                {
                    No = index + 1,
                    NamaTransaksi = x.nama_transaksi,
                    Harga = x.harga.ToString("C0", _culture),
                    Jumlah = x.jumlah,
                    Total = (x.harga * x.jumlah).ToString("C0", _culture)
                }).ToList();

            decimal? biayaAdmin = transaksi?.admin;
            decimal? adminConvert = 1 - biayaAdmin;
            int? nominalDiskon = transaksi?.nominal_diskon;

            int pendapatanKotor = listTransaksiDetail.Sum(x => x.harga * x.jumlah); 
            int? modal = listTransaksiDetail.Sum(x => x.modal * x.jumlah); 
            int? pendapatanBersih = Convert.ToInt32((pendapatanKotor - nominalDiskon) * biayaAdmin) - modal;

            lblPendapatanKotor.Text = pendapatanKotor.ToString("C0", _culture);
            lblModal.Text = modal?.ToString("C0", _culture) ?? "0";
            lblPendapatanBersih.Text = pendapatanBersih?.ToString("C0", _culture) ?? "0";
            lblNominalDiskon.Text = nominalDiskon?.ToString("C0", _culture);
            lblBiayaAdmin.Text = ((pendapatanKotor - nominalDiskon) * adminConvert)?.ToString("C0", _culture);
            lblTanggal.Text = transaksi?.tanggal.ToString("d MMMM yyyy");

            lblAdminKet.Text = $"Admin ({(adminConvert * 100).ToString()}%)";

        }

        private void SetupGridPendapatan()
        {
            var dgv = gridPendapatan;
            CustomComponent.CustomDataGrid_SmallFont(dgv);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 10;
            dgv.Columns["NamaTransaksi"].FillWeight = 43;
            dgv.Columns["Harga"].FillWeight = 14;
            dgv.Columns["Jumlah"].FillWeight = 15;
            dgv.Columns["Total"].FillWeight = 18;

            dgv.Columns["No"].HeaderText = "   No";
            dgv.Columns["NamaTransaksi"].HeaderText = "Nama Produk";

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Jumlah"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
