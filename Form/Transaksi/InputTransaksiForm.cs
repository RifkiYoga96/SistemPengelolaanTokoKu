using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class InputTransaksiForm : Form
    {
        private readonly ProdukDal _produkDal;
        private readonly OperasionalDal _pengeluaranDal;
        private readonly TransaksiDal _transaksiDal;
        private readonly int _id;
        public InputTransaksiForm(int tabIndex,int id = 0)
        {
            InitializeComponent();
            this.IsDialogForm();
            _produkDal = new ProdukDal();
            _transaksiDal = new TransaksiDal();
            _pengeluaranDal = new OperasionalDal();

            _id = id;
            CheckingUpdateData(tabIndex);
            
            InitComponent();
            RegisterEvent();
        }

        private void InitComponent()
        {
            //PENDAPATAN
            //ComboBox
            var listProduk = _produkDal.ListProdukCombo();
            comboProduk.DataSource = listProduk;
            comboProduk.DisplayMember = "Nama_Produk";
            comboProduk.ValueMember = "ID_Produk";
            UpdateHargaProduk();

            //PENGELUARAN
            //ComboBox
            var listPengeluaran = _pengeluaranDal.ListPengeluaranCombo();
            comboPengeluaran.DataSource = listPengeluaran;
            comboPengeluaran.DisplayMember = "nama_pengeluaran";
            comboPengeluaran.ValueMember = "id_pengeluaran";
            UpdateBiayaPengeluaran();
        }

        private void RegisterEvent()
        {
            btnSavePendapatan.Click += SaveDataPendapatan;
            btnSavePengeluaran.Click += SaveDataPengeluaran;
            comboPengeluaran.SelectedIndexChanged += (s, e) => UpdateBiayaPengeluaran();
            comboProduk.SelectedIndexChanged += (s, e) => UpdateHargaProduk();
        }


        private void SaveDataPendapatan(object? sender, EventArgs e)
        {
            DateTime date = dtPendapatan.Value.Date;
            int idProduk = (int)(comboProduk.SelectedValue ?? 0);
            string nama_produk = ((ProdukModel)comboProduk.SelectedItem).nama_produk;
            int jumlah = (int)numericJumlahPendapatan.Value;
            int harga = (((ProdukModel)comboProduk.SelectedItem).harga) * jumlah;
            int modal = (_produkDal.GetModal(idProduk) * jumlah);

            decimal admin = _pengeluaranDal.GetAdmin();
            int labaBersih = Convert.ToInt32((harga * admin) - modal);

            MessageBox.Show($"{labaBersih.ToString()}  {admin.ToString()}");

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
            string nama_pengeluaran = ((OperasionalModel)comboPengeluaran.SelectedItem).nama_pengeluaran;
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

        private void UpdateHargaProduk()
        {
            if (comboProduk.SelectedItem == null) return;

            int harga = ((ProdukModel)comboProduk.SelectedItem).harga;
            numericHargaPendapatan.Value = harga;
        }

        private void UpdateBiayaPengeluaran()
        {
            if (comboPengeluaran.SelectedItem == null) return;

            decimal harga = ((OperasionalModel)comboPengeluaran.SelectedItem).jumlah_pengeluaran;
            numericPengeluaran.Value = Convert.ToInt32(harga);
        }

        private void CheckingUpdateData(int tabIndex)
        {
            if (_id == 0) return; //jika id = 0, tidak ada data yang diupdate
            if (tabIndex == 0)
            {
                GetDataPendapatan(_id);
                tabControl1.SelectedTab = tabPendapatan;
            }
            else
            {
                GetDataPengeluaran(_id);
                tabControl1.SelectedTab = tabPengeluaran;
            }
            tabControl1.Selecting += (s, e) => e.Cancel = true; //cancel tab lain
        }

        private void GetDataPendapatan(int id)
        {
            var data = _transaksiDal.GetData(id);
            if (data is null) return;

            dtPendapatan.Value = data.tanggal_input; //dateTime Tanggal
            foreach (var item in comboProduk.Items) //combobox Produk
                if (item is ProdukModel p)
                    if (p.nama_produk == data.nama_transaksi)
                        comboProduk.SelectedItem = item;
            numericJumlahPendapatan.Value = Convert.ToInt32(data.jumlah); //numericUpDown Harga
            numericHargaPendapatan.Value = Convert.ToInt32(data.pendapatan_kotor); //numericUpDown Jumlah
        }

        private void GetDataPengeluaran(int id)
        {
            var data = _transaksiDal.GetData(id);
            if (data is null) return;

            dtPengeluaran.Value = data.tanggal_input; //dateTime Tanggal
            foreach (var item in comboPengeluaran.Items) //combobox Produk
                if (item is OperasionalModel p)
                    if (p.nama_pengeluaran == data.nama_transaksi)
                        comboPengeluaran.SelectedItem = item;
            numericPengeluaran.Value = Convert.ToInt32(data.pengeluaran); //numericUpDown Harga
        }
    }
}