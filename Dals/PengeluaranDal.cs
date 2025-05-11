using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Shopee
{
    public class PengeluaranDal
    {
        public IEnumerable<PengeluaranModel> ListData(FilterModel filter)
        {
            string sql = $@"SELECT * FROM pengeluaran {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<PengeluaranModel>(sql, filter.param);
        }

        public IEnumerable<PengeluaranModel> ListPengeluaranCombo()
        {
            const string sql = $@"SELECT id_pengeluaran, nama_pengeluaran, jumlah_pengeluaran FROM pengeluaran
                                 WHERE nama_pengeluaran <> 'Admin'";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<PengeluaranModel>(sql);
        }

        public void InsertData(PengeluaranModel pengeluaran)
        {
            const string sql =
                @"INSERT INTO pengeluaran                      
                        (nama_pengeluaran,jumlah_pengeluaran)
                    VALUES (@nama_pengeluaran,@jumlah_pengeluaran)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, pengeluaran);
        }
    }
}
