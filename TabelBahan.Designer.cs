namespace Shopee
{
    partial class TabelBahan
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
            txtIDBahan = new TextBox();
            panel2 = new Panel();
            btnNew = new Button();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNamaBahan = new TextBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // txtIDBahan
            // 
            txtIDBahan.Location = new Point(12, 46);
            txtIDBahan.Margin = new Padding(2);
            txtIDBahan.Name = "txtIDBahan";
            txtIDBahan.ReadOnly = true;
            txtIDBahan.Size = new Size(192, 23);
            txtIDBahan.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtStok);
            panel2.Controls.Add(txtHarga);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNamaBahan);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtIDBahan);
            panel2.Location = new Point(480, 38);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 304);
            panel2.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.Green;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(9, 274);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(67, 24);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(12, 184);
            txtStok.Margin = new Padding(2);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(192, 23);
            txtStok.TabIndex = 11;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(12, 140);
            txtHarga.Margin = new Padding(2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(192, 23);
            txtHarga.TabIndex = 10;
            txtHarga.KeyPress += txtHarga_KeyPress;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(80, 274);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 24);
            btnDelete.TabIndex = 9;
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
            btnSave.Location = new Point(151, 274);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 24);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Nama Bahan";
            // 
            // txtNamaBahan
            // 
            txtNamaBahan.Location = new Point(12, 93);
            txtNamaBahan.Margin = new Padding(2);
            txtNamaBahan.Name = "txtNamaBahan";
            txtNamaBahan.Size = new Size(192, 23);
            txtNamaBahan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "ID Bahan";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Dock = DockStyle.Top;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(709, 36);
            label5.TabIndex = 3;
            label5.Text = "Form Tabel Bahan";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabelBahan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 350);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "TabelBahan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TabelBahan";
            Load += TabelBahan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtIDBahan;
        private Panel panel2;
        private Label label2;
        private TextBox txtNamaBahan;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnDelete;
        private Button btnSave;
        private Label label5;
        private TextBox txtHarga;
        private TextBox txtStok;
        private Button btnNew;
    }
}