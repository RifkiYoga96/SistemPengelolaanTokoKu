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
    public partial class InputKomponenForm : Form
    {
        private readonly KomponenDal _komponenDal = new();
        private int _id;
        public InputKomponenForm(int id = 0)
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
            numericStok.Maximum = 10000;
            numericHarga.Text = null;
            numericStok.Text = null;
            numericStokMinimum.Text = null;

            txtNama.Focus();

            comboSatuan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSatuan.Items.AddRange(new object[] { "pcs", "cm" });
            comboSatuan.SelectedIndex = 0;
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
            string satuan = comboSatuan.SelectedItem?.ToString() ?? "pcs";
            int stok = Convert.ToInt32(numericStok.Value);
            int stokMinimum = Convert.ToInt32(numericStokMinimum.Value);

            bool valid = nama != string.Empty
                && harga != 0
                && stok != 0;

            if (!valid)
            {
                MessageBoxShow.Warning("Data tidak valid, harap cek kembali!");
                return;
            }

            if (!MessageBoxShow.Confirmation("Apakah Anda yakin ingin menyimpan data?")) return;

            var komponen = new KomponenModel
            {
                id_komponen = _id,
                nama_komponen = nama,
                harga = harga,
                satuan = satuan,
                stok = stok,
                stok_minimum = stokMinimum
            };

            if (_id == 0)
                _komponenDal.InsertData(komponen);
            else
                _komponenDal.UpdateData(komponen);

            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region GetData

        private void GetData(int id)
        {
            labelHeader.Text = "Update Komponen";

            var data = _komponenDal.GetData(id);
            if (data is null) return;

            txtNama.Text = data.nama_komponen;
            comboSatuan.SelectedItem = data.satuan ?? "pcs";
            numericHarga.Value = (int)data.harga;
            numericStok.Value = (int)data.stok;
            numericStokMinimum.Value = (int)data.stok_minimum;
        }
        #endregion
    }
}
