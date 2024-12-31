using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class KebutuhanModel
    {
        public int ID_Kebutuhan { get; set; }
        public int ID_Produk { get; set; }
        public int ID_Bahan { get; set; }
        public string Nama_Bahan { get; set; }
        public string Nama_Produk { get; set; }
        public int Harga { get; set; }
        public int Jumlah { get; set; }
    }
}
