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
                            t.id_transaksi, td.nama_transaksi, td.harga, td.jumlah, td.modal, td.pendapatan_bersih
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi  
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
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
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

        public int InsertData(TransaksiModel pendapatan)
        {
            const string sql = @"
                INSERT INTO transaksi 
                    (tanggal, tipe, admin, nominal_diskon) 
                OUTPUT INSERTED.id_transaksi
                VALUES 
                    (@tanggal, @tipe, @admin, @nominal_diskon)";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingle<int>(sql, pendapatan);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM transaksi WHERE id_transaksi = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id = id });
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM transaksi t
                            INNER JOIN transaksi_detail td 
                                ON t.id_transaksi = td.id_transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}
