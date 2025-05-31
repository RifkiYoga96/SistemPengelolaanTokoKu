using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Shopee
{
    public class TransaksiKomponenDetailDal
    {
        public void InsertData(TransaksiKomponenDetailModel model)
        {
            const string sql = @"
                INSERT INTO transaksi_komponen_detail (id_transaksi, id_komponen, nama_komponen, satuan, jumlah, harga)
                VALUES (@id_transaksi, @id_komponen, @nama_komponen, @satuan, @jumlah, @harga)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, model);
        }
    }
}
