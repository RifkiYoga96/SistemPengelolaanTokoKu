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
    public partial class TabelProduk : Form
    {
        private DbDapper db = new DbDapper();
        public TabelProduk()
        {
            InitializeComponent();
            ngeload();

            txtIDProduk.ReadOnly = true;
        }

        public void ngeload()
        {
            dataGridView1.DataSource = db.ListProduk2(0);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var select = dataGridView1.CurrentRow.Cells["ID_Produk"].Value.ToString();
            if (select == null) return;
            var data = db.ListProduk2(int.Parse(select)).FirstOrDefault();
            if (data == null) return;
            txtIDProduk.Text = data.ID_Produk.ToString();
            txtNamaProduk.Text = data.Nama_Produk.ToString();
            txtHarga.Text = data.Harga.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtIDProduk.Text;
            if (id == "")
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!");
            }
            else
            {
                Delete(int.Parse(id));

            }
        }

        public void Delete(int id_produk)
        {
            string sql = @"DELETE FROM produk WHERE ID_Produk=@ip";
            if (MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var delete = db.InsertUpdateDelete(sql, new { ip = id_produk });
            if (delete > 0)
            {
                ngeload();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id_produk = txtIDProduk.Text;
            string nama_produk = txtNamaProduk.Text;
            string harga = txtHarga.Text;

            if (nama_produk == "" || harga == "")
            {
                MessageBox.Show("Seluruh Data Wajib Diisi kecuali ID Produk");
                return;
            }

            if (id_produk == "")
            {
                Insert(nama_produk, int.Parse(harga));
            }
            else
            {
                Update(int.Parse(id_produk), nama_produk, int.Parse(harga));
            }
        }

        public void Insert(string nama_produk, int harga)
        {
            string sql = @"INSERT INTO produk(Nama_Produk,Harga)
                            VALUES(@np,@h)";
            var insert = db.InsertUpdateDelete(sql, new { np = nama_produk, h = harga });
            if (insert > 0)
            {
                MessageBox.Show("Data Berhasil Di Input!");
                ngeload();
            }
        }

        public void Update(int id_produk, string nama_produk, int harga)
        {
            string sql = @"UPDATE produk SET nama_produk=@np,Harga=@h WHERE ID_Produk=@ip";
            var update = db.InsertUpdateDelete(sql, new { ip = id_produk, np = nama_produk, h = harga });
            if (update > 0)
            {
                MessageBox.Show("Data Berhasil Di Update!");
                ngeload();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtIDProduk.Clear();
            txtNamaProduk.Clear();
            txtHarga.Clear();   
        }
    }
}
