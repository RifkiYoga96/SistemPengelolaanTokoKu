using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Syncfusion.Windows.Forms.Tools.ColorDlgAdv;

namespace Shopee
{
    public partial class TabelPendapatan : Form
    {
        private DbDapper db;
        DataTable bulan = new DataTable();
        private List<PendapatanModel> _listPendapatan = new();
        private int _jenisPendapatan = 0;

        public TabelPendapatan()
        {
            InitializeComponent();
            db = new DbDapper();
            InitCombo();
            txtPendapatan.ReadOnly = true;
            LoadData();
        }
        bool TanggalRange = false;
        public void LoadData()
        {
            var listPendapatan = db.ListPendapatan(0);

            if (comboBulan.SelectedIndex != 0)
            {
                var filter = ((RangeTimeModel)comboBulan.SelectedItem);
                DateTime Tanggal1 = filter.TimeFilter1;
                DateTime Tanggal2 = filter.TimeFilter2;
                listPendapatan = db.FilterPendapatan2(Tanggal1, Tanggal2);
            }
            if (TanggalRange)
            {
                DateTime Tanggal1 = dateTimePicker3.Value.Date;
                DateTime Tanggal2 = dateTimePicker2.Value.Date;
                listPendapatan = db.FilterPendapatan2(Tanggal1, Tanggal2);
            }
            dataGridView1.DataSource = listPendapatan;
            _listPendapatan.AddRange(listPendapatan);
            Total(_listPendapatan);
        }


        private void InitCombo()
        {
            comboJenisPendapatan.Items.Add("Total Pendapatan Bersih :");
            comboJenisPendapatan.Items.Add("Total Pendapatan Kotor :");
            comboJenisPendapatan.Items.Add("Total Modal :");
            comboJenisPendapatan.SelectedIndex = 0;

            DateTime dateTime = DateTime.Today;
            List<RangeTimeModel> listFilter = new List<RangeTimeModel>
            {
                new RangeTimeModel{NameFilter = "-- Pilih Waktu --", TimeFilter2 = dateTime, TimeFilter1 = dateTime},
                new RangeTimeModel{NameFilter = "Hari ini", TimeFilter2 = dateTime, TimeFilter1 = dateTime},
                new RangeTimeModel{NameFilter = "Kemarin", TimeFilter2 = dateTime.AddDays(-1), TimeFilter1 = dateTime.AddDays(-1)},
                new RangeTimeModel{NameFilter = "7 hari sebelumnya", TimeFilter2 = dateTime, TimeFilter1 = dateTime.AddDays(-6)},
                new RangeTimeModel{NameFilter = "30 hari sebelumnya", TimeFilter2 = dateTime, TimeFilter1 = dateTime.AddDays(-29)},
                new RangeTimeModel{NameFilter = "60 hari sebelumnya", TimeFilter2 = dateTime, TimeFilter1 = dateTime.AddDays(-59)},
                new RangeTimeModel{NameFilter = "90 hari sebelumnya", TimeFilter2 = dateTime, TimeFilter1 = dateTime.AddDays(-89)}
            };
            comboBulan.DataSource = listFilter;
            comboBulan.DisplayMember = "NameFilter";
            comboBulan.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id_pendapatan = txtPendapatan.Text;
            string id_produk = txtProduk.Text;
            string kotor = txtKotor.Text;
            string modal = txtModal.Text;
            string bersih = txtBersih.Text;
            DateTime tgl = dateTimePicker1.Value;
            int jumlahproduk = (int)numericJumlah.Value;

            if (id_produk == "" || kotor == "" || modal == "" || bersih == "" || jumlahproduk <= 0)
            {
                MessageBox.Show("Seluruh Data Wajib Diisi Kecuali ID Pendapatan!");
                return;
            }

            if (id_pendapatan == "")
            {
                Insert(int.Parse(id_produk), double.Parse(kotor), int.Parse(modal), double.Parse(bersih), tgl, jumlahproduk);
            }
            else if (id_pendapatan != "")
            {
                Update(int.Parse(id_pendapatan), int.Parse(id_produk), double.Parse(kotor), int.Parse(modal), double.Parse(bersih), tgl, jumlahproduk);
            }
        }

        public void Insert(int id_produk, double kotor, int modal, double bersih, DateTime tgl, int jumlahproduk)
        {
            string sql = @"INSERT INTO pendapatan (ID_Produk,Pendapatan_Kotor,Modal,Pendapatan_Bersih,Tanggal_Input,Jumlah_Produk)
                            VALUES(@ip,@pk,@m,@pb,@ti,@jp)";
            var insert = db.InsertUpdateDelete(sql, new { ip = id_produk, pk = kotor, m = modal, pb = bersih, ti = tgl, jp = jumlahproduk });
            if (insert > 0)
            {
                MessageBox.Show("Data Berhasil Di Input!");
                LoadData();
            }
        }

        public void Update(int id_pendapatan, int id_produk, double kotor, int modal, double bersih, DateTime tgl, int jumlahproduk)
        {
            string sql = @"UPDATE pendapatan SET ID_Produk=@ip, Pendapatan_Kotor=@pk, Modal = @m, Pendapatan_Bersih = @pb, Tanggal_Input=@ti,Jumlah_Produk=@jp WHERE ID_Pendapatan = @ipp";
            var update = db.InsertUpdateDelete(sql, new { ipp = id_pendapatan, ip = id_produk, pk = kotor, m = modal, pb = bersih, ti = tgl, jp = jumlahproduk });
            if (update > 0)
            {
                MessageBox.Show("Data Berhasil Di Update!");
                LoadData();
            }
        }

        public void Delete(int id_pendapatan)
        {
            string sql = @"DELETE FROM pendapatan WHERE ID_Pendapatan=@ip";
            var delete = db.InsertUpdateDelete(sql, new { ip = id_pendapatan });
            if (delete > 0)
            {
                MessageBox.Show("Data Berhasil Di Hapus!");
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtPendapatan.Text;
            if (id == "")
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!");
            }
            else
            {
                if (MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                Delete(int.Parse(id));
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells["ID_Pendapatan"].Value.ToString();
            if (id == null) return;
            var row = db.ListPendapatan(int.Parse(id));
            if (row == null) return;
            var ro = row.FirstOrDefault();
            if (ro == null) return;
            txtPendapatan.Text = ro.ID_Pendapatan.ToString();
            txtProduk.Text = ro.ID_Produk.ToString();
            txtModal.Text = ro.Modal.ToString();
            txtKotor.Text = ro.Pendapatan_Kotor.ToString();
            txtBersih.Text = ro.Pendapatan_Bersih.ToString();
            numericJumlah.Value = ro.Jumlah_Produk;
            string date = ro.Tanggal_Input.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(date);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            comboBulan.SelectedIndex = 0;
            TanggalRange = true;
            LoadData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            comboBulan.SelectedIndex = 0;
            TanggalRange = true;
            LoadData();
        }

        private void comboBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            TanggalRange = false;
            LoadData();
        }

        public void Total(List<PendapatanModel> data)
        {
            if (!data.Any())
            {
                lblNoData.Visible = true;
                lblTotalBersih.Text = "Rp0,00";
                return;
            }
            else
            {
                lblNoData.Visible = false;
            }


            double totalBersih = 
                _jenisPendapatan == 0 ? data.Sum(x => x.Pendapatan_Bersih) :
                _jenisPendapatan == 1 ? data.Sum(x => x.Pendapatan_Kotor) :
                data.Sum(x => x.Modal);
            string nominal = totalBersih.ToString("C", new CultureInfo("id-ID"));
            lblTotalBersih.Text = nominal; // format uang indo
        }

        private void lblTotalBersih_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtKotor.Clear();
            txtModal.Clear();
            txtBersih.Clear();
            numericJumlah.Value = 0;
            txtIDPendapatan.Clear();
            txtProduk.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void comboJenisPendapatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            _jenisPendapatan = comboJenisPendapatan.SelectedIndex;
            Total(_listPendapatan);
        }
    }
}


