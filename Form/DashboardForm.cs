using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class DashboardForm : Form
    {
        private Button? _buttonActive = null;
        public DashboardForm()
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();
        }
        
        private void InitComponent()
        {
            _buttonActive = btnDashboard;
        }

        private void RegisterEvent()
        {
            btnDashboard.Click += btnMenu_Click;
            btnPendapatan.Click += btnMenu_Click;
            btnProduk.Click += btnMenu_Click;
            btnSparepart.Click += btnMenu_Click;
            btnPartsProduk.Click += btnMenu_Click;
        }

        private void btnMenu_Click(object? sender, EventArgs e)
        {
            if(_buttonActive != null) // declare menu inactive
            {
                _buttonActive.BackColor = SystemColors.Control;
                _buttonActive.ForeColor = Color.Black;
            }

            if(sender is Button btn) //set menu active
            {
                btn.BackColor = SystemColors.ControlDark;
                btn.ForeColor = Color.White;

                ShowInPanel(btn.Name);

                _buttonActive = btn;
            }
        }

        private void ShowInPanel(string btn_name)
        {
            UserControl form = new Dashboard_UC();

            switch (btn_name)
            {
                case "btnDashboard":
                    form = new Dashboard_UC();
                    break;
                case "btnPendapatan":
                    form = new Pendapatan_UC();
                    break;
            }

            mainPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
        }
    }
}