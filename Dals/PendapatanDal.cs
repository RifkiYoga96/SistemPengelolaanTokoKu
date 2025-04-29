using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class PendapatanDal
    {
        public IEnumerable<PendapatanModel> ListData(FilterModel filter)
        {
            string sql = $@"
                        SELECT 
                            p.ID_Pendapatan,pr.Nama_Produk,p.Pendapatan_Kotor,p.Modal,
                            p.Pendapatan_Bersih,p.Tanggal_Input,p.Jumlah_Produk
                        FROM pendapatan p 
                        INNER JOIN produk pr ON p.ID_Produk = pr.ID_Produk
                        {filter.sql}
                        OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<PendapatanModel>(sql, filter.param);
        }

        public int TotalPendapatan(FilterModel filter, string field_name)
        {
            string sql = $@"
                        SELECT 
                            ISNULL (SUM(p.{field_name}), 0)
                        FROM pendapatan p 
                        INNER JOIN produk pr ON p.ID_Produk = pr.ID_Produk
                        {filter.sql}";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }

        public PendapatanModel? GetData(int id)
        {
            const string sql = @"SELECT * FROM Pendapatan WHERE ID_Pendapatan=@id";
            using var koneksi = new SqlConnection(conn.connStr);    
            return koneksi.QueryFirstOrDefault<PendapatanModel>(sql, new { id = id });  
        }

        public void InsertData(PendapatanModel pendapatan)
        {
            const string sql =
                @"INSERT INTO Pendapatan                      
                        (ID_Produk,Pendapatan_Kotor,Modal,Pendapatan_Bersih,Tanggal_Input,Jumlah_Produk)
                  VALUES (@ID_Produk,@Pendapatan_Kotor,@Modal,@Pendapatan_Bersih,@Tanggal_Input,@Jumlah_Produk)";

            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, pendapatan);
        }

        public void DeleteData(int id)
        {
            const string sql = @"DELETE FROM Pendapatan WHERE ID_Pendapatan = @id";
            using var koneksi = new SqlConnection(conn.connStr);
            koneksi.Execute(sql, new { id = id });
        }

        public int CountData(FilterModel filter)
        {
            string sql = $@"SELECT COUNT(*) FROM pendapatan p INNER JOIN produk pr ON p.ID_Produk = pr.ID_Produk {filter.sql}";
            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.QuerySingleOrDefault<int>(sql, filter.param);
        }
    }
}
