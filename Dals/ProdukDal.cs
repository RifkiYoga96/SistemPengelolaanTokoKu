using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class ProdukDal
    {
        public IEnumerable<produkModel> ListData(FilterModel filter)
        {
            string sql = $@"SELECT * FROM produk {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);  
            return koneksi.Query<produkModel>(sql, filter.param);
        }

        public IEnumerable<produkModel> ListProdukCombo()
        {
            const string sql = $@"SELECT ID_Produk, Nama_Produk FROM produk
                                ";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<produkModel>(sql);
        }

        public produkModel? GetData(int id)
        {
            const string sql = @"SELECT * FROM produk WHERE ID_Produk=@id";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<produkModel>(sql, new { id = id });
        }

        public void InsertData(produkModel produk)
        {
            const string sql =
                @"INSERT INTO produk                      
                        (ID_Bahan,Nama_Produk,Harga)
                   VALUES (@ID_Bahan,@Nama_Produk,@Harga)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, produk);
        }

        public void UpdateData(produkModel produk)
        {
            const string sql =
                @"UPDATE produk SET 
                        ID_Bahan=@ID_Bahan,
                        Nama_Produk=@Nama_Produk,
                        Harga=@Harga
                   WHERE ID_Produk=@ID_Produk";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, produk);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM produk WHERE ID_Produk=@id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id = id });
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM produk {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}
