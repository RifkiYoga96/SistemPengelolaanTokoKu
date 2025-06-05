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
        public void InsertData(int? id_produk, int id_transaksi_detail)
        {
            const string sql = @"
                INSERT INTO transaksi_komponen_detail (id_transaksi_detail, id_komponen, nama_komponen, satuan, jumlah, harga)
                SELECT @id_transaksi_detail, kp.id_komponen, k.nama_komponen, k.satuan, kp.jumlah, k.harga
                FROM komponen k
                INNER JOIN komponen_produk kp ON k.id_komponen = kp.id_komponen
                WHERE kp.id_produk = @id_produk
                ";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new {id_transaksi_detail = id_transaksi_detail, id_produk = id_produk});
        }
    }
}
