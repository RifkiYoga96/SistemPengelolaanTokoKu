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
            CustomizeGridStyle(dgv);

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

        private void CustomizeGridStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Silver;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ForeColor = Color.DimGray;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;

            dgv.ColumnHeadersHeight = 35;
            dgv.RowTemplate.Height = 40;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;

            dgv.RowPrePaint += (s, e) =>
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    e.RowIndex % 2 == 0 ? Color.White : Color.FromArgb(251, 251, 251);
            };
        }
    }
}
