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
            const string sql = @"SELECT * FROM Pendapatan
                        @filter
                        OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var koneksi = new SqlConnection(conn.connStr);
            return koneksi.Query<PendapatanModel>(filter.sql, filter.param);
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
    }
}
