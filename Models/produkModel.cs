using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class ProdukModel : INotifyPropertyChanged
    {
        public int id_produk { get; set; }
        public int harga { get; set; }
        private string _nama_produk { get; set; } = "";
        public string nama_produk
        {
            get => _nama_produk;
            set
            {
                if (_nama_produk != value)
                {
                    _nama_produk = value;
                    OnPropertyChanged(nameof(nama_produk));
                }
            }
        }

        private int _stok;
        public int stok
        {
            get => _stok;
            set
            {
                if (_stok != value)
                {
                    _stok = value;
                    OnPropertyChanged(nameof(stok));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
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
