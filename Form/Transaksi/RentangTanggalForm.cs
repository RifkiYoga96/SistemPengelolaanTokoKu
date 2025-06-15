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
        private string _ucType;
        public RentangTanggalForm(string ucType)
        {
            InitializeComponent();
            _ucType = ucType;
            GetData();
            RegisterEvent();
        }

        private void RegisterEvent()
        {
            btnOk.Click += BtnOk_Click;
            btnSelectFormDate.Click += BtnSelectFormDate_Click;
            btnSelectToDate.Click += BtnSelectToDate_Click;
        }

        private void BtnSelectToDate_Click(object? sender, EventArgs e)
        {
            dateTime1.Value = dateTime2.Value;
        }

        private void BtnSelectFormDate_Click(object? sender, EventArgs e)
        {
            dateTime2.Value = dateTime1.Value;
        }

        private void GetData()
        {
            switch (_ucType)
            {
                case "transaksi":
                    dateTime1.Value = TransaksiUC._date1;
                    dateTime2.Value = TransaksiUC._date2;
                    break;
                case "dashboard":
                    dateTime1.Value = Dashboard_UC._date1;
                    dateTime2.Value = Dashboard_UC._date2;
                    break;
            }
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            var date1 = dateTime1.Value.Date;
            var date2 = dateTime2.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59); // +1 supaya di hari itu juga terdeteksi

            switch (_ucType)
            {
                case "transaksi":
                    TransaksiUC._date1 = date1;
                    TransaksiUC._date2 = date2;
                    break;
                case "dashboard":
                    Dashboard_UC._date1 = date1;
                    Dashboard_UC._date2 = date2;
                    break;
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
