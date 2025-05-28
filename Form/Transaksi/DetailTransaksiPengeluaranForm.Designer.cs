namespace Shopee
{
    partial class DetailTransaksiPengeluaranForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            lblTanggal = new Label();
            label7 = new Label();
            panel3 = new Panel();
            lblTotal = new Label();
            label4 = new Label();
            gridPengeluaran = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPengeluaran).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(10, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 4);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, -6);
            label1.Name = "label1";
            label1.Size = new Size(508, 41);
            label1.TabIndex = 8;
            label1.Text = "Detail Transaksi (Pengeluaran)";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(gridPengeluaran);
            panel2.Controls.Add(lblTanggal);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(9, 46);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 205);
            panel2.TabIndex = 0;
            // 
            // lblTanggal
            // 
            lblTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTanggal.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTanggal.ForeColor = Color.Black;
            lblTanggal.Location = new Point(85, 9);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(139, 23);
            lblTanggal.TabIndex = 25;
            lblTanggal.Text = "12 Agustus 2025";
            lblTanggal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(9, 9);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 25;
            label7.Text = "Tanggal : ";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(9, 251);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 52);
            panel3.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(439, 14);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 23);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Rp230.400";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(399, 14);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 14;
            label4.Text = "Total";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gridPengeluaran
            // 
            gridPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPengeluaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPengeluaran.Location = new Point(9, 38);
            gridPengeluaran.Name = "gridPengeluaran";
            gridPengeluaran.RowHeadersWidth = 51;
            gridPengeluaran.RowTemplate.Height = 29;
            gridPengeluaran.Size = new Size(560, 157);
            gridPengeluaran.TabIndex = 26;
            // 
            // DetailTransaksiPengeluaranForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(593, 310);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "DetailTransaksiPengeluaranForm";
            Text = "DetailTransaksiForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPengeluaran).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView gridPengeluaran;
        private Panel panel3;
        private Label lblAdminKet;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private Label lblPendapatanBersih;
        private Label lblModal;
        private Label lblBiayaAdmin;
        private Label lblNominalDiskon;
        private Label lblTotal;
        private Label label6;
        private Label label5;
        private Label lblTanggal;
        private Label label7;
    }
}