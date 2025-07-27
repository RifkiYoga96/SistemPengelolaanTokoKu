using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
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
            RegisterEvent();
        }

        private void RegisterEvent()
        {
            currentPendapatanKotor.TextChanged += (s, e) => Currency_ValueChanged(currentPendapatanKotor);
            currentModal.TextChanged += (s, e) => Currency_ValueChanged(currentModal, percentModal);
            currentBiayaLainnya.TextChanged += (s, e) => Currency_ValueChanged(currentBiayaLainnya, percentBiayaLainnya);
            currentBiayaIklan.TextChanged += (s, e) => Currency_ValueChanged(currentBiayaIklan, percentBiayaIklan);
            txtProdukTerjual.TextChanged += (s, e) => Currency_ValueChanged(null, null, false, true);

            currentBiayaIklan.TextChanged += (s, e) => Iklan_ValueChanged();
        }

        private async void Iklan_ValueChanged()
        {
            await Task.Delay(500);

            if (!ValidationRequiredInput()) return;

            txtRoas.Text = (currentPendapatanKotor.DecimalValue / currentBiayaIklan.DecimalValue).ToString("N2");
            currentBiayaPerKonversi.DecimalValue = (currentPendapatanKotor.DecimalValue == 0) ? 0 : currentBiayaIklan.DecimalValue / int.Parse(txtProdukTerjual.Text);
        }

        private async void Currency_ValueChanged(CurrencyTextBox? currencyTextBox = null, Label? lbl = null, bool nominal = true, bool produkTerjualChange = false)
        {
            await Task.Delay(500);

            if (!ValidationRequiredInput()) return;


            //nominal
            decimal pendapatanKotor = currentPendapatanKotor.DecimalValue;
            int produkTerjual = int.Parse(txtProdukTerjual.Text);
            decimal modal = currentModal.DecimalValue;
            decimal adminFee = (decimal)percentAdmin.DoubleValue;
            decimal biayaIklan = currentBiayaIklan.DecimalValue;
            decimal biayaLainnya = currentBiayaLainnya.DecimalValue;

            decimal pendapatanBersih = (pendapatanKotor * (1 - adminFee)) - modal - biayaIklan - biayaLainnya;

            currentPendapatanBersih.DecimalValue = pendapatanBersih;

            //persentase
            if (currencyTextBox == currentPendapatanKotor || produkTerjualChange)
            {
                //update all percent
                percentModal.Text = ((modal * 100 / pendapatanKotor) / 100).ToString("P2");
                percentBiayaIklan.Text = ((biayaIklan * 100 / pendapatanKotor) / 100).ToString("P2");
                percentBiayaLainnya.Text = ((biayaLainnya * 100 / pendapatanKotor) / 100).ToString("P2");

                currentBiayaPerKonversi.DecimalValue = (pendapatanKotor == 0) ? 0 : biayaIklan / produkTerjual;
                txtRoas.Text = (pendapatanKotor == 0) ? "0" : (pendapatanKotor / biayaIklan).ToString("N2");
            }

            if (currencyTextBox != null && lbl != null)
            {
                lbl.Text = ((currencyTextBox.DecimalValue * 100 / pendapatanKotor) / 100).ToString("P2");
            }

            string percentBersih = ((pendapatanBersih * 100 / pendapatanKotor) / 100).ToString("P2");
            percentPendapatanBersih.Text = percentBersih;
        }

        private bool ValidationRequiredInput()
        {
            if (currentPendapatanKotor.DecimalValue == 0 && txtProdukTerjual.Text == string.Empty)
            {
                MessageBoxShow.Warning("Pendapatan Kotor & Produk Terjual wajib diisi terlebih dahulu!");
                return false;
            }
            return true;
        }

        private bool ValidationNominal(decimal nominal)
        {
            decimal pendapatanBersih = currentPendapatanBersih.DecimalValue;

            if (pendapatanBersih < nominal)
            {
                MessageBoxShow.Warning($"Nominal yang dimasukkan tidak boleh lebih dari {pendapatanBersih.ToString("C0")}");
                return false;
            }
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private bool ValidationPrecent(double percent)
         {
             double pendapatanBersihPercent = percentPendapatanBersih.PercentValue;

             if (pendapatanBersihPercent < percent)
             {
                 MessageBoxShow.Warning($"Persentase yang dimasukkan tidak boleh lebih dari {pendapatanBersihPercent.ToString("P2")}");
                 return false;
             }
             return true;
         }*/
    }
}
