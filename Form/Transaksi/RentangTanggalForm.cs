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
    public partial class RentangTanggalForm : Form
    {
        public RentangTanggalForm()
        {
            InitializeComponent();
            GetData();
            btnOk.Click += BtnOk_Click;
        }

        private void GetData()
        {
            dateTime1.Value = TransaksiUC._date1;
            dateTime2.Value = TransaksiUC._date2;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            var date1 = dateTime1.Value.Date;
            var date2 = dateTime2.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59); // +1 supaya di hari itu juga terdeteksi
            TransaksiUC._date1 = date1;
            TransaksiUC._date2 = date2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
