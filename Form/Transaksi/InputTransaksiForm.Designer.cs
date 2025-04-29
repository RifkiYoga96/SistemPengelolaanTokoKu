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
            comboPendapatan = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            dtTanggal = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            numericJumlahOrBiaya = new NumericUpDown();
            lblJumlah = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericJumlahOrBiaya).BeginInit();
            SuspendLayout();
            // 
            // comboPendapatan
            // 
            comboPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboPendapatan.FormattingEnabled = true;
            comboPendapatan.Location = new Point(40, 194);
            comboPendapatan.Name = "comboPendapatan";
            comboPendapatan.Size = new Size(288, 31);
            comboPendapatan.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
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
            panel1.Location = new Point(21, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 4);
            panel1.TabIndex = 7;
            // 
            // dtTanggal
            // 
            dtTanggal.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtTanggal.Location = new Point(40, 115);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(288, 31);
            dtTanggal.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 85);
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
            label2.Location = new Point(40, 166);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 15;
            label2.Text = "Pendapatan/Pengeluaran";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericJumlahOrBiaya
            // 
            numericJumlahOrBiaya.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericJumlahOrBiaya.Location = new Point(40, 272);
            numericJumlahOrBiaya.Name = "numericJumlahOrBiaya";
            numericJumlahOrBiaya.Size = new Size(288, 31);
            numericJumlahOrBiaya.TabIndex = 16;
            numericJumlahOrBiaya.TextAlign = HorizontalAlignment.Center;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJumlah.Location = new Point(40, 244);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(70, 25);
            lblJumlah.TabIndex = 17;
            lblJumlah.Text = "Jumlah";
            lblJumlah.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 86, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(206, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 39);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // InputTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 421);
            Controls.Add(btnSave);
            Controls.Add(lblJumlah);
            Controls.Add(numericJumlahOrBiaya);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(dtTanggal);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(comboPendapatan);
            Name = "InputTransaksiForm";
            Text = "Input Transaksi";
            ((System.ComponentModel.ISupportInitialize)numericJumlahOrBiaya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboPendapatan;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtTanggal;
        private Label label4;
        private Label label2;
        private NumericUpDown numericJumlahOrBiaya;
        private Label lblJumlah;
        private Button btnSave;
    }
}