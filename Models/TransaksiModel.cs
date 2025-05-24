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
    }
}
