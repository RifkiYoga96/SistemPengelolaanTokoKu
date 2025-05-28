using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Reflection.Metadata.Ecma335;

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

        public IEnumerable<TransaksiDetailModel> ListData(int id)
        {
            const string sql = @"SELECT nama_transaksi, harga, modal, jumlah FROM transaksi_detail WHERE id_transaksi = @id";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiDetailModel>(sql, new { id = id });
        }
    }
}
