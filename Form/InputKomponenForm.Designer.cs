namespace Shopee
{
    partial class InputKomponenForm
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
            labelHeader = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            lblJumlah = new Label();
            numericHarga = new NumericUpDown();
            txtNama = new TextBox();
            numericStok = new NumericUpDown();
            btnSave = new Button();
            numericStokMinimum = new NumericUpDown();
            label1 = new Label();
            comboSatuan = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStokMinimum).BeginInit();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top;
            labelHeader.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.Location = new Point(22, -3);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(330, 41);
            labelHeader.TabIndex = 6;
            labelHeader.Text = "Input Komponen";
            labelHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(21, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 4);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 69);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 14;
            label4.Text = "Nama";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 144);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 15;
            label2.Text = "Harga";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJumlah.Location = new Point(43, 221);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(48, 25);
            lblJumlah.TabIndex = 17;
            lblJumlah.Text = "Stok";
            lblJumlah.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericHarga
            // 
            numericHarga.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericHarga.Location = new Point(43, 172);
            numericHarga.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericHarga.Name = "numericHarga";
            numericHarga.Size = new Size(175, 31);
            numericHarga.TabIndex = 1;
            numericHarga.TextAlign = HorizontalAlignment.Center;
            numericHarga.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(43, 97);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(288, 31);
            txtNama.TabIndex = 0;
            // 
            // numericStok
            // 
            numericStok.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericStok.Location = new Point(43, 249);
            numericStok.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericStok.Name = "numericStok";
            numericStok.Size = new Size(135, 31);
            numericStok.TabIndex = 2;
            numericStok.TextAlign = HorizontalAlignment.Center;
            numericStok.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 86, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(209, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // numericStokMinimum
            // 
            numericStokMinimum.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericStokMinimum.Location = new Point(193, 249);
            numericStokMinimum.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericStokMinimum.Name = "numericStokMinimum";
            numericStokMinimum.Size = new Size(138, 31);
            numericStokMinimum.TabIndex = 3;
            numericStokMinimum.TextAlign = HorizontalAlignment.Center;
            numericStokMinimum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 221);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 24;
            label1.Text = "Stok Minimum";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboSatuan
            // 
            comboSatuan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboSatuan.FormattingEnabled = true;
            comboSatuan.Location = new Point(233, 172);
            comboSatuan.Name = "comboSatuan";
            comboSatuan.Size = new Size(98, 31);
            comboSatuan.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(233, 144);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 26;
            label3.Text = "Satuan";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InputKomponenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 405);
            Controls.Add(label3);
            Controls.Add(comboSatuan);
            Controls.Add(numericStokMinimum);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(numericStok);
            Controls.Add(txtNama);
            Controls.Add(numericHarga);
            Controls.Add(panel1);
            Controls.Add(labelHeader);
            Controls.Add(label2);
            Controls.Add(lblJumlah);
            Controls.Add(label4);
            Name = "InputKomponenForm";
            Text = "Input Transaksi";
            ((System.ComponentModel.ISupportInitialize)numericHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStokMinimum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboProduk;
        private Label labelHeader;
        private Panel panel1;
        private DateTimePicker dtPendapatan;
        private Label label4;
        private Label label2;
        private NumericUpDown numericJumlahPendapatan;
        private Label lblJumlah;
        private Button btnSave;
        private Label label7;
        private NumericUpDown numericHarga;
        private TextBox txtNama;
        private NumericUpDown numericStok;
        private NumericUpDown numericStokMinimum;
        private Label label1;
        private ComboBox comboSatuan;
        private Label label3;
    }
}