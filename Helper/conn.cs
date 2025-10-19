using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public static class conn
    {
        public static string connStr = "Server=(local);Database=db_scuritysensor_shopee;Trusted_Connection=True;TrustServerCertificate=True";

        public static async Task<bool> GantiDatabaseAsync(string db)
        {
            var newStr = $"Server=(local);Database={db};Trusted_Connection=True;TrustServerCertificate=True";
            try
            {
                using var con = new SqlConnection(newStr);
                await con.OpenAsync();
                connStr = newStr;
                return true;
            }
            catch { return false; }
        }
    }
}
