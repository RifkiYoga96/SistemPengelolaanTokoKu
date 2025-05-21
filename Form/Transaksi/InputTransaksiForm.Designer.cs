namespace Shopee
{
    partial class InputTransaksiForm
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
            comboProduk = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            dtPendapatan = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            numericJumlahPendapatan = new NumericUpDown();
            lblJumlah = new Label();
            btnSavePendapatan = new Button();
            tabControl1 = new TabControl();
            tabPendapatan = new TabPage();
            label7 = new Label();
            numericHargaPendapatan = new NumericUpDown();
            tabPengeluaran = new TabPage();
            dtPengeluaran = new DateTimePicker();
            btnSavePengeluaran = new Button();
            comboPengeluaran = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            numericPengeluaran = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericJumlahPendapatan).BeginInit();
            tabControl1.SuspendLayout();
            tabPendapatan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericHargaPendapatan).BeginInit();
            tabPengeluaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPengeluaran).BeginInit();
            SuspendLayout();
            // 
            // comboProduk
            // 
            comboProduk.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProduk.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboProduk.FormattingEnabled = true;
            comboProduk.Location = new Point(26, 128);
            comboProduk.Name = "comboProduk";
            comboProduk.Size = new Size(288, 31);
            comboProduk.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, -3);
            label1.Name = "label1";
            label1.Size = new Size(330, 41);
            label1.TabIndex = 6;
            label1.Text = "Input Transaksi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(21, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 4);
            panel1.TabIndex = 7;
            // 
            // dtPendapatan
            // 
            dtPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtPendapatan.Location = new Point(26, 53);
            dtPendapatan.Name = "dtPendapatan";
            dtPendapatan.Size = new Size(288, 31);
            dtPendapatan.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 24);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 14;
            label4.Text = "Tanggal";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 15;
            label2.Text = "Produk";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericJumlahPendapatan
            // 
            numericJumlahPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericJumlahPendapatan.Location = new Point(26, 276);
            numericJumlahPendapatan.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericJumlahPendapatan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericJumlahPendapatan.Name = "numericJumlahPendapatan";
            numericJumlahPendapatan.Size = new Size(110, 31);
            numericJumlahPendapatan.TabIndex = 3;
            numericJumlahPendapatan.TextAlign = HorizontalAlignment.Center;
            numericJumlahPendapatan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJumlah.Location = new Point(26, 247);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(70, 25);
            lblJumlah.TabIndex = 17;
            lblJumlah.Text = "Jumlah";
            lblJumlah.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSavePendapatan
            // 
            btnSavePendapatan.BackColor = Color.FromArgb(0, 86, 179);
            btnSavePendapatan.FlatAppearance.BorderSize = 0;
            btnSavePendapatan.FlatStyle = FlatStyle.Flat;
            btnSavePendapatan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavePendapatan.ForeColor = Color.White;
            btnSavePendapatan.Location = new Point(192, 334);
            btnSavePendapatan.Name = "btnSavePendapatan";
            btnSavePendapatan.Size = new Size(122, 39);
            btnSavePendapatan.TabIndex = 4;
            btnSavePendapatan.Text = "Save";
            btnSavePendapatan.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPendapatan);
            tabControl1.Controls.Add(tabPengeluaran);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(21, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(349, 427);
            tabControl1.TabIndex = 19;
            // 
            // tabPendapatan
            // 
            tabPendapatan.Controls.Add(label7);
            tabPendapatan.Controls.Add(numericHargaPendapatan);
            tabPendapatan.Controls.Add(dtPendapatan);
            tabPendapatan.Controls.Add(btnSavePendapatan);
            tabPendapatan.Controls.Add(comboProduk);
            tabPendapatan.Controls.Add(lblJumlah);
            tabPendapatan.Controls.Add(label4);
            tabPendapatan.Controls.Add(numericJumlahPendapatan);
            tabPendapatan.Controls.Add(label2);
            tabPendapatan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabPendapatan.Location = new Point(4, 32);
            tabPendapatan.Name = "tabPendapatan";
            tabPendapatan.Padding = new Padding(3);
            tabPendapatan.Size = new Size(341, 391);
            tabPendapatan.TabIndex = 0;
            tabPendapatan.Text = "Pendapatan";
            tabPendapatan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 173);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 20;
            label7.Text = "Harga";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericHargaPendapatan
            // 
            numericHargaPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericHargaPendapatan.Location = new Point(26, 202);
            numericHargaPendapatan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericHargaPendapatan.Name = "numericHargaPendapatan";
            numericHargaPendapatan.Size = new Size(288, 31);
            numericHargaPendapatan.TabIndex = 2;
            numericHargaPendapatan.TextAlign = HorizontalAlignment.Center;
            numericHargaPendapatan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPengeluaran
            // 
            tabPengeluaran.Controls.Add(dtPengeluaran);
            tabPengeluaran.Controls.Add(btnSavePengeluaran);
            tabPengeluaran.Controls.Add(comboPengeluaran);
            tabPengeluaran.Controls.Add(label3);
            tabPengeluaran.Controls.Add(label5);
            tabPengeluaran.Controls.Add(numericPengeluaran);
            tabPengeluaran.Controls.Add(label6);
            tabPengeluaran.Location = new Point(4, 32);
            tabPengeluaran.Name = "tabPengeluaran";
            tabPengeluaran.Padding = new Padding(3);
            tabPengeluaran.Size = new Size(341, 391);
            tabPengeluaran.TabIndex = 1;
            tabPengeluaran.Text = "Pengeluaran";
            tabPengeluaran.UseVisualStyleBackColor = true;
            // 
            // dtPengeluaran
            // 
            dtPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtPengeluaran.Location = new Point(26, 54);
            dtPengeluaran.Name = "dtPengeluaran";
            dtPengeluaran.Size = new Size(288, 31);
            dtPengeluaran.TabIndex = 0;
            // 
            // btnSavePengeluaran
            // 
            btnSavePengeluaran.BackColor = Color.FromArgb(0, 86, 179);
            btnSavePengeluaran.FlatAppearance.BorderSize = 0;
            btnSavePengeluaran.FlatStyle = FlatStyle.Flat;
            btnSavePengeluaran.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavePengeluaran.ForeColor = Color.White;
            btnSavePengeluaran.Location = new Point(192, 282);
            btnSavePengeluaran.Name = "btnSavePengeluaran";
            btnSavePengeluaran.Size = new Size(122, 39);
            btnSavePengeluaran.TabIndex = 3;
            btnSavePengeluaran.Text = "Save";
            btnSavePengeluaran.UseVisualStyleBackColor = false;
            // 
            // comboPengeluaran
            // 
            comboPengeluaran.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboPengeluaran.FormattingEnabled = true;
            comboPengeluaran.Location = new Point(26, 133);
            comboPengeluaran.Name = "comboPengeluaran";
            comboPengeluaran.Size = new Size(288, 31);
            comboPengeluaran.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 183);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 24;
            label3.Text = "Biaya";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 24);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 21;
            label5.Text = "Tanggal";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericPengeluaran
            // 
            numericPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericPengeluaran.Location = new Point(26, 211);
            numericPengeluaran.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericPengeluaran.Name = "numericPengeluaran";
            numericPengeluaran.Size = new Size(288, 31);
            numericPengeluaran.TabIndex = 2;
            numericPengeluaran.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 105);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 22;
            label6.Text = "Pengeluaran";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InputTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 500);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "InputTransaksiForm";
            Text = "Input Transaksi";
            ((System.ComponentModel.ISupportInitialize)numericJumlahPendapatan).EndInit();
            tabControl1.ResumeLayout(false);
            tabPendapatan.ResumeLayout(false);
            tabPendapatan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericHargaPendapatan).EndInit();
            tabPengeluaran.ResumeLayout(false);
            tabPengeluaran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPengeluaran).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboProduk;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtPendapatan;
        private Label label4;
        private Label label2;
        private NumericUpDown numericJumlahPendapatan;
        private Label lblJumlah;
        private Button btnSavePendapatan;
        private TabControl tabControl1;
        private TabPage tabPendapatan;
        private TabPage tabPengeluaran;
        private DateTimePicker dtPengeluaran;
        private Button btnSavePengeluaran;
        private ComboBox comboPengeluaran;
        private Label label3;
        private Label label5;
        private NumericUpDown numericPengeluaran;
        private Label label6;
        private Label label7;
        private NumericUpDown numericHargaPendapatan;
    }
}