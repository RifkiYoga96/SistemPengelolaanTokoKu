using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Shopee
{
    public class TransaksiDal
    {
        public IEnumerable<TransaksiModel> ListData(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            t.id_transaksi, t.nama_transaksi, t.tanggal, t.tipe, t.pengeluaran,
                            td.nama_produk, td.harga, td.jumlah, td.modal, td.pendapatan_bersih
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi  
                        {filter.sql}
                        OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public int TotalPendapatan(FilterModel filter, string field_name, bool isFilter)
        {
            string sql = $@"
                        SELECT 
                            ISNULL(SUM({field_name}), 0)
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
                        {filter.sql}";

            if (isFilter)
                sql = $@"
                        SELECT 
                            ISNULL(SUM({field_name}), 0) -
                            ISNULL(SUM(pengeluaran), 0)     
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public TransaksiModel? GetData(int id)
        {
            const string sql = @" SELECT 
                            t.id_transaksi, t.nama_transaksi, t.tanggal, t.tipe, t.admin
                            td.nama_produk, td.harga, td.jumlah, td.modal, td.pendapatan_bersih
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
                        WHERE t.id_transaksi = @id";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<TransaksiModel>(sql, new { id = id });
        }

        public void InsertData(TransaksiModel pendapatan)
        {
            const string sql = @"
                INSERT INTO transaksi 
                    (nama_transaksi, tanggal, pengeluaran, tipe, admin) 
                VALUES 
                    (@nama_transaksi, @tanggal, @pengeluaran, @tipe, @admin)";


            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, pendapatan);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM transaksi WHERE id_transaksi = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id = id });
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GenerateCheckoutId()
        {
            const string sql = @"SELECT ISNULL(MAX(id_checkout), 0) + 1 FROM transaksi";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql);
        }
    }
}
