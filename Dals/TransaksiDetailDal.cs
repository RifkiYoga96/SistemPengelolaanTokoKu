using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Shopee
{
    public class TransaksiDetailDal
    {
        public void InsertData(TransaksiDetailModel td)
        {
            const string sql = @"
                        INSERT INTO transaksi_detail
                            (id_transaksi, nama_transaksi, harga, jumlah, modal)
                        VALUES
                            (@id_transaksi, @nama_transaksi, @harga, @jumlah, @modal)";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, td);
        }
    }
}
