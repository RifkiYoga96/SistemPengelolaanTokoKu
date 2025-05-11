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
    public partial class InputTransaksiForm : Form
    {
        private readonly ProdukDal _produkDal;
        private readonly PengeluaranDal _pengeluaranDal;
        private readonly TransaksiDal _transaksiDal;
        public InputTransaksiForm()
        {
            InitializeComponent();
            this.IsDialogForm();
             _produkDal = new ProdukDal();
            _transaksiDal = new TransaksiDal();
            _pengeluaranDal = new PengeluaranDal();

            InitComponent();
            RegisterEvent();
        }

        private void InitComponent()
        {
            //PENDAPATAN
            //ComboBox
            var listProduk = _produkDal.ListProdukCombo();
            comboPendapatan.DataSource = listProduk;
            comboPendapatan.DisplayMember = "Nama_Produk";
            comboPendapatan.ValueMember = "ID_Produk";

            //PENGELUARAN
            //ComboBox
            var listPengeluaran = _pengeluaranDal.ListPengeluaranCombo();
            comboPengeluaran.DataSource = listPengeluaran;
            comboPengeluaran.DisplayMember = "nama_pengeluaran";
            comboPengeluaran.ValueMember = "id_pengeluaran";
        }

        private void RegisterEvent()
        {
            btnSavePendapatan.Click += SaveDataPendapatan;
            btnSavePengeluaran.Click += SaveDataPengeluaran;
            comboPengeluaran.SelectedIndexChanged += UpdateBiayaPengeluaran;
            comboPendapatan.SelectedIndexChanged += UpdateHargaProduk;
        }


        private void UpdateHargaProduk(object? sender, EventArgs e)
        {
            if (comboPendapatan.SelectedItem == null) return;

            int harga = ((produkModel)comboPendapatan.SelectedItem).Harga;
            numericHargaPendapatan.Value = harga;
        }

        private void UpdateBiayaPengeluaran(object? sender, EventArgs e)
        {
            if (comboPengeluaran.SelectedItem == null) return;

            int harga = ((produkModel)comboPengeluaran.SelectedItem).Harga;
            numericPengeluaran.Value = harga;
        }

        private void SaveDataPendapatan(object? sender, EventArgs e)
        {
            DateTime date = dtPendapatan.Value.Date;
            int idProduk = (int)(comboPendapatan.SelectedValue ?? 0);
            string nama_produk = ((produkModel)comboPendapatan.SelectedItem).Nama_Produk;
            int jumlah = (int)numericJumlahPendapatan.Value;
            int harga = (((produkModel)comboPendapatan.SelectedItem).Harga) * jumlah;
            int modal = (_produkDal.GetModal(idProduk) * jumlah);
            int labaBersih = harga - modal;

            if (idProduk == 0)
            {
                MessageBoxShow.Warning();
                return;
            }
            if (!MessageBoxShow.Confirmation()) return;

            var produk = new TransaksiModel
            {
                nama_transaksi = nama_produk,
                tanggal_input = date,
                pendapatan_kotor = harga,
                modal = modal,
                pendapatan_bersih = labaBersih,
                pengeluaran = null,
                jumlah = jumlah,
                tipe = true //true karena pendapatan
            };

            _transaksiDal.InsertData(produk);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void SaveDataPengeluaran(object? sender, EventArgs e)
        {

            DateTime date = dtPendapatan.Value.Date;
            string nama_pengeluaran = ((produkModel)comboPendapatan.SelectedItem).Nama_Produk;
            int biaya_pengeluaran = (int)numericPengeluaran.Value;

            if (!MessageBoxShow.Confirmation()) return;

            var pengeluaran = new TransaksiModel
            {
                nama_transaksi = nama_pengeluaran,
                tanggal_input = date,
                pendapatan_kotor = null,
                modal = null,
                pendapatan_bersih = null,
                pengeluaran = biaya_pengeluaran,
                jumlah = null,
                tipe = false //false karena pengeluaran
            };

            _transaksiDal.InsertData(pengeluaran);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}