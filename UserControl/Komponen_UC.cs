using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class Komponen_UC : UserControl
    {
        // Fields
        private readonly KomponenDal _komponenDal;
        private int _indexFilterTimeActive = 0;
        private int _pageNow = 1;
        private int _totalPage = 0;
        private readonly CultureInfo _culture;
        private readonly ImageCustomize _imageCustomize;

        // Constructor
        public Komponen_UC()
        {
            InitializeComponent();
            _komponenDal = new KomponenDal();
            _culture = new CultureInfo("id-ID");
            _imageCustomize = new ImageCustomize();

            InitComponent();
            RegisterEvent();
            LoadData();
            CustomGrid();
        }

        #region Initialization

        private void InitComponent()
        {
            // Keterangan Stok ComboBox
            comboKeteranganStok.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKeteranganStok.Items.AddRange(new[] { "Semua(All)", "Stok Menipis", "Stok Habis" });
            comboKeteranganStok.SelectedIndex = 0;
        }

        #endregion

        #region Event Registration

        private void RegisterEvent()
        {
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnAddData.Click += BtnAddData_Click;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            dataGridView1.CellMouseClick += ShowMenuStrip;
            editMenuStrip.Click += ShowEditForm;
            deleteMenuStrip.Click += DeleteData;
        }

        #endregion

        #region Event Handlers
        private void DeleteData(object? sender, EventArgs e)
        {
            if (!MessageBoxShow.Confirmation()) return;

            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _komponenDal.DeleteData(id);
            LoadData();
        }

        private void ShowEditForm(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (new InputKomponenForm().ShowDialog() != DialogResult.OK) return;
            LoadData();
        }

        private void ShowMenuStrip(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;

            menuStrip.Show(Cursor.Position);
        }

        private void BtnAddData_Click(object? sender, EventArgs e)
        {
            if (new InputTransaksiForm(0).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ComboSorting_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ResetPage();
            LoadData();
        }

        private void NumericUpDown1_ValueChanged(object? sender, EventArgs e)
        {
            ResetPage();
            LoadData();
        }

        private async void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            ResetPage();
            LoadData();
        }

        private void BtnPrevious_Click(object? sender, EventArgs e)
        {
            if (_pageNow > 1)
            {
                _pageNow--;
                LoadData();
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if (_pageNow < _totalPage)
            {
                _pageNow++;
                LoadData();
            }
        }

        #endregion

        #region Data Loading and Filtering

        private FilterModel CreateFilter()
        {
            string search = txtSearch.Text;
            int indexFilter = comboKeteranganStok.SelectedIndex;

            var filter = new FilterModel();
            var listFilter = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                listFilter.Add("(nama_komponen LIKE '%'+@search+'%')");
                filter.param.Add("@search", search);
            }

            string filterStok = indexFilter switch
            {
                1 => "(stok < stok_minimum AND stok > 0)",
                2 => "(stok == 0)",
                _=> ""
            };

            listFilter.Add(filterStok);

            if (listFilter.Any())
            {
                filter.sql = " WHERE " + string.Join(" AND ", listFilter);
            }

            return filter;
        }

        private void LoadData()
        {
            Image pendapatan = Properties.Resources.Pendapatan;
            Image pengeluaran = Properties.Resources.Pengeluaran;

            var filterData = CreateFilter();
            int totalData = _komponenDal.CountData(filterData);
            _totalPage = (int)Math.Ceiling((double)totalData / (int)numericUpDown1.Value);

            int fetch = (int)numericUpDown1.Value;
            int offset = (_pageNow - 1) * fetch;

            filterData.param.Add("@fetch", fetch);
            filterData.param.Add("@offset", offset);

            var listData = _komponenDal.ListData(filterData)
                .Select((x, index) => new
                {
                    x.id_komponen,
                    No = index + 1 + offset,
                    x.nama_komponen,
                    x.harga,
                    x.stok,
                    x.stok_minimum,
                    keterangan_stok
                    pendapatan_kotor = x.pendapatan_kotor?.ToString("C0", _culture),
                    modal = x.modal?.ToString("C0", _culture),
                    pendapatan_bersih = x.pendapatan_bersih?.ToString("C0", _culture),
                    pengeluaran = x.pengeluaran?.ToString("C0", _culture),
                    x.jumlah,
                    tipe = x.tipe ?
                        _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(pendapatan, 15))
                        : _imageCustomize.ImageToByteArray(_imageCustomize.ResizeImagePersentase(pengeluaran, 15))
                }).ToList();

            dataGridView1.DataSource = listData;

            lblPage.Text = _pageNow.ToString();
            int endShow = Math.Min(offset + fetch, totalData);
            int startShow = endShow == 0 ? 0 : offset + 1;
            lblPaginationInfo.Text = $"Showing {startShow} to {endShow} of {totalData} entries";

            Hitung_TotalPendapatan();
        }

        #endregion

        #region Helpers

        private void CustomGrid()
        {
            var dgv = dataGridView1;
            dgv.CustomDataGrid();

            dgv.Columns["No"].HeaderText = "  No";
            dgv.Columns["nama_transaksi"].HeaderText = "Nama Transaksi";
            dgv.Columns["tanggal_input"].HeaderText = "Tanggal";
            dgv.Columns["pendapatan_kotor"].HeaderText = "Pendapatan Kotor";
            dgv.Columns["pendapatan_bersih"].HeaderText = "Pendapatan Bersih";
            dgv.Columns["pengeluaran"].HeaderText = "Pengeluaran";
            dgv.Columns["jumlah"].HeaderText = "Jumlah";
            dgv.Columns["tipe"].HeaderText = "     Tipe";

            dgv.Columns["id_transaksi"].Visible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["No"].FillWeight = 7;
            dgv.Columns["nama_transaksi"].FillWeight = 15;
            dgv.Columns["tanggal_input"].FillWeight = 12;
            dgv.Columns["pendapatan_kotor"].FillWeight = 11;
            dgv.Columns["modal"].FillWeight = 11;
            dgv.Columns["pendapatan_bersih"].FillWeight = 11;
            dgv.Columns["pengeluaran"].FillWeight = 11;
            dgv.Columns["jumlah"].FillWeight = 11;
            dgv.Columns["tipe"].FillWeight = 11;

            dgv.Columns["No"].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
            dgv.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["tipe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void Hitung_TotalPendapatan()
        {
            int indexComboTotal = comboTotal.SelectedIndex;
            string fieldName = indexComboTotal switch
            {
                0 => "pendapatan_bersih",
                1 => "pendapatan_kotor",
                2 => "modal",
                _ => "pengeluaran"
            };

            bool isLabaBersih = indexComboTotal == 0;

            int totalPendapatan = _transaksiDal.TotalPendapatan(CreateFilter(), fieldName, isLabaBersih);
            lblPendapatan.Text = totalPendapatan.ToString("C", _culture);
        }

        private void ResetPage()
        {
            _pageNow = 1;
        }

        #endregion
    }
}
