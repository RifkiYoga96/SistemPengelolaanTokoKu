using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class PengeluaranModel
    {
        public int id_pengeluaran { get; set; }
        public string nama_pengeluaran { get; set; }
        public decimal jumlah_pengeluaran { get; set; }
    }
}
