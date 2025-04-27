using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class DbDapper
    {
        public string connstring()
        {
            return "Server=(local);Database=shopee;Trusted_Connection=True;TrustServerCertificate=True";
        }

        public IEnumerable<produkModel> ListProduk(int id_produk)
        {

            string sql = @"SELECT * FROM produk";


            using var koneksi = new SqlConnection(connstring());
            var ListProduk = koneksi.Query<produkModel>(sql, new { ip = id_produk });
            return ListProduk;
        }

        public IEnumerable<ProdukModel2> ListProduk2(int id)
        {
            string sql;
            if (id == 0)
            {
                sql = @"SELECT * FROM produk";
            }
            else
            {
                sql = @"SELECT * FROM produk WHERE ID_Produk=@id";
            }
            using var koneksi = new SqlConnection(connstring());
            var data = koneksi.Query<ProdukModel2>(sql, new { id = id });
            return data;
        }
        public IEnumerable<BahanModel> ListBahan(int id)
        {
            string sql;
            if (id == 0)
            {
                sql = @"SELECT * FROM bahan";
            }
            else
            {
                sql = @"SELECT * FROM bahan WHERE ID_Bahan=@id";
            }
            using var koneksi = new SqlConnection(connstring());
            var update = koneksi.Query<BahanModel>(sql, new { id = id });
            return update;
        }

        public int InsertBahan(string NamaBahan, int Harga, int Stok)
        {
            string sql = @"INSERT INTO bahan(Nama_Bahan,Kebutuhan,Stok) 
                     VALUES(@nb,@h,@s)";
            using var koneksi = new SqlConnection(connstring());
            var insert = koneksi.Execute(sql, new { nb = NamaBahan, h = Harga, s = Stok });
            return insert;
        }

        public int InsertUpdateDelete(string sql, object areng)
        {
            using var koneksi = new SqlConnection(connstring());
            var insertt = koneksi.Execute(sql, areng);
            return insertt;
        }

        public IEnumerable<KebutuhanModel2> Kebutuhan(int ID)
        {
            string sql;
            if (ID == 0)
            {
                sql = @"SELECT * FROM kebutuhan";
            }
            else
            {
                sql = @"SELECT * FROM kebutuhan WHERE ID_Kebutuhan=@ik";
            }
            using var koneksi = new SqlConnection(connstring());
            var hsl = koneksi.Query<KebutuhanModel2>(sql, new { ik = ID });
            return hsl;
        }

        public IEnumerable<KebutuhanModel> ListKebutuhan(int ID)
        {

            string sql = @"SELECT k.ID_Bahan,k.Jumlah,p.Nama_Produk,b.Nama_Bahan FROM kebutuhan k
                     INNER JOIN produk p ON k.ID_Produk = p.ID_Produk
                     INNER JOIN Bahan b ON k.ID_Bahan = b.ID_Bahan
                      WHERE k.ID_Produk=@id";

            using var koneksi = new SqlConnection(connstring());
            var ListKebutuhan = koneksi.Query<KebutuhanModel>(sql, new { id = ID });
            return ListKebutuhan;
        }


        public int UpdateStokBahan(int ID_Bahan, int Jumlah)
        {
            string sql = @"UPDATE bahan SET Stok = Stok - @jmlh WHERE ID_Bahan = @id_bahan";
            using var koneksi = new SqlConnection(connstring());
            var update = koneksi.Execute(sql, new { jmlh = Jumlah, id_bahan = ID_Bahan });
            return update;
        }

        public IEnumerable<BahanModel> CekStokBahan(int ID_Bahan, int Jumlah)
        {
            string sql = @"SELECT Nama_Bahan,Harga,Stok FROM bahan WHERE ID_Bahan = @id_bahan AND Stok >= @jmlh";
            using var koneksi = new SqlConnection(connstring());
            var update = koneksi.Query<BahanModel>(sql, new { jmlh = Jumlah, id_bahan = ID_Bahan });
            return update;
        }



        public int InsertPendapatan(int ID_Produk, double Pendapatan_Kotor, int Modal, double Pendapatan_Bersih, DateTime Tanggal_Input, int Jumlah_Produk)
        {
            string sql = @"INSERT INTO Pendapatan(ID_Produk,Pendapatan_Kotor,Modal,Pendapatan_Bersih,Tanggal_Input,Jumlah_Produk)
                     VALUES(@id_produk,@pk,@m,@pb,@ti,@jp)";

            using var koneksi = new SqlConnection(connstring());
            var insert = koneksi.Execute(sql, new { id_produk = ID_Produk, pk = Pendapatan_Kotor, m = Modal, pb = Pendapatan_Bersih, ti = Tanggal_Input, jp = Jumlah_Produk });
            return insert;
        }

        //Pendapatan Table Query
        public IEnumerable<PendapatanModel> ListPendapatan(int ID)
        {
            string sql;
            if (ID == 0)
            {
                sql = @"SELECT p.ID_Pendapatan,p.ID_Produk,pr.Nama_Produk,p.Pendapatan_Kotor,p.Modal,p.Pendapatan_Bersih,p.Tanggal_Input,p.Jumlah_Produk FROM pendapatan p INNER JOIN produk pr ON p.ID_Produk = pr.ID_Produk";
            }
            else
            {
                sql = @"SELECT ID_Pendapatan,ID_Produk,Pendapatan_Kotor,Modal,Pendapatan_Bersih,Tanggal_Input,Jumlah_Produk FROM pendapatan WHERE ID_Pendapatan=@id";
            }

            using var koneksi = new SqlConnection(connstring());
            var data = koneksi.Query<PendapatanModel>(sql, new { id = ID });
            return data;
        }

        public IEnumerable<defaultdata> ListDefault()
        {
            string sql = @"SELECT ID_Bahan,Nama_Bahan FROM bahan";
            using var koneksi = new SqlConnection(connstring());
            var listdefault = koneksi.Query<defaultdata>(sql);
            return listdefault;
        }

        public IEnumerable<KebutuhanJelasModel> jelas()
        {
            string sql = @"SELECT k.ID_Kebutuhan,p.Nama_Produk,b.Nama_Bahan,k.Jumlah FROM kebutuhan k
                     INNER JOIN produk p ON k.ID_Produk = p.ID_Produk
                     INNER JOIN bahan b ON k.ID_Bahan = b.ID_Bahan";
            using var koneksi = new SqlConnection(connstring());
            var data = koneksi.Query<KebutuhanJelasModel>(sql);
            return data;
        }
        public IEnumerable<KebutuhanJelasModel> filterjelas(string filter)
        {
            string sql = @"SELECT k.ID_Kebutuhan,p.Nama_Produk,b.Nama_Bahan,k.Jumlah FROM kebutuhan k
                     INNER JOIN produk p ON k.ID_Produk = p.ID_Produk
                     INNER JOIN bahan b ON k.ID_Bahan = b.ID_Bahan
                     WHERE Nama_Produk LIKE @np+'%' OR Nama_Bahan LIKE @np+'%'";
            using var koneksi = new SqlConnection(connstring());
            var data = koneksi.Query<KebutuhanJelasModel>(sql, new { np = filter });
            return data;
        }

        public IEnumerable<PendapatanModel> FilterPendapatan(DateTime tglawal, DateTime tglakhir)
        {
            string sql = @"SELECT p.ID_Pendapatan,p.ID_Produk,pr.Nama_Produk,p.Pendapatan_Kotor,p.Modal,p.Pendapatan_Bersih,p.Tanggal_Input,p.Jumlah_Produk 
                     FROM pendapatan p INNER JOIN produk pr ON p.ID_Produk = pr.ID_Produk
                     WHERE Tanggal_Input BETWEEN @tglawal AND @tglakhir";

            using var koneksi = new SqlConnection(connstring());
            var data = koneksi.Query<PendapatanModel>(sql, new { tglawal = tglawal, tglakhir = tglakhir });
            return data;
        }

        public IEnumerable<PendapatanModel> FilterPendapatan2(DateTime awal, DateTime akhir)
        {
            string sql = @"SELECT p.ID_Pendapatan,p.ID_Produk,pr.Nama_Produk,p.Pendapatan_Kotor,p.Modal,p.Pendapatan_Bersih,p.Tanggal_Input,p.Jumlah_Produk 
                     FROM pendapatan p INNER JOIN produk pr ON p.ID_Produk = pr.ID_Produk
                     WHERE Tanggal_Input BETWEEN @awal AND @akhir";

            using var koneksi = new SqlConnection(connstring());
            return koneksi.Query<PendapatanModel>(sql, new { awal = awal, akhir = akhir });
        }
    }
}
