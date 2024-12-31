using Dapper;
using System.DirectoryServices;

namespace Shopee
{
    public partial class TabelKebutuhan : Form
    {
        private DbDapper db;
        List<string> filter = new List<string>();
        public bool centang;
        public TabelKebutuhan()
        {
            InitializeComponent();
            db = new DbDapper();
            ngeload();

            txtIDKebutuhan.ReadOnly = true;

            filter.Add("Tampilkan Data Asli");
            filter.Add("Tampilkan Data Jelas");
            combofilter();
        }

        public void ngeload()
        {
            dataGridView1.DataSource = db.jelas();

        }
        public void combofilter()
        {
            comboBox1.DataSource = filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (centang == true)
            {
                if (DataDefault.listcentang.Count == 0)
                {
                    MessageBox.Show("Mohon Pilih Bahan Terlebih Dahulu!");
                    return;
                }
            }

            string idKebutuhan = txtIDKebutuhan.Text;
            string idProduk = txtIDProduk.Text;
            string idBahan = txtIDBahan.Text;
            int jumlah = (int)numericJumlah.Value;

            if (inputSemua.Checked)
            {
                if (idProduk != "")
                {
                    var listcentang = DataDefault.listcentang;
                    
                    foreach (var item in listcentang)
                    {
                        string sql = @"INSERT INTO kebutuhan(ID_Produk,ID_Bahan,Jumlah)
                        VALUES(@ip,@ib,@j)";
                        var dp = new DynamicParameters();
                        dp.Add("@ip",Convert.ToInt16(idProduk),System.Data.DbType.Int16);
                        dp.Add("@ib",item.ID_Bahan,System.Data.DbType.String);
                        dp.Add("@j",item.Jumlah,System.Data.DbType.Int32);
                        var insert = db.InsertUpdateDelete(sql, dp);
                        if(insert > 0) MessageBox.Show("Data Berhasil Ditambahkan!!!!");
                    }
                    //MessageBox.Show("Data Berhasil Ditambahkan!!!!");
                    ngeload();
                }
                else
                {
                    MessageBox.Show("ID Produk wajib Diisi");
                }

            }
            else
            {
                string msb;
                if (idKebutuhan == "")
                {
                    InsertData(int.Parse(idProduk), int.Parse(idBahan), jumlah);
                }
                else if (idKebutuhan != "")
                {
                    UpdateData(int.Parse(idKebutuhan), int.Parse(idProduk), int.Parse(idBahan), jumlah);
                }
                else
                {
                    MessageBox.Show("Seluruh Data Wajib Diisi Kecuali ID_Kebutuhan!");
                }
            }
        }

        public void InsertData(int idProduk, int idBahan, int Jumlah)
        {
            string sql = @"INSERT INTO kebutuhan(ID_Produk,ID_Bahan,Jumlah)
                        VALUES(@ip,@ib,@j)";
            var insert = db.InsertUpdateDelete(sql, new { ip = idProduk, ib = idBahan, j = Jumlah });
            if (insert > 0)
            {
                MessageBox.Show("Data Berhasil Ditambahkan!");
                ngeload();
            }
        }

        public void UpdateData(int idKebutuhan, int idProduk, int idBahan, int Jumlah)
        {
            string sql = @"UPDATE kebutuhan SET ID_Produk=@ip,ID_Bahan=@ib,Jumlah=@j WHERE ID_Kebutuhan=@ik";
            var update = db.InsertUpdateDelete(sql, new { ik = idKebutuhan, ip = idProduk, ib = idBahan, j = Jumlah });
            if (update > 0)
            {
                MessageBox.Show("Data Berhasil Di Ubah!");
                Filter();
            }
        }

        public void HapusData()
        {
            string idkebutuhan = txtIDKebutuhan.Text;
            string sql = @"DELETE FROM kebutuhan WHERE ID_Kebutuhan = @ik";
            if (MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var delete = db.InsertUpdateDelete(sql, new { ik = idkebutuhan });
            if (delete > 0)
            {
                Filter();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var idKebutuhan = dataGridView1.CurrentRow.Cells["ID_Kebutuhan"].Value.ToString();
            var hasil = db.Kebutuhan(int.Parse(idKebutuhan));
            if (hasil != null)
            {
                var hsl = hasil.FirstOrDefault();
                txtIDKebutuhan.Text = hsl.ID_Kebutuhan.ToString();
                txtIDProduk.Text = hsl.ID_Produk.ToString();
                txtIDBahan.Text = hsl.ID_Bahan.ToString();
                numericJumlah.Value = hsl.Jumlah;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HapusData();
        }

        private void inputSemua_CheckedChanged(object sender, EventArgs e)
        {
            if (inputSemua.Checked)
            {
                centang = true;
                txtIDBahan.ReadOnly = true;
                numericJumlah.ReadOnly = true;
            }
            else
            {
                centang = false;
                txtIDBahan.ReadOnly = false;
                numericJumlah.ReadOnly = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataDefault df = new DataDefault();
            df.StartPosition = FormStartPosition.CenterParent;
            df.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            string filterTambahan = txtfilter.Text;
            if (comboBox1.SelectedIndex == 1 && filterTambahan == "")
            {
                dataGridView1.DataSource = db.jelas();
            }
            else if (filterTambahan != "")
            {
                dataGridView1.DataSource = db.filterjelas(filterTambahan);
            }
            else
            {
                dataGridView1.DataSource = db.Kebutuhan(0);
            }
        }

        private void TabelKebutuhan_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtIDKebutuhan.Clear();
            txtIDProduk.Clear();
            txtIDBahan.Clear();
            numericJumlah.Value = 0;
        }
    }
}
