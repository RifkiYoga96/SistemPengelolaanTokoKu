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
                            SUM(dbo.HitungModalTransaksi(td.id_transaksi_detail) * td.jumlah) AS modal,
                            -- Perhitungan pendapatan bersih
                            (
                                SUM(td.harga * td.jumlah)           -- total penjualan
                                - t.nominal_diskon                  -- dikurangi diskon
                            ) * t.admin                             -- dikali admin
                            - SUM(dbo.HitungModalTransaksi(td.id_transaksi_detail) * td.jumlah)   -- dikurangi modal
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
        public TransaksiModel? GetData(int id)
        {
            const string sql = @" SELECT 
                            id_transaksi, tanggal, tipe, admin, nominal_diskon
                        FROM transaksi
                        WHERE id_transaksi = @id";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QueryFirstOrDefault<TransaksiModel>(sql, new { id = id });
        }

        public int TotalPemasukanBersih(FilterModel filter)
        {
            string sql = $@"
                    WITH Pemasukan AS (
                    SELECT
                        t.id_transaksi,
                        (
                          SUM(CASE WHEN t.tipe = 1 THEN td.harga * td.jumlah ELSE 0 END)
                          - ISNULL(t.nominal_diskon, 0)                          
                        ) * t.admin                                            
                            - SUM(dbo.HitungModalTransaksi(td.id_transaksi_detail) * td.jumlah)                      
                            AS pendapatan_bersih
                    FROM transaksi t
                    INNER JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                    {filter.sql}
                    GROUP BY t.id_transaksi, t.nominal_diskon, t.admin
                )
                SELECT ISNULL(SUM(pendapatan_bersih), 0) FROM Pemasukan;
                ";


            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int TotalPendapatanKotor(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            ISNULL(SUM(CASE WHEN t.tipe = 1 THEN td.harga * td.jumlah ELSE 0 END), 0)
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
                            ISNULL(SUM(dbo.HitungModalTransaksi(td.id_transaksi_detail) * td.jumlah), 0)
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
                            ISNULL(SUM(CASE WHEN t.tipe = 0 THEN td.harga * td.jumlah ELSE 0 END), 0)
                        FROM transaksi t
                        INNER JOIN transaksi_detail td
                            ON t.id_transaksi = td.id_transaksi
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public int InsertData(TransaksiModel pendapatan)
        {
            const string sql = @"
                INSERT INTO transaksi 
                    (tanggal, tipe, admin, nominal_diskon, status) 
                OUTPUT INSERTED.id_transaksi
                VALUES 
                    (@tanggal, @tipe, @admin, @nominal_diskon, @status)";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingle<int>(sql, pendapatan);
        }

        public void DeleteData(int id)
        {
            const string sql = @"
                        -- Hapus transaksi_komponen_detail (anak-anak level 2)
                        DELETE tkd
                        FROM transaksi_komponen_detail tkd
                        INNER JOIN transaksi_detail td ON td.id_transaksi_detail = tkd.id_transaksi_detail
                        WHERE td.id_transaksi = @id;

                        -- Hapus transaksi_detail (anak level 1)
                        DELETE FROM transaksi_detail
                        WHERE id_transaksi = @id;

                        -- Hapus transaksi (induk)
                        DELETE FROM transaksi
                        WHERE id_transaksi = @id;
                        ";
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
