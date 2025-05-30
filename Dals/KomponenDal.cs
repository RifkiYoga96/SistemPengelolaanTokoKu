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
        public IEnumerable<KomponenModel> ListData(FilterModel filter)
        {
            string sql = $@"SELECT id_komponen, nama_komponen, harga, satuan,  stok, stok_minimum FROM komponen {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            var listKomponen = koneksi.Query<KomponenModel>(sql, filter.param);
            return listKomponen;
        }
  

        public KomponenModel? GetData(int id)
        {
            const string sql = @"SELECT nama_komponen, harga, satuan, stok, stok_minimum FROM komponen WHERE id_komponen = @id";

            using var koneksi = new SqlConnection(conn.connStr);
            var listKomponen = koneksi.QueryFirstOrDefault<KomponenModel>(sql, new {id = id});
            return listKomponen;
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM komponen WHERE id_komponen = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new {id=id});
        }

        public void InsertData(KomponenModel komponen)
        {
            const string sql = @"INSERT INTO komponen (nama_komponen, harga, satuan, stok, stok_minimum)
                         VALUES (@nama_komponen, @harga, @satuan, @stok, @stok_minimum)";

            using var koneksi = new SqlConnection(conn.connStr);
            var dp = new DynamicParameters();
            dp.Add("@nama_komponen", komponen.nama_komponen);
            dp.Add("@harga", komponen.harga);
            dp.Add("@satuan", komponen.satuan);
            dp.Add("@stok", komponen.stok);
            dp.Add("@stok_minimum", komponen.stok_minimum);

            koneksi.Execute(sql, dp);
        }

        public void UpdateData(KomponenModel komponen)
        {
            const string sql = @"UPDATE komponen 
                         SET nama_komponen = @nama_komponen, 
                             harga = @harga,
                             satuan = @satuan,
                             stok = @stok,
                             stok_minimum = @stok_minimum
                         WHERE id_komponen = @id_komponen";

            using var koneksi = new SqlConnection(conn.connStr);
            var dp = new DynamicParameters();
            dp.Add("@id_komponen", komponen.id_komponen);
            dp.Add("@nama_komponen", komponen.nama_komponen);
            dp.Add("@harga", komponen.harga);
            dp.Add("@satuan", komponen.satuan);
            dp.Add("@stok", komponen.stok);
            dp.Add("@stok_minimum", komponen.stok_minimum);

            koneksi.Execute(sql, dp);
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM komponen {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            int jumlah = koneksi.ExecuteScalar<int>(sql, filter.param);

            return jumlah;
        }
    }
}
