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
        private readonly PendapatanDal _pendapatanDal;
        public InputTransaksiForm()
        {
            InitializeComponent();
            this.IsDialogForm();
             _produkDal = new ProdukDal();
            _pendapatanDal = new PendapatanDal();

            InitComponent();
        }

        private void InitComponent()
        {
            var listProduk = _produkDal.ListProdukCombo()
                .Select(x => new produkModel
                {
                    ID_Produk = x.ID_Produk,
                    Nama_Produk = x.Nama_Produk,
                    Harga = x.Harga,
                    Tipe = x.Tipe
                }).ToList();

            //PENDAPATAN
            //ComboBox
            comboPendapatan.DataSource = listProduk.Where(x => x.Tipe == true).ToList();
            comboPendapatan.DisplayMember = "Nama_Produk";
            comboPendapatan.ValueMember = "ID_Produk";


            //PENGELUARAN
            //ComboBox
            comboPengeluaran.DataSource = listProduk.Where(x => x.Tipe == false).ToList();
            comboPengeluaran.DisplayMember = "Nama_Produk";
            comboPengeluaran.ValueMember = "ID_Produk";

            //numericUpDown
            int biaya = comboPengeluaran.SelectedItem != null ? 
                ((produkModel)comboPengeluaran.SelectedItem).Harga : 0;
            numericPengeluaran.Value = biaya;
        }

        private void RegisterEvent()
        {
            btnSavePendapatan.Click += BtnSavePendapatan_Click;
        }

        private void BtnSavePendapatan_Click(object? sender, EventArgs e)
        {
            DateTime date = dtPendapatan.Value.Date;
            int idProduk = (int)(comboPendapatan.SelectedValue ?? 0);
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

            var produk = new PendapatanModel
            {
                ID_Produk = idProduk,
                Tanggal_Input = date,
                Jumlah_Produk = jumlah,
                Pendapatan_Kotor = harga,
                Modal = modal,
                Pendapatan_Bersih = labaBersih,
                Tipe = true // true karena pendapatan
            };

            _pendapatanDal.InsertData(produk);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}