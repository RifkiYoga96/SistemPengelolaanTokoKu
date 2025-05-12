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
        public string nama_transaksi { get; set; }
        public DateTime tanggal_input { get; set; }
        public int? pendapatan_kotor { get; set; }
        public int? modal { get; set; }
        public int? pendapatan_bersih { get; set; }
        public int? pengeluaran { get; set; }
        public int? jumlah { get; set; }
        public bool tipe { get; set; }
    }
}
