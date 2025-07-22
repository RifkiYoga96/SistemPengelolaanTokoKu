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
            currentPendapatanKotor.TextChanged += (s, e) => Currency_TextChanged(currentPendapatanKotor);
            currentModal.TextChanged += (s,e) => Currency_TextChanged(currentModal,percentModal);
            currentBiayaLainnya.TextChanged += (s, e) => Currency_TextChanged(currentBiayaLainnya,percentBiayaLainnya);
            currentBiayaIklan.TextChanged += (s, e) => Currency_TextChanged(currentBiayaIklan,percentBiayaIklan);

        }

        private async void Currency_TextChanged(CurrencyTextBox currencyTextBox = null, PercentTextBox? percentTextBox = null)
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
            if(currencyTextBox == currentPendapatanKotor)
            {
                //update all percent
                percentModal.DoubleValue = (double)(modal * 100 / pendapatanKotor) / 100;
                percentAdmin.DoubleValue = (double)adminFee;
                percentBiayaIklan.DoubleValue = (double)(biayaIklan * 100 / pendapatanKotor) / 100;
                percentBiayaLainnya.DoubleValue = (double)(biayaLainnya * 100 / pendapatanKotor) / 100;
                percentAcos.DoubleValue = (double)(biayaIklan * 100 / pendapatanBersih) / 100;
            }

            if(currencyTextBox != null && percentTextBox != null)
            {
                percentTextBox.DoubleValue = (double)((currencyTextBox.DecimalValue * 100 / pendapatanKotor) / 100);
            }
            
            double percentResult = 1 - percentModal.DoubleValue
                                    - percentAdmin.DoubleValue
                                    - percentBiayaIklan.DoubleValue
                                    - percentBiayaLainnya.DoubleValue;
            percentPendapatanBersih.DoubleValue = percentResult;

            //MessageBox.Show((1 - adminFee).ToString());
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

        private bool ValidationNominal(decimal nominal)
        {
            decimal pendapatanBersih = currentPendapatanBersih.DecimalValue;

            if(pendapatanBersih < nominal)
            {
                MessageBoxShow.Warning($"Nominal yang dimasukkan tidak boleh lebih dari {pendapatanBersih.ToString("C0")}");
                return false;
            }
            return true;
        }

        private bool ValidationPrecent(double percent)
        {
            double pendapatanBersihPercent = percentPendapatanBersih.PercentValue;

            if (pendapatanBersihPercent < percent)
            {
                MessageBoxShow.Warning($"Persentase yang dimasukkan tidak boleh lebih dari {pendapatanBersihPercent.ToString("P2")}");
                return false;
            }
            return true;
        }
    }
}
