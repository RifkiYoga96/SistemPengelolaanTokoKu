namespace Shopee
{
    partial class DetailTransaksiPemasukanForm
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
            gridPendapatan = new DataGridView();
            panel3 = new Panel();
            lblPendapatanBersih = new Label();
            lblModal = new Label();
            lblBiayaAdmin = new Label();
            lblNominalDiskon = new Label();
            lblPendapatanKotor = new Label();
            label6 = new Label();
            label5 = new Label();
            lblAdminKet = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            lblBiayaProsesPesanan = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPendapatan).BeginInit();
            panel3.SuspendLayout();
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
            label1.Text = "Detail Transaksi (Pendapatan)";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblTanggal);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(gridPendapatan);
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
            // gridPendapatan
            // 
            gridPendapatan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPendapatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPendapatan.Location = new Point(9, 40);
            gridPendapatan.Name = "gridPendapatan";
            gridPendapatan.RowHeadersWidth = 51;
            gridPendapatan.RowTemplate.Height = 29;
            gridPendapatan.Size = new Size(560, 157);
            gridPendapatan.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblBiayaProsesPesanan);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblPendapatanBersih);
            panel3.Controls.Add(lblModal);
            panel3.Controls.Add(lblBiayaAdmin);
            panel3.Controls.Add(lblNominalDiskon);
            panel3.Controls.Add(lblPendapatanKotor);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblAdminKet);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(9, 251);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 232);
            panel3.TabIndex = 1;
            // 
            // lblPendapatanBersih
            // 
            lblPendapatanBersih.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendapatanBersih.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendapatanBersih.ForeColor = Color.FromArgb(0, 192, 0);
            lblPendapatanBersih.Location = new Point(422, 179);
            lblPendapatanBersih.Name = "lblPendapatanBersih";
            lblPendapatanBersih.Size = new Size(147, 34);
            lblPendapatanBersih.TabIndex = 24;
            lblPendapatanBersih.Text = "Rp230.400";
            lblPendapatanBersih.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblModal
            // 
            lblModal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblModal.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblModal.ForeColor = Color.Black;
            lblModal.Location = new Point(444, 149);
            lblModal.Name = "lblModal";
            lblModal.Size = new Size(125, 23);
            lblModal.TabIndex = 23;
            lblModal.Text = "Rp230.400";
            lblModal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBiayaAdmin
            // 
            lblBiayaAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBiayaAdmin.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBiayaAdmin.ForeColor = Color.Black;
            lblBiayaAdmin.Location = new Point(444, 80);
            lblBiayaAdmin.Name = "lblBiayaAdmin";
            lblBiayaAdmin.Size = new Size(125, 23);
            lblBiayaAdmin.TabIndex = 22;
            lblBiayaAdmin.Text = "Rp230.400";
            lblBiayaAdmin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNominalDiskon
            // 
            lblNominalDiskon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNominalDiskon.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNominalDiskon.ForeColor = Color.Black;
            lblNominalDiskon.Location = new Point(444, 47);
            lblNominalDiskon.Name = "lblNominalDiskon";
            lblNominalDiskon.Size = new Size(125, 23);
            lblNominalDiskon.TabIndex = 21;
            lblNominalDiskon.Text = "Rp230.400";
            lblNominalDiskon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPendapatanKotor
            // 
            lblPendapatanKotor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendapatanKotor.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendapatanKotor.ForeColor = Color.Black;
            lblPendapatanKotor.Location = new Point(444, 14);
            lblPendapatanKotor.Name = "lblPendapatanKotor";
            lblPendapatanKotor.Size = new Size(125, 23);
            lblPendapatanKotor.TabIndex = 20;
            lblPendapatanKotor.Text = "Rp230.400";
            lblPendapatanKotor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(254, 188);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 19;
            label6.Text = "Pendapatan Bersih";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(347, 149);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 18;
            label5.Text = "Modal";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAdminKet
            // 
            lblAdminKet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminKet.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminKet.ForeColor = SystemColors.ControlDarkDark;
            lblAdminKet.Location = new Point(258, 80);
            lblAdminKet.Name = "lblAdminKet";
            lblAdminKet.Size = new Size(147, 23);
            lblAdminKet.TabIndex = 17;
            lblAdminKet.Text = "Admin (12%)";
            lblAdminKet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(274, 47);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 16;
            label2.Text = "Nominal Diskon";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(412, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 197);
            panel4.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(258, 14);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 14;
            label4.Text = "Pendapatan Kotor";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBiayaProsesPesanan
            // 
            lblBiayaProsesPesanan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBiayaProsesPesanan.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBiayaProsesPesanan.ForeColor = Color.Black;
            lblBiayaProsesPesanan.Location = new Point(444, 113);
            lblBiayaProsesPesanan.Name = "lblBiayaProsesPesanan";
            lblBiayaProsesPesanan.Size = new Size(125, 23);
            lblBiayaProsesPesanan.TabIndex = 26;
            lblBiayaProsesPesanan.Text = "Rp1.250";
            lblBiayaProsesPesanan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(214, 113);
            label8.Name = "label8";
            label8.Size = new Size(191, 23);
            label8.TabIndex = 25;
            label8.Text = "Biaya Proses Pesanan";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DetailTransaksiPemasukanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(593, 490);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "DetailTransaksiPemasukanForm";
            Text = "DetailTransaksiForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPendapatan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView gridPendapatan;
        private Panel panel3;
        private Label lblAdminKet;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private Label lblPendapatanBersih;
        private Label lblModal;
        private Label lblBiayaAdmin;
        private Label lblNominalDiskon;
        private Label lblPendapatanKotor;
        private Label label6;
        private Label label5;
        private Label lblTanggal;
        private Label label7;
        private Label lblBiayaProsesPesanan;
        private Label label8;
    }
}