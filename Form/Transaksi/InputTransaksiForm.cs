using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class InputTransaksiForm : Form
    {
        private readonly ProdukDal _produkDal;
        public InputTransaksiForm()
        {
            InitializeComponent();
            this.IsDialogForm();
             _produkDal = new ProdukDal();

            InitComponent();
        }

        private void InitComponent()
        {
            var listProduk = _produkDal.ListProdukCombo()
                .Select(x => new produkModel
                {
                    ID_Produk = x.ID_Produk,
                    Nama_Produk = x.Nama_Produk
                }).ToList();
            comboPendapatanPengeluaran.DataSource = listProduk;
            comboPendapatanPengeluaran.DisplayMember = "Nama_Produk";
            comboPendapatanPengeluaran.ValueMember = "ID_Produk";
        }
    }
}
