using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Shopee
{
    public class OperasionalDal
    {
        public IEnumerable<OperasionalModel> ListData(FilterModel filter)
        {
            string sql = $@"SELECT * FROM operasional {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<OperasionalModel>(sql, filter.param);
        }

        public IEnumerable<OperasionalModel> ListPengeluaranCombo()
        {
            const string sql = $@"SELECT id_pengeluaran, nama_pengeluaran, jumlah_pengeluaran FROM operasional
                                 WHERE nama_pengeluaran <> 'Admin'";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<OperasionalModel>(sql);
        }

        public OperasionalModel? GetData(int id)
        {
            const string sql = @"SELECT * FROM operasional WHERE id_pengeluaran = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<OperasionalModel>(sql, new { id });
        }

        public void InsertData(OperasionalModel operasional)
        {
            const string sql =
                @"INSERT INTO operasional                      
                        (nama_pengeluaran,jumlah_pengeluaran)
                    VALUES (@nama_pengeluaran,@jumlah_pengeluaran)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, operasional);
        }

        public void UpdateData(OperasionalModel operasional)
        {
            const string sql =
                @"UPDATE operasional
                  SET nama_pengeluaran = @nama_pengeluaran,
                      jumlah_pengeluaran = @jumlah_pengeluaran
                  WHERE id_pengeluaran = @id_pengeluaran";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, operasional);
        }


        public decimal GetAdmin()
        {
            const string sql = @"SELECT jumlah_pengeluaran FROM pengeluaran 
                                WHERE nama_pengeluaran = 'Biaya Admin'";
            using var koneksi = new SqlConnection( conn.connStr);
            return koneksi.QuerySingleOrDefault<decimal>(sql);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM operasional WHERE id_pengeluaran = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id = id });
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM operasional {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql, filter.param);
        }
    }
}
