namespace Shopee
{
    partial class TabelProduk
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtHarga = new TextBox();
            label4 = new Label();
            txtNamaProduk = new TextBox();
            label3 = new Label();
            txtIDProduk = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(710, 36);
            label1.TabIndex = 0;
            label1.Text = "Tabel Produk";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 38);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(476, 304);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtHarga);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNamaProduk);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtIDProduk);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(480, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 304);
            panel1.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.Green;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(10, 271);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(67, 24);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(81, 271);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 24);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(152, 271);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 24);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(13, 140);
            txtHarga.Margin = new Padding(2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(192, 23);
            txtHarga.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 124);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Harga";
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(13, 96);
            txtNamaProduk.Margin = new Padding(2);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(192, 23);
            txtNamaProduk.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Produk";
            // 
            // txtIDProduk
            // 
            txtIDProduk.Location = new Point(13, 51);
            txtIDProduk.Margin = new Padding(2);
            txtIDProduk.Name = "txtIDProduk";
            txtIDProduk.Size = new Size(192, 23);
            txtIDProduk.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "ID Produk";
            // 
            // TabelProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 350);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "TabelProduk";
            Text = "TabelProduk";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Button btnSave;
        private TextBox txtHarga;
        private Label label4;
        private TextBox txtNamaProduk;
        private Label label3;
        private TextBox txtIDProduk;
        private Label label2;
        private Button btnDelete;
        private Button btnNew;
    }
}