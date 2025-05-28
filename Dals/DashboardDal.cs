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
            string sql = $@"SELECT COALESCE(SUM(td.jumlah), 0) FROM transaksi t
                            INNER JOIN transaksi_detail td 
                                ON t.id_transaksi = td.id_transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanKotor(FilterModel filter)
        {
            string sql = $@"SELECT COALESCE(SUM(td.harga), 0) FROM transaksi t
                            INNER JOIN transaksi_detail td 
                                ON t.id_transaksi = td.id_transaksi {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanBersih(FilterModel filter)
        {
            string sql = $@"
                    WITH PerTransaksi AS (
                    SELECT
                        t.id_transaksi,
                        (
                            (ISNULL(SUM(CASE WHEN t.tipe = 1 THEN td.harga ELSE 0 END), 0) * ISNULL(SUM(td.jumlah), 0))
                            - ISNULL(t.nominal_diskon, 0)
                        ) * ISNULL(t.admin, 0)
                        - ISNULL(SUM(td.modal), 0) AS pendapatan_bersih
                    FROM transaksi t
                    INNER JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                    {filter.sql}
                    GROUP BY t.id_transaksi, t.nominal_diskon, t.admin
                )
                SELECT ISNULL(SUM(pendapatan_bersih), 0) FROM PerTransaksi;
                ";
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
            string sql = $@"SELECT TOP 5 td.nama_transaksi, COALESCE(SUM(td.jumlah), 0) AS jumlah
                            FROM transaksi t
                            INNER JOIN transaksi_detail td 
                                ON t.id_transaksi = td.id_transaksi 
                            {filter.sql}
                            GROUP BY td.nama_transaksi
                            ORDER BY jumlah DESC";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public IEnumerable<TransaksiModel> TopProdukProfit(FilterModel filter)
        {
            string sql = $@"SELECT TOP 5 td.nama_transaksi,
                                (
                                    (ISNULL(SUM(CASE WHEN t.tipe = 1 THEN td.harga ELSE 0 END), 0) * ISNULL(SUM(td.jumlah), 0))
                                    - ISNULL(t.nominal_diskon, 0)
                                ) * ISNULL(t.admin, 0)
                                - ISNULL(SUM(td.modal), 0) AS pendapatan_bersih
                            FROM transaksi t
                            INNER JOIN transaksi_detail td 
                                ON t.id_transaksi = td.id_transaksi
                            {filter.sql}
                            GROUP BY td.nama_transaksi, t.nominal_diskon, t.admin
                            ORDER BY pendapatan_bersih DESC";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }
    }
}