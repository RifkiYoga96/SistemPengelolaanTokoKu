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
        private Image _scurity_sensor_shopee = Properties.Resources.scurity_sensor_shopee;
        private Image _scurity_sensor_tiktok = Properties.Resources.scurity_sensor_tiktok;
        private Image _riyosa_store_shopee = Properties.Resources.riyosa_store_shopee;
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
            btnTransaksi.Click += btnMenu_Click;
            btnProduk.Click += btnMenu_Click;
            btnKomponen.Click += btnMenu_Click;
            btnKomponenProduk.Click += btnMenu_Click;
            btnOperasional.Click += btnMenu_Click;
            btnKalkulator.Click += btnMenu_Click;

            btnGantiToko.Click += BtnGantiToko_Click;
            menuStripScuritySensorShopee.Click += MenuStripScuritySensorShopee_Click;
            menuStripScuritySensorTikTok.Click += MenuStripScuritySensorTikTok_Click;
            menuStripRiyosaStoreShopee.Click += MenuStripRiyosaStoreShopee_Click;
        }

        private async void MenuStripRiyosaStoreShopee_Click(object? sender, EventArgs e)
        {
            bool sukses = await conn.GantiDatabaseAsync("db_riyosastore_shopee");

            if (sukses)
                MessageBox.Show($"Berhasil Pindah Ke Toko Riyosa Store - Shopee");
            else
                MessageBox.Show("Gagal pindah toko!");

            pictureBoxLogoToko.BackgroundImage = _riyosa_store_shopee; 

            btnDashboard.PerformClick();
        }

        private async void MenuStripScuritySensorTikTok_Click(object? sender, EventArgs e)
        {
            bool sukses = await conn.GantiDatabaseAsync("db_scuritysensor_tiktok");

            if (sukses)
                MessageBox.Show($"Berhasil Pindah Ke Toko Scurity Sensor - TikTok");
            else
                MessageBox.Show("Gagal pindah toko!");

            pictureBoxLogoToko.BackgroundImage = _scurity_sensor_tiktok;

            btnDashboard.PerformClick();
        }

        private async void MenuStripScuritySensorShopee_Click(object? sender, EventArgs e)
        {
            bool sukses = await conn.GantiDatabaseAsync("db_scuritysensor_shopee");

            if (sukses)
                MessageBox.Show($"Berhasil Pindah Ke Toko Scurity Sensor - Shopee");
            else
                MessageBox.Show("Gagal pindah toko!");

            pictureBoxLogoToko.BackgroundImage = _scurity_sensor_shopee;
            btnDashboard.PerformClick();
        }

        private void BtnGantiToko_Click(object? sender, EventArgs e)
        {
            menuStripGantiToko.Show(btnGantiToko, new Point(0, btnGantiToko.Height));
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
                case "btnTransaksi":
                    form = new TransaksiUC();
                    break;
                case "btnKomponenProduk":
                    form = new KomponenProduk_UC();
                    break;
                case "btnKomponen":
                    form = new Komponen_UC();
                    break;
                case "btnOperasional":
                    form = new Operasional_UC();
                    break;
                case "btnProduk":
                    form = new Produk_UC();
                    break;
                case "btnKalkulator":
                    form = new Calculator_UC();
                    break;
            }

            mainPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
        }

    }
}