namespace Shopee
{
    partial class TabelKebutuhan
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            comboBahan = new ComboBox();
            comboProduk = new ComboBox();
            btnNew = new Button();
            button2 = new Button();
            btnSave = new Button();
            label5 = new Label();
            numericJumlah = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            txtIDKebutuhan = new TextBox();
            label2 = new Label();
            inputSemua = new CheckBox();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            txtfilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericJumlah).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 66);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(560, 217);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(793, 36);
            label1.TabIndex = 1;
            label1.Text = "Form Tabel Kebutuhan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBahan);
            panel1.Controls.Add(comboProduk);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericJumlah);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtIDKebutuhan);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(564, 37);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 304);
            panel1.TabIndex = 2;
            // 
            // comboBahan
            // 
            comboBahan.FormattingEnabled = true;
            comboBahan.Location = new Point(13, 134);
            comboBahan.Name = "comboBahan";
            comboBahan.Size = new Size(192, 23);
            comboBahan.TabIndex = 12;
            // 
            // comboProduk
            // 
            comboProduk.FormattingEnabled = true;
            comboProduk.Location = new Point(13, 91);
            comboProduk.Name = "comboProduk";
            comboProduk.Size = new Size(192, 23);
            comboProduk.TabIndex = 11;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.Green;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(11, 270);
            btnNew.Margin = new Padding(1);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(67, 24);
            btnNew.TabIndex = 10;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(82, 270);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(67, 24);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(153, 270);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 24);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 163);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Jumlah";
            // 
            // numericJumlah
            // 
            numericJumlah.Location = new Point(13, 180);
            numericJumlah.Margin = new Padding(1);
            numericJumlah.Name = "numericJumlah";
            numericJumlah.Size = new Size(192, 23);
            numericJumlah.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 118);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Bahan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 73);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Produk";
            // 
            // txtIDKebutuhan
            // 
            txtIDKebutuhan.Location = new Point(13, 46);
            txtIDKebutuhan.Margin = new Padding(1);
            txtIDKebutuhan.Name = "txtIDKebutuhan";
            txtIDKebutuhan.Size = new Size(192, 23);
            txtIDKebutuhan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 29);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "ID Kebutuhan";
            // 
            // inputSemua
            // 
            inputSemua.AutoSize = true;
            inputSemua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            inputSemua.Location = new Point(206, 19);
            inputSemua.Margin = new Padding(1);
            inputSemua.Name = "inputSemua";
            inputSemua.Size = new Size(135, 19);
            inputSemua.TabIndex = 1;
            inputSemua.Text = "Input Banyak Bahan";
            inputSemua.UseVisualStyleBackColor = true;
            inputSemua.CheckedChanged += inputSemua_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(inputSemua);
            panel2.Location = new Point(0, 287);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 55);
            panel2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 20);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(375, 19);
            linkLabel1.Margin = new Padding(1, 0, 1, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(164, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Klik Untuk Pilih Banyak Bahan\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 41);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 4;
            label6.Text = "Filter :";
            // 
            // txtfilter
            // 
            txtfilter.Location = new Point(69, 41);
            txtfilter.Margin = new Padding(3, 2, 3, 2);
            txtfilter.Name = "txtfilter";
            txtfilter.PlaceholderText = " Nama Produk dan Nama Bahan";
            txtfilter.Size = new Size(194, 23);
            txtfilter.TabIndex = 5;
            txtfilter.TextChanged += textBox1_TextChanged;
            // 
            // TabelKebutuhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(793, 349);
            Controls.Add(txtfilter);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(1);
            Name = "TabelKebutuhan";
            Text = "TabelKebutuhan";
            Load += TabelKebutuhan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericJumlah).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private TextBox txtIDKebutuhan;
        private Label label2;
        private Button btnSave;
        private Label label5;
        private NumericUpDown numericJumlah;
        private TextBox txtIDBahan;
        private Label label4;
        private TextBox txtIDProduk;
        private Label label3;
        private Button button2;
        private CheckBox inputSemua;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox txtfilter;
        private Button btnNew;
        private ComboBox comboProduk;
        private ComboBox comboBahan;
    }
}