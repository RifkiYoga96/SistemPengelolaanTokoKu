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
                        SELECT * FROM transaksi
                        {filter.sql}
                        OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public int TotalPendapatan(FilterModel filter, string field_name)
        {
            string sql = $@"
                        SELECT 
                            ISNULL(SUM({field_name}), 0)
                        FROM transaksi
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public TransaksiModel? GetData(int id)
        {
            const string sql = @"SELECT * FROM transaksi WHERE id_transaksi = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<TransaksiModel>(sql, new { id = id });
        }

        public void InsertData(TransaksiModel pendapatan)
        {
            const string sql = @"
                INSERT INTO transaksi 
                    (nama_transaksi, tanggal_input, pendapatan_kotor, modal, pendapatan_bersih, pengeluaran, jumlah, tipe) 
                VALUES 
                    (@nama_transaksi, @tanggal_input, @pendapatan_kotor, @modal, @pendapatan_bersih, @pengeluaran, @jumlah, @tipe)";


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
    }
}
