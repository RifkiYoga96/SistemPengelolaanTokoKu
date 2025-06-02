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
    public partial class DetailTransaksiPengeluaranForm : Form
    {
        private readonly TransaksiDal _transaksiDal = new();
        private readonly TransaksiDetailDal _transaksiDetailDal = new();
        private CultureInfo _culture = new CultureInfo("id-ID");
        public DetailTransaksiPengeluaranForm(int id)
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

            gridPengeluaran.DataSource = listTransaksiDetail
                .Select((x, index) => new
                {
                    No = index + 1,
                    NamaTransaksi = x.nama_transaksi,
                    Harga = x.harga.ToString("C0", _culture),
                    Jumlah = x.jumlah,
                    Total = (x.harga * x.jumlah).ToString("C0", _culture)
                }).ToList();

            int harga = listTransaksiDetail.Sum(x => x.harga);

            lblTotal.Text = harga.ToString("C0", _culture);
            lblTanggal.Text = transaksi?.tanggal.ToString("d MMMM yyyy");
        }

        private void SetupGridPendapatan()
        {
            var dgv = gridPengeluaran;
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
