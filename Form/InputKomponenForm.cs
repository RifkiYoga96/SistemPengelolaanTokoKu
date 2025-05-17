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
            int stok = Convert.ToInt32(numericStok.Value);

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
                stok = stok
            };

            if (_id == 0)
                _komponenDal.InsertData(komponen);
            else
                _komponenDal.UpdateData(komponen);

            MessageBoxShow.Information("Data berhasil disimpan");
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
            numericHarga.Value = (int)data.harga;
            numericStok.Value = (int)data.stok;
        }
        #endregion
    }
}
