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
        public int InsertData(TransaksiDetailModel td)
        {
            const string sql = @"
                        INSERT INTO transaksi_detail
                            (id_transaksi, id_produk, nama_transaksi, harga, jumlah)
                        OUTPUT INSERTED.id_transaksi_detail
                        VALUES
                            (@id_transaksi, @id_produk, @nama_transaksi, @harga, @jumlah)";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.ExecuteScalar<int>(sql, td);
        }

        public IEnumerable<TransaksiDetailModel> ListData(int id)
        {
            const string sql = @"
                    SELECT nama_transaksi, harga, jumlah,
                    dbo.HitungModalTransaksi(id_transaksi_detail) AS modal
                    FROM transaksi_detail WHERE id_transaksi = @id";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<TransaksiDetailModel>(sql, new { id = id });
        }
    }
}
