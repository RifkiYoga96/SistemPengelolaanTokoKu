namespace Shopee
{
    partial class GantiTokoForm
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
            btnSave = new Button();
            comboSatuan = new ComboBox();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top;
            labelHeader.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.Location = new Point(-22, -3);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(330, 41);
            labelHeader.TabIndex = 6;
            labelHeader.Text = "Ganti Toko";
            labelHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(21, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 4);
            panel1.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 86, 179);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(140, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Konfirmasi";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // comboSatuan
            // 
            comboSatuan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboSatuan.FormattingEnabled = true;
            comboSatuan.Location = new Point(34, 69);
            comboSatuan.Name = "comboSatuan";
            comboSatuan.Size = new Size(212, 31);
            comboSatuan.TabIndex = 2;
            // 
            // GantiTokoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(284, 196);
            Controls.Add(comboSatuan);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(labelHeader);
            Name = "GantiTokoForm";
            Text = "Input Transaksi";
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboProduk;
        private Label labelHeader;
        private Panel panel1;
        private DateTimePicker dtPendapatan;
        private NumericUpDown numericJumlahPendapatan;
        private Button btnSave;
        private Label label7;
        private ComboBox comboSatuan;
    }
}