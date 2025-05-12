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
        public IEnumerable<ProdukModel> ListData(FilterModel filter)
        {
            string sql = $@"SELECT * FROM produk {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);  
            return koneksi.Query<ProdukModel>(sql, filter.param);
        }

        public IEnumerable<ProdukModel> ListProdukCombo()
        {
            const string sql = $@"SELECT id_produk, nama_produk, harga FROM produk";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<ProdukModel>(sql);
        }

        public int GetModal(int idProduk)
        {
            const string sql = @"SELECT ISNULL (SUM(k.harga * kp.jumlah),0) 
                    FROM komponen k
                    INNER JOIN komponen_produk kp
                        ON k.id_komponen = kp.id_komponen
                    WHERE id_produk = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, new { id = idProduk });
        }

        public ProdukModel? GetData(int id)
        {
            const string sql = @"SELECT * FROM produk WHERE id_produk=@id";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<ProdukModel>(sql, new { id = id });
        }

        public void InsertData(ProdukModel produk)
        {
            const string sql =
                @"INSERT INTO produk                      
                        (nama_produk,harga)
                   VALUES (@nama_produk,@harga)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, produk);
        }

        public void UpdateData(ProdukModel produk)
        {
            const string sql =
                @"UPDATE produk SET 
                        nama_produk=@nama_produk,
                        harga=@harga
                   WHERE id_produk=@id_produk";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, produk);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM produk WHERE id_produk=@id";
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
