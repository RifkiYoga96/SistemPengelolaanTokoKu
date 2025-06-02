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
    public partial class InputProdukForm : Form
    {
        private readonly ProdukDal _produkDal = new();
        private int _id;
        public InputProdukForm(int id = 0)
        {
            InitializeComponent();
            this.IsDialogForm();

            InitComponent();
            RegisterEvent();

            this._id = id;
            if (id != 0)
                GetData(id);
        }

        #region Initialize Component

        private void InitComponent()
        {
            txtNama.MaxLength = 50;
            numericHarga.Minimum = 1;
            numericHarga.Maximum = 10000000;
            numericHarga.Text = null;
        }

        #endregion

        #region Event

        private void RegisterEvent()
        {
            btnSave.Click += SaveData;
        }

        private void SaveData(object? sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            int harga = Convert.ToInt32(numericHarga.Value);

            bool valid = nama != string.Empty
                && harga != 0;

            if (!valid)
            {
                MessageBoxShow.Warning("Data tidak valid, harap cek kembali!");
                return;
            }

            if (!MessageBoxShow.Confirmation("Apakah Anda yakin ingin menyimpan data?")) return;

            var produk = new ProdukModel
            {
                id_produk = _id,
                nama_produk = nama,
                harga = harga,
            };

            if (_id == 0)
                _produkDal.InsertData(produk);
            else
                _produkDal.UpdateData(produk);

            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region GetData

        private void GetData(int id)
        {
            labelHeader.Text = "Update Produk";

            var data = _produkDal.GetData(id);
            if (data is null) return;

            txtNama.Text = data.nama_produk;
            numericHarga.Value = (int)data.harga;
        }
        #endregion
    }
}
