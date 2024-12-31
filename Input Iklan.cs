using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class Input_Iklan : Form
    {
        private DbDapper db;
        private int ID_Produk;
        public Input_Iklan()
        {
            InitializeComponent();
            db = new DbDapper();
            GetBiayaIklan();
        }

        private void Insert()
        {
            DateTime tgl1, tgl2;
            tgl1 = tanggal1.Value.Date;
            tgl2 = tanggal2.Value.Date;
            string biaya = biayaiklantxt.Text;
            if (biaya == "")
            {
                MessageBox.Show("Biaya Iklan Wajib Diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conn = new SqlConnection(db.connstring());

            for (DateTime tanggal = tgl1; tanggal <= tgl2; tanggal = tanggal.AddDays(1))
            {
                string sql = @"INSERT INTO Pendapatan(ID_Produk,Pendapatan_Kotor,Modal,
                                        Pendapatan_Bersih,Tanggal_Input,Jumlah_Produk)
                                VALUES(@ID_Produk,@Pendapatan_Kotor,@Modal,@Pendapatan_Bersih,
                                        @Tanggal_Input,@Jumlah_Produk)";
                var dp = new DynamicParameters();
                dp.Add("@ID_Produk",ID_Produk, DbType.Int16);
                dp.Add("@Pendapatan_Kotor",0, DbType.Int16);
                dp.Add("@Modal",Convert.ToInt32(biaya), DbType.Int32);
                dp.Add("@Pendapatan_Bersih",Convert.ToInt32("-"+biaya), DbType.Int16);
                dp.Add("@Tanggal_Input",tanggal, DbType.DateTime);
                dp.Add("@Jumlah_Produk",0, DbType.Int16);
                var a = conn.Execute(sql,dp);
                if(a > 0) MessageBox.Show("Biaya Iklan Berhasil Di Input!");
            }

        }

        private void GetBiayaIklan()
        {
            string sql = @"SELECT ID_Produk,Nama_Produk,Harga FROM Produk WHERE Nama_Produk = 'Biaya Iklan'";
            using var conn = new SqlConnection(db.connstring());
            var getHarga = conn.QueryFirstOrDefault<Produk>(sql);
            if (getHarga is null) return;

            int biayaIklan = getHarga.Harga;
            ID_Produk = getHarga.ID_Produk;
            biayaiklantxt.Text = biayaIklan.ToString();
            
        }

        private void biayaiklantxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Insert();
        }

        public class Produk
        {
            public int Harga { get; set; }
            public int ID_Produk {  get; set; }
        }
    }
}
