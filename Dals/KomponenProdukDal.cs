using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Shopee
{
    public class KomponenProdukDal
    {
        public IEnumerable<KomponenProdukModel> ListData(int ID)
        {
            string sql = @"SELECT kp.id_komponen, k.nama_komponen, kp.jumlah, k.harga 
                     FROM komponen_produk kp
                     INNER JOIN komponen k ON k.id_komponen = kp.id_komponen
                     WHERE kp.id_produk = @id";

            using var koneksi = new SqlConnection(conn.connStr);
            var ListKebutuhan = koneksi.Query<KomponenProdukModel>(sql, new { id = ID });
            return ListKebutuhan;
        }

        public void InsertData(KomponenProdukModel kp)
        {
            const string sql = @"INSERT INTO komponen_produk(id_produk, id_komponen, jumlah)
                    VALUES (@id_produk, @id_komponen, @jumlah)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new
            {
                id_produk = kp.id_produk,
                id_komponen = kp.id_komponen,
                jumlah = kp.jumlah
            });
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM komponen_produk WHERE id_produk = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id });
        }
    }
}
