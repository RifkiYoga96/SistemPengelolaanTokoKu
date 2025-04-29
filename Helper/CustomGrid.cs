using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public static class CustomGrid
    { 
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
    }
}
