using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shopee
{
    public class PendapatanDal
    {
        public IEnumerable<PendapatanModel> ListData(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            t.ID_Pendapatan, pr.Nama_Produk, t.Pendapatan_Kotor, t.Modal,
                            t.Pendapatan_Bersih, t.Tanggal_Input, t.Jumlah_Produk, pr.Tipe
                        FROM transaksi t
                        INNER JOIN produk pr ON t.ID_Produk = pr.ID_Produk
                        {filter.sql}
                        OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<PendapatanModel>(sql, filter.param);
        }

        public int TotalPendapatan(FilterModel filter, string field_name)
        {
            string sql = $@"
                        SELECT 
                            ISNULL(SUM(t.{field_name}), 0)
                        FROM transaksi t
                        INNER JOIN produk pr ON t.ID_Produk = pr.ID_Produk
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public PendapatanModel? GetData(int id)
        {
            const string sql = @"SELECT * FROM transaksi WHERE ID_Pendapatan = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<PendapatanModel>(sql, new { id = id });
        }

        public void InsertData(PendapatanModel pendapatan)
        {
            const string sql =
                @"INSERT INTO transaksi                      
                        (ID_Produk, Pendapatan_Kotor, Modal, Pendapatan_Bersih, Tanggal_Input, Jumlah_Produk, Tipe)
                  VALUES (@ID_Produk, @Pendapatan_Kotor, @Modal, @Pendapatan_Bersih, @Tanggal_Input, @Jumlah_Produk, @Tipe)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, pendapatan);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM transaksi WHERE ID_Pendapatan = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id = id });
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM transaksi t INNER JOIN produk pr ON t.ID_Produk = pr.ID_Produk {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}
