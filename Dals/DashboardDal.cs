using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Shopee
{
    public class DashboardDal
    {
        public int GetProdukTerjual(FilterModel filter)
        {
            string sql = $@"SELECT COALESCE(SUM(jumlah), 0) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanKotor(FilterModel filter)
        {
            string sql = $@"SELECT COALESCE(SUM(pendapatan_kotor), 0) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanBersih(FilterModel filter)
        {
            string sql = $@"SELECT COALESCE(SUM(pendapatan_bersih), 0) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public decimal GetAdminFee()
        {
            string sql = $@"SELECT jumlah_pengeluaran FROM operasional WHERE nama_pengeluaran = 'Biaya Admin'";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<decimal>(sql);
        }

        public void UpdateAdminFee(decimal adminFee)
        {
            string sql = $@"UPDATE operasional SET jumlah_pengeluaran = @adminFee WHERE nama_pengeluaran = 'Biaya Admin'";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { adminFee });
        }

        public IEnumerable<TransaksiModel> TopProdukTerjual(FilterModel filter)
        {
            string sql = $@"SELECT TOP 5 nama_transaksi, COALESCE(SUM(jumlah), 0) AS jumlah
                            FROM transaksi
                            {filter.sql}
                            GROUP BY nama_transaksi
                            ORDER BY jumlah DESC";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public IEnumerable<TransaksiModel> TopProdukProfit(FilterModel filter)
        {
            string sql = $@"SELECT TOP 5 nama_transaksi, COALESCE(SUM(pendapatan_bersih), 0) AS pendapatan_bersih
                            FROM transaksi
                            {filter.sql}
                            GROUP BY nama_transaksi
                            ORDER BY pendapatan_bersih DESC";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }
    }
}