using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class ProdukModel
    {
        public int id_produk { get; set; }
        public string nama_produk { get; set; }
        public int harga {  get; set; }
    }

    public class produkModel
    {
        public int ID_Produk { get; set; }
        public int ID_Bahan { get; set; }
        public string Nama_Produk { get; set; }
        public int Harga { get; set; }
        public bool Tipe { get; set; }

    }
}
