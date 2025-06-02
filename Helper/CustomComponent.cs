using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public static class CustomComponent
    {
        public static void IsDialogForm(this Form form)
        {
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterParent;
        }

        public static void CustomDataGrid(this DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Mengatur ukuran font header kolom
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.GridColor = Color.Silver;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Mengatur warna header kolom
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.ForeColor = Color.DimGray;


            // Menonaktifkan warna seleksi untuk sel
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.RowTemplate.Height = 45;

            dataGridView.RowHeadersVisible = false;

            // Mencegah penggeseran kolom
            dataGridView.AllowUserToOrderColumns = false;

            // Mencegah pengubahan ukuran kolom
            dataGridView.AllowUserToResizeColumns = true;

            // Mencegah pengubahan ukuran baris
            dataGridView.AllowUserToResizeRows = false;

            // Mencegah penambahan baris baru
            dataGridView.AllowUserToAddRows = false;

            dataGridView.RowPrePaint += (s, e) =>
            {
                if (e.RowIndex % 2 == 0) // Baris genap (putih)
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                else // Baris ganjil (abu-abu)
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(251, 251, 251);
            };
        }

        public static void CustomDataGrid_SmallFont(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Mengatur ukuran font header kolom
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Silver;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Mengatur warna header kolom
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ForeColor = Color.DimGray;


            // Menonaktifkan warna seleksi untuk sel
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;

            dgv.ColumnHeadersHeight = 35;
            dgv.RowTemplate.Height = 40;

            dgv.RowHeadersVisible = false;

            // Mencegah penggeseran kolom
            dgv.AllowUserToOrderColumns = false;

            // Mencegah pengubahan ukuran kolom
            dgv.AllowUserToResizeColumns = true;

            // Mencegah pengubahan ukuran baris
            dgv.AllowUserToResizeRows = false;

            // Mencegah penambahan baris baru
            dgv.AllowUserToAddRows = false;

            dgv.RowPrePaint += (s, e) =>
            {
                if (e.RowIndex % 2 == 0) // Baris genap (putih)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                else // Baris ganjil (abu-abu)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(251, 251, 251);
            };
        }
    }
}
