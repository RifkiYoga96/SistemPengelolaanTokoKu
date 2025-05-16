using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class KomponenProdukModel
    {
        public int id_produk { get; set; }
        public int id_komponen { get; set; }
        public string nama_komponen { get; set; }
        public int stok { get; set; }
        public int jumlah { get; set; }
        public int harga { get; set; }
    }
}
