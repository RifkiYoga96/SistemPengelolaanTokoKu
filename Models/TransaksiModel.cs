using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class TransaksiModel
    {
        public int id_transaksi { get; set; }
        public DateTime tanggal { get; set; }
        public decimal? admin { get; set; }
        public int? nominal_diskon { get; set; }
        public bool tipe { get; set; }
        public string status { get; set; }

        public string nama_transaksi { get; set; }
        public int harga { get; set; }
        public int jumlah { get; set; }
        public int? modal { get; set; }
        public int? pendapatan_bersih { get; set; }
    }
}
