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
            ((System.ComponentModel.ISupportInitialize)numericHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).BeginInit();
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
            numericHarga.Size = new Size(288, 31);
            numericHarga.TabIndex = 19;
            numericHarga.TextAlign = HorizontalAlignment.Center;
            numericHarga.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(43, 97);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(288, 31);
            txtNama.TabIndex = 21;
            // 
            // numericStok
            // 
            numericStok.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericStok.Location = new Point(43, 249);
            numericStok.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericStok.Name = "numericStok";
            numericStok.Size = new Size(105, 31);
            numericStok.TabIndex = 22;
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
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // InputKomponenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 405);
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
    }
}