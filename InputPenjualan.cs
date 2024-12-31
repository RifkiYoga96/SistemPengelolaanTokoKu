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
    public partial class InputPenjualan : Form
    {
        private DbDapper db;
        DataTable dt = new DataTable();
        const double biayaAdmin = 0.88d;
        List<int> listresult = new List<int>();
        public InputPenjualan()
        {
            InitializeComponent();
            db = new DbDapper();
            list();
            txtNamaProduk.Text = "";
            DapatMembuat();


        }
        public void list()
        {
            var listproduk = db.ListProduk(0);
            dt.Columns.Add("ID_Produk", typeof(int));
            dt.Columns.Add("Nama_Produk");
            dt.Columns.Add("Harga", typeof(int));

            foreach (var produk in listproduk)
            {
                dt.Rows.Add(produk.ID_Produk, produk.Nama_Produk, produk.Harga);
            }

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Nama_Produk";
            comboBox1.ValueMember = "ID_Produk";



        }

        public void KebutuhanBahan()
        {
            int id_produk;
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int id))
            {
                id_produk = id;
                var JumlahProduk = (int)numericjmlh.Value;
                var listkebutuhan = db.ListKebutuhan(id_produk);
                int cek = 1;
                foreach (var bahan in listkebutuhan)
                {
                    var cekStok = db.CekStokBahan(bahan.ID_Bahan, bahan.Jumlah * JumlahProduk);
                    if (!cekStok.Any())
                    {
                        cek = 0;
                        MessageBox.Show($"{bahan.ID_Bahan.ToString()} Ada Komponen Yang Kurang!");
                        return;
                    }
                }

                foreach (var bahan in listkebutuhan)
                {
                    var update = db.UpdateStokBahan(bahan.ID_Bahan, bahan.Jumlah * JumlahProduk);
                    if (update == 0)
                    {
                        return;
                    }
                }

                InsertPesanan();
            }

        }

        public void InsertPesanan()
        {
            int id_produk;
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int id))
            {
                id_produk = id;
                DateTime tanggalInput = dateTimePicker1.Value.Date;
                var NamaProduk = comboBox1.Text;
                int jumlahProduk = (int)numericjmlh.Value;
                double pendapatanKotor = PendapatanKotor(id_produk);
                int modal = TotalModal(id_produk);
                double keuntungan = pendapatanKotor - modal;

                //MessageBox.Show($"{pendapatanKotor} {modal}  {keuntungan}");
                var insert = db.InsertPendapatan(id_produk, pendapatanKotor * jumlahProduk, modal * jumlahProduk, keuntungan * jumlahProduk, tanggalInput, jumlahProduk);
                if (insert == 0)
                {
                    MessageBox.Show($"{NamaProduk} Gagal Di Input!");
                }
            }




        }

        double PendapatanKotor(int id_produk)
        {
            var harga = db.ListProduk(0).FirstOrDefault(x => x.ID_Produk == id_produk);
            if (harga != null)
            {
                double hargaProduk = (double)harga.Harga;
                return hargaProduk * biayaAdmin;
            }
            else
            {
                return 0;
            }
        }

        int TotalModal(int id_produk)
        {
            int jumlahProduk = (int)numericjmlh.Value;
            var listKebutuhan = db.ListKebutuhan(id_produk);
            var JumlahProduk = (int)numericjmlh.Value;
            int modal = 0;
            foreach (var bahan in listKebutuhan)
            {
                var hargaBahan = db.CekStokBahan(bahan.ID_Bahan, bahan.Jumlah * JumlahProduk);
                if (hargaBahan != null)
                {
                    var a = hargaBahan.FirstOrDefault();
                    if (a != null)
                    {
                        int hargaDecimal = (int)a.Harga*bahan.Jumlah;
                        // Tambahkan ke modal setelah konversi ke int
                        modal += hargaDecimal;
                    }
                }
            }
            return modal;
        }


        private void btnInput_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Input Produk?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) ENTER();
        }

        public void ENTER()
        {
            KebutuhanBahan();

            DapatMembuat();
        }

        public void DapatMembuat()
        {
            txtNamaProduk.Text = "";
            int[] ArrIdProduk = new int[dt.Rows.Count];
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                int id_produk = (int)row["ID_Produk"];
                ArrIdProduk[index] = id_produk;
                index++;
            }

            foreach (int id_produk in ArrIdProduk)
            {
                var listKebutuhan = db.ListKebutuhan(id_produk);
                int baris = listKebutuhan.Count();

                Dictionary<string, int> min = new Dictionary<string, int>();

             


                int terkecil = 0;
                var namaProduk = db.ListProduk2(id_produk).FirstOrDefault()?.Nama_Produk;
                string bahanTerSitik = "Kebutuhan Belum Dinput!!";
                foreach (var bahan in listKebutuhan)
                {
                    namaProduk = bahan.Nama_Produk;

                    var stok = db.CekStokBahan(bahan.ID_Bahan, bahan.Jumlah);
                    foreach (var rowstok in stok)
                    {
                        string namaBahan = rowstok.Nama_Bahan;
                        int jumlahstok = rowstok.Stok;
                        int isodigawe = jumlahstok / bahan.Jumlah;

                        min[namaBahan] = isodigawe;
                    }
                    if(min.Count > 0)
                    {
                        var cilik = min.Aggregate((a, b) => a.Value < b.Value ? a : b);
                        terkecil = cilik.Value;
                        bahanTerSitik = cilik.Key;
                    }
                   
                }
                txtNamaProduk.Text += $"{namaProduk} = {terkecil} ({bahanTerSitik})\n";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DapatMembuatcadangan()
        {
            txtNamaProduk.Text = "";
            int[] ArrIdProduk = new int[dt.Rows.Count];
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                int id_produk = (int)row["ID_Produk"];
                ArrIdProduk[index] = id_produk;
                index++;
            }

            foreach (int id_produk in ArrIdProduk)
            {
                var listKebutuhan = db.ListKebutuhan(id_produk);
                int baris = listKebutuhan.Count();

                List<int> list = new List<int>();

                int[] arr = new int[baris];


                int indexx = 0;

                int terkecil = 0;
                string namaProduk = "";
                foreach (var bahan in listKebutuhan)
                {
                    namaProduk = bahan.Nama_Produk;

                    var stok = db.CekStokBahan(bahan.ID_Bahan, bahan.Jumlah);
                    if (stok != null)
                    {
                        foreach (var rowstok in stok)
                        {
                            int jumlahstok = rowstok.Stok;
                            int isodigawe = jumlahstok / bahan.Jumlah;
                            arr[indexx] = isodigawe;
                        }
                    }
                    else
                    {
                        arr[indexx] = 0;
                    }
                    indexx++;
                    terkecil = arr.Min();
                }
                txtNamaProduk.Text += namaProduk + " = " + terkecil.ToString() + "\n";
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericjmlh.Focus(); ;

        }

        private void numericjmlh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) comboBox1.Focus();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ENTER();
        }

        private void btnInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ENTER();
        }
    }
}
