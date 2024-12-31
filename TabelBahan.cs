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
    public partial class TabelBahan : Form
    {
        private DbDapper db;
        public TabelBahan()
        {
            InitializeComponent();
            db = new DbDapper();
            ngeload();
        }

        public void ngeload()
        {
            dataGridView1.DataSource = db.ListBahan(0);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtIDBahan.Text;
            string nama = txtNamaBahan.Text;
            string harga = txtHarga.Text;
            string stok = txtStok.Text;


            if (id == "")
            {
                DataBaru(nama, int.Parse(harga), int.Parse(stok));
            }
            else if (id != "")
            {
                UpdateData(int.Parse(id), nama, int.Parse(harga), int.Parse(stok));
            }
            else
            {
                MessageBox.Show("Seluruh Data Wajib Diisi kecuali ID!");
            }
        }

        public void DataBaru(string nama, int harga, int stok)
        {
            string sql = @"INSERT INTO bahan(Nama_Bahan,Harga,Stok) VALUES(@nama,@harga,@stok)";
            var insert = db.InsertUpdateDelete(sql, new { nama = nama, harga = harga, stok = stok });

            if (insert > 0)
            {
                MessageBox.Show("Data Berhasi Di Input!");
                ngeload();
            }
        }

        public void UpdateData(int id, string nama, int harga, int stok)
        {
            string sql = @"UPDATE bahan SET Nama_Bahan=@nama, Harga=@harga, Stok=@stok WHERE ID_Bahan=@id";
            var update = db.InsertUpdateDelete(sql, new { id = id, nama = nama, harga = harga, stok = stok });

            if (update > 0)
            {
                MessageBox.Show("Data Berhasil Di Update!");
                ngeload();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells["ID_Bahan"].Value.ToString();
            var isi = db.ListBahan(int.Parse(id));
            if (isi == null) return;
            var isi2 = isi.FirstOrDefault();
            if (isi2 == null) return;
            txtIDBahan.Text = isi2.ID_Bahan.ToString();
            txtNamaBahan.Text = isi2.Nama_Bahan;
            txtHarga.Text = isi2.Harga.ToString();
            txtStok.Text = isi2.Stok.ToString();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TabelBahan_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtIDBahan.Text;
            if (id == "")
            {
                MessageBox.Show("Pilih Terlebih Dahulu Data Yang Ingin Di Hapus!");
            }
            else
            {
                if (MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                string sql = @"DELETE FROM bahan WHERE ID_Bahan=@id";
                var delete = db.InsertUpdateDelete(sql, new { id = id });
                if (delete > 0)
                {
                    MessageBox.Show("Data Berhasil Dihapus!");
                    ngeload();
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtIDBahan.Clear(); 
            txtNamaBahan.Clear();
            txtHarga.Clear();
            txtStok.Clear();
        }
    }
}