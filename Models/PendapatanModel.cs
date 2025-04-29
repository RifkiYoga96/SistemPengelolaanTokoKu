using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class PendapatanModel
    {
        public int ID_Pendapatan { get; set; }
        public int ID_Produk { get; set; }
        public string Nama_Produk { get; set; }
        public double Pendapatan_Kotor { get; set; }
        public int Modal { get; set; }
        public double Pendapatan_Bersih {  get; set; }
        public DateTime Tanggal_Input { get; set; }
        public int Jumlah_Produk { get; set; }
    }
}
