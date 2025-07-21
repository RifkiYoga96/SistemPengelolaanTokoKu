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
    public partial class Calculator_UC : UserControl
    {
        public Calculator_UC()
        {
            InitializeComponent();
        }

        private bool ValidationRequiredInput()
        {
            if(currentPendapatanKotor.DecimalValue == 0 && txtProdukTerjual.Text == string.Empty)
            {
                MessageBoxShow.Warning("Pendapatan Kotor & Produk Terjual wajib diisi terlebih dahulu!");
                return false;
            }
            return true;
        }
    }
}
