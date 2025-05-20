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
            string sql = $@"SELECT SUM(jumlah) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanKotor(FilterModel filter)
        {
            string sql = $@"SELECT SUM(pendapatan_kotor) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanBersih(FilterModel filter)
        {
            string sql = $@"SELECT SUM(pendapatan_bersih) FROM transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}
