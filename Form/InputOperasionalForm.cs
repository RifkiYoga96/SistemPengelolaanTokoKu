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
    public partial class InputOperasionalForm : Form
    {
        private readonly OperasionalDal _operasionalDal = new();
        private int _id;
        public InputOperasionalForm(int id = 0)
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
            numericBiaya.Minimum = 1;
            numericBiaya.Maximum = 10000000;
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
            int biaya = Convert.ToInt32(numericBiaya.Value);

            bool valid = nama != string.Empty
                && biaya != 0;

            if (!valid)
            {
                MessageBoxShow.Warning("Data tidak valid, harap cek kembali!");
                return;
            }

            if (!MessageBoxShow.Confirmation("Apakah Anda yakin ingin menyimpan data?")) return;

            var operasional = new OperasionalModel
            {
                id_pengeluaran = _id,
                nama_pengeluaran = nama,
                jumlah_pengeluaran = biaya,
            };

            if (_id == 0)
                _operasionalDal.InsertData(operasional);
            else
                _operasionalDal.UpdateData(operasional);

            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region GetData

        private void GetData(int id)
        {
            labelHeader.Text = "Update Operasional";

            var data = _operasionalDal.GetData(id);
            if (data is null) return;

            if(data.nama_pengeluaran == "Biaya Iklan")
            {
                txtNama.ReadOnly = true;
                numericBiaya.Focus();
            }

            txtNama.Text = data.nama_pengeluaran;
            numericBiaya.Value = (int)data.jumlah_pengeluaran;
        }
        #endregion
    }
}
