using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class TransaksiDetailModel
    {
        public int id_transaksi { get; set; }
        public string nama_transaksi { get; set; }
        public int harga { get; set; }
        public int jumlah { get; set; }
        public int? modal { get; set; }
        public int? pendapatan_bersih { get; set; }
    }
}
