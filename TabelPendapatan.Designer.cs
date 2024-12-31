namespace Shopee
{
    partial class TabelPendapatan
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnNew = new Button();
            numericJumlah = new NumericUpDown();
            btnDelete = new Button();
            btnSave = new Button();
            label8 = new Label();
            txtBersih = new TextBox();
            label6 = new Label();
            txtModal = new TextBox();
            label5 = new Label();
            txtKotor = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txtProduk = new TextBox();
            label3 = new Label();
            label7 = new Label();
            txtPendapatan = new TextBox();
            label2 = new Label();
            comboJenisPendapatan = new ComboBox();
            lblTotalBersih = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label12 = new Label();
            comboBulan = new ComboBox();
            lblNoData = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericJumlah).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            label1.Size = new Size(958, 36);
            label1.TabIndex = 0;
            label1.Text = "Tabel Pendapatan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 65);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(722, 232);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(numericJumlah);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBersih);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtModal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtKotor);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(726, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 362);
            panel1.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.BackColor = Color.Green;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(9, 329);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(67, 24);
            btnNew.TabIndex = 17;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // numericJumlah
            // 
            numericJumlah.Location = new Point(13, 196);
            numericJumlah.Margin = new Padding(2);
            numericJumlah.Name = "numericJumlah";
            numericJumlah.Size = new Size(192, 23);
            numericJumlah.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(80, 329);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 24);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(151, 329);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 24);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 178);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 13;
            label8.Text = "Jumlah Produk";
            // 
            // txtBersih
            // 
            txtBersih.Location = new Point(13, 148);
            txtBersih.Margin = new Padding(2);
            txtBersih.Name = "txtBersih";
            txtBersih.Size = new Size(192, 23);
            txtBersih.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 132);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 8;
            label6.Text = "Pendapatan Bersih";
            // 
            // txtModal
            // 
            txtModal.Location = new Point(13, 100);
            txtModal.Margin = new Padding(2);
            txtModal.Name = "txtModal";
            txtModal.Size = new Size(192, 23);
            txtModal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 82);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Modal";
            // 
            // txtKotor
            // 
            txtKotor.Location = new Point(13, 52);
            txtKotor.Margin = new Padding(2);
            txtKotor.Name = "txtKotor";
            txtKotor.Size = new Size(192, 23);
            txtKotor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 36);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 4;
            label4.Text = "Pendapatan Kotor";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtProduk);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPendapatan);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 328);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 72);
            panel2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(364, 31);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtProduk
            // 
            txtProduk.Location = new Point(198, 31);
            txtProduk.Margin = new Padding(2);
            txtProduk.Name = "txtProduk";
            txtProduk.Size = new Size(135, 23);
            txtProduk.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "ID Produk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 11;
            label7.Text = "Tanggal Input";
            // 
            // txtPendapatan
            // 
            txtPendapatan.Location = new Point(30, 31);
            txtPendapatan.Margin = new Padding(2);
            txtPendapatan.Name = "txtPendapatan";
            txtPendapatan.Size = new Size(135, 23);
            txtPendapatan.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "ID Pendapatan";
            // 
            // comboJenisPendapatan
            // 
            comboJenisPendapatan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboJenisPendapatan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJenisPendapatan.FlatStyle = FlatStyle.Flat;
            comboJenisPendapatan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboJenisPendapatan.FormattingEnabled = true;
            comboJenisPendapatan.Location = new Point(1, 298);
            comboJenisPendapatan.Name = "comboJenisPendapatan";
            comboJenisPendapatan.Size = new Size(252, 29);
            comboJenisPendapatan.TabIndex = 13;
            // 
            // lblTotalBersih
            // 
            lblTotalBersih.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalBersih.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalBersih.Location = new Point(541, 300);
            lblTotalBersih.Margin = new Padding(2, 0, 2, 0);
            lblTotalBersih.Name = "lblTotalBersih";
            lblTotalBersih.Size = new Size(179, 25);
            lblTotalBersih.TabIndex = 1;
            lblTotalBersih.Text = "0.00";
            lblTotalBersih.TextAlign = ContentAlignment.MiddleRight;
            lblTotalBersih.Click += lblTotalBersih_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 40);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 19);
            label11.TabIndex = 5;
            label11.Text = "Filter :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(481, 39);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(156, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(220, 40);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 8;
            label10.Text = "Rentang :";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(293, 39);
            dateTimePicker3.Margin = new Padding(2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(156, 23);
            dateTimePicker3.TabIndex = 9;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(453, 39);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(24, 19);
            label12.TabIndex = 10;
            label12.Text = "To";
            // 
            // comboBulan
            // 
            comboBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBulan.FormattingEnabled = true;
            comboBulan.Location = new Point(60, 39);
            comboBulan.Margin = new Padding(2);
            comboBulan.Name = "comboBulan";
            comboBulan.Size = new Size(148, 23);
            comboBulan.TabIndex = 11;
            comboBulan.SelectedIndexChanged += comboBulan_SelectedIndexChanged;
            // 
            // lblNoData
            // 
            lblNoData.AutoSize = true;
            lblNoData.BackColor = SystemColors.ControlDark;
            lblNoData.Location = new Point(279, 170);
            lblNoData.Margin = new Padding(2, 0, 2, 0);
            lblNoData.Name = "lblNoData";
            lblNoData.Size = new Size(86, 15);
            lblNoData.TabIndex = 12;
            lblNoData.Text = "Tidak Ada Data";
            lblNoData.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(650, 38);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(63, 24);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // TabelPendapatan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(958, 401);
            Controls.Add(lblTotalBersih);
            Controls.Add(comboJenisPendapatan);
            Controls.Add(btnReset);
            Controls.Add(lblNoData);
            Controls.Add(comboBulan);
            Controls.Add(label12);
            Controls.Add(dateTimePicker3);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "TabelPendapatan";
            Text = "TabelPendapatan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericJumlah).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtIDPendapatan;
        private Label label4;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private TextBox txtBersih;
        private Label label6;
        private TextBox txtModal;
        private Label label5;
        private TextBox txtProduk;
        private Label label3;
        private TextBox txtPendapatan;
        private Label label2;
        private Button btnDelete;
        private Button btnSave;
        private Label lblTotalBersih;
        private NumericUpDown numericJumlah;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private Label label10;
        private TextBox txtKotor;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label12;
        private ComboBox comboBulan;
        private Label lblNoData;
        private Button btnNew;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ComboBox comboJenisPendapatan;
        private Button btnReset;
    }
}