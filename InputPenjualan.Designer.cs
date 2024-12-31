namespace Shopee
{
    partial class InputPenjualan
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
            comboBox1 = new ComboBox();
            btnInput = new Button();
            numericjmlh = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txtNamaProduk = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericjmlh).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 176);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 25);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // btnInput
            // 
            btnInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInput.BackColor = SystemColors.Highlight;
            btnInput.FlatStyle = FlatStyle.Flat;
            btnInput.Location = new Point(219, 299);
            btnInput.Margin = new Padding(1);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(94, 29);
            btnInput.TabIndex = 3;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            btnInput.KeyDown += btnInput_KeyDown;
            // 
            // numericjmlh
            // 
            numericjmlh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericjmlh.Location = new Point(50, 128);
            numericjmlh.Margin = new Padding(1);
            numericjmlh.Name = "numericjmlh";
            numericjmlh.Size = new Size(241, 25);
            numericjmlh.TabIndex = 1;
            numericjmlh.KeyDown += numericjmlh_KeyDown;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(50, 80);
            dateTimePicker1.Margin = new Padding(1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 25);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 61);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 20);
            label1.TabIndex = 6;
            label1.Text = "Dengan Stok Tersisa, Dapat Membuat:";
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.AutoSize = true;
            txtNamaProduk.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtNamaProduk.Location = new Point(20, 96);
            txtNamaProduk.Margin = new Padding(1, 0, 1, 0);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(131, 20);
            txtNamaProduk.TabIndex = 7;
            txtNamaProduk.Text = "Tidak Ada Produk";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNamaProduk);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 349);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Highlight;
            label3.Dock = DockStyle.Top;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(335, 35);
            label3.TabIndex = 7;
            label3.Text = "Stok Produk";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(50, 61);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Tanggal";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(numericjmlh);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(btnInput);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(338, 0);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 349);
            panel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(50, 160);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Produk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(50, 112);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 9;
            label5.Text = "Jumlah Produk";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Highlight;
            label4.Dock = DockStyle.Top;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(335, 35);
            label4.TabIndex = 8;
            label4.Text = "Input Pesanan";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputPenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 349);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(1);
            Name = "InputPenjualan";
            Text = "InputPenjualan";
            ((System.ComponentModel.ISupportInitialize)numericjmlh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnInput;
        private NumericUpDown numericjmlh;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label txtNamaProduk;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}