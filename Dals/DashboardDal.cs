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
                                ON t.id_transaksi = td.id_transaksi
                            WHERE (t.tanggal BETWEEN @tanggal1 AND @tanggal2) AND (t.tipe = 1)";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPendapatanKotor(FilterModel filter)
        {
            string sql = $@"SELECT COALESCE(SUM(td.harga * td.jumlah), 0) FROM transaksi t
                            INNER JOIN transaksi_detail td 
                                ON t.id_transaksi = td.id_transaksi
                            WHERE (t.tanggal BETWEEN @tanggal1 AND @tanggal2) AND (t.tipe = 1)";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPemasukanBersih(FilterModel filter)
        {
            string sql = $@"
                    WITH Pemasukan AS (
                    SELECT
                        t.id_transaksi,
                        (
                            ISNULL(SUM(td.harga * td.jumlah),0)
                            - ISNULL(t.nominal_diskon, 0)
                        ) * ISNULL(t.admin, 0)
                        - ISNULL(t.biaya_proses_pesanan, 0)
                        - ISNULL(SUM(dbo.HitungModalTransaksi(td.id_transaksi_detail) * td.jumlah), 0) 
                        AS pendapatan_bersih
                    FROM transaksi t
                    INNER JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                    WHERE (t.tanggal BETWEEN @tanggal1 AND @tanggal2) AND (t.tipe = 1)
                    GROUP BY t.id_transaksi, t.nominal_diskon, t.admin, t.biaya_proses_pesanan
                )
                SELECT ISNULL(SUM(pendapatan_bersih), 0) FROM Pemasukan;
                ";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int GetPengeluaran(FilterModel filter)
        {
            const string sql = @"
                        SELECT 
                            ISNULL(SUM(td.harga * td.jumlah),0)
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
                        WHERE (t.tanggal BETWEEN @tanggal1 AND @tanggal2) AND t.tipe = 0";
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
                            WHERE (t.tanggal BETWEEN @tanggal1 AND @tanggal2) AND (t.tipe = 1)
                            GROUP BY td.nama_transaksi
                            ORDER BY jumlah DESC";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public IEnumerable<TransaksiModel> TopProdukProfit(FilterModel filter)
        {
            string sql = $@"WITH PendapatanPerDetail AS (
                    SELECT 
                        td.nama_transaksi,
                        (
                            ISNULL(td.harga * td.jumlah, 0)
                        ) * ISNULL(t.admin, 0)
                        - ISNULL(dbo.HitungModalTransaksi(td.id_transaksi_detail) * td.jumlah, 0) AS pendapatan_bersih
                    FROM transaksi t
                    INNER JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                    WHERE t.tanggal BETWEEN @tanggal1 AND @tanggal2
                      AND t.tipe = 1
                )
                SELECT TOP 5 
                    nama_transaksi,
                    SUM(pendapatan_bersih) AS pendapatan_bersih
                FROM PendapatanPerDetail
                GROUP BY nama_transaksi
                ORDER BY pendapatan_bersih DESC;";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public int GetBiayaIklan(FilterModel filter)
        {
            const string sql = @"
                SELECT ISNULL(SUM(td.harga * td.jumlah), 0)
                FROM transaksi t
                INNER JOIN transaksi_detail td 
                    ON t.id_transaksi = td.id_transaksi
                WHERE t.tipe = 0 AND (td.nama_transaksi = 'Biaya Iklan' OR td.nama_transaksi = 'Admin Biaya Iklan') AND (t.tanggal BETWEEN @tanggal1 AND @tanggal2)";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}