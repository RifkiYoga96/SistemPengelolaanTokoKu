using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Shopee
{
    public class KomponenDal
    {
        public IEnumerable<KomponenModel> ListData()
        {
            string sql = @"SELECT id_komponen, nama_komponen, harga FROM komponen";

            using var koneksi = new SqlConnection(conn.connStr);
            var listKomponen = koneksi.Query<KomponenModel>(sql);
            return listKomponen;
        }
    }
}
