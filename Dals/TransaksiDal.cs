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
                            t.id_transaksi,
                            t.tanggal,
                            (1 - t.admin) * 100 AS admin,
                            t.tipe,
                            STRING_AGG(td.nama_transaksi, ', ') AS nama_transaksi,
                            SUM(td.harga * td.jumlah) AS harga,
                            SUM(td.jumlah) AS jumlah,
                            SUM(td.modal * td.jumlah) AS modal,
                            -- Perhitungan pendapatan bersih
                            (
                                SUM(td.harga * td.jumlah)           -- total penjualan
                                - t.nominal_diskon                  -- dikurangi diskon
                            ) * t.admin                             -- dikali admin
                            - SUM(td.modal * td.jumlah)             -- dikurangi modal
                            AS pendapatan_bersih
                        FROM transaksi t
                        INNER JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                        {filter.sql} 
                        GROUP BY 
                            t.id_transaksi,
                            t.tanggal,
                            t.admin,
                            t.tipe,
                            t.nominal_diskon
                        {filter.sql2}
                        OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiModel>(sql, filter.param);
        }

        public int TotalPendapatanSubBersih(FilterModel filter)
        {
            string sql = $@"
                    WITH PerTransaksi AS (
                    SELECT
                        t.id_transaksi,
                        (
                          SUM(CASE WHEN t.tipe = 1 THEN td.harga * td.jumlah ELSE 0 END)                                      
                        ) * t.admin                                            
                            - SUM(td.modal * td.jumlah)                      
                            AS pendapatan_bersih
                    FROM transaksi t
                    INNER JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                    {filter.sql}
                    GROUP BY t.id_transaksi, t.nominal_diskon, t.admin
                )
                SELECT SUM(pendapatan_bersih) FROM PerTransaksi;
                ";


            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int TotalPendapatanKotor(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            SUM(CASE WHEN t.tipe = 1 THEN td.harga * td.jumlah ELSE 0 END)
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int TotalModal(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            ISNULL(SUM(td.modal * td.jumlah), 0)
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int TotalPengeluaran(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            SUM(CASE WHEN t.tipe = 0 THEN td.harga * td.jumlah ELSE 0 END)
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
