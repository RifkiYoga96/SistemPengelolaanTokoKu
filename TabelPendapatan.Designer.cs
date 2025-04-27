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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 38);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(825, 303);
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
            panel1.Location = new Point(833, 2);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 477);
            panel1.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.BackColor = Color.Green;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(10, 433);
            btnNew.Margin = new Padding(2, 3, 2, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(77, 32);
            btnNew.TabIndex = 17;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // numericJumlah
            // 
            numericJumlah.Location = new Point(15, 261);
            numericJumlah.Margin = new Padding(2, 3, 2, 3);
            numericJumlah.Name = "numericJumlah";
            numericJumlah.Size = new Size(219, 27);
            numericJumlah.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(91, 433);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 32);
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
            btnSave.Location = new Point(173, 433);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 32);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 237);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 13;
            label8.Text = "Jumlah Produk";
            // 
            // txtBersih
            // 
            txtBersih.Location = new Point(15, 197);
            txtBersih.Margin = new Padding(2, 3, 2, 3);
            txtBersih.Name = "txtBersih";
            txtBersih.Size = new Size(219, 27);
            txtBersih.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 176);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 8;
            label6.Text = "Pendapatan Bersih";
            // 
            // txtModal
            // 
            txtModal.Location = new Point(15, 133);
            txtModal.Margin = new Padding(2, 3, 2, 3);
            txtModal.Name = "txtModal";
            txtModal.Size = new Size(219, 27);
            txtModal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 109);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 6;
            label5.Text = "Modal";
            // 
            // txtKotor
            // 
            txtKotor.Location = new Point(15, 69);
            txtKotor.Margin = new Padding(2, 3, 2, 3);
            txtKotor.Name = "txtKotor";
            txtKotor.Size = new Size(219, 27);
            txtKotor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 48);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
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
            panel2.Location = new Point(3, 382);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 96);
            panel2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(416, 41);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtProduk
            // 
            txtProduk.Location = new Point(226, 41);
            txtProduk.Margin = new Padding(2, 3, 2, 3);
            txtProduk.Name = "txtProduk";
            txtProduk.Size = new Size(154, 27);
            txtProduk.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "ID Produk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 13);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 11;
            label7.Text = "Tanggal Input";
            // 
            // txtPendapatan
            // 
            txtPendapatan.Location = new Point(34, 41);
            txtPendapatan.Margin = new Padding(2, 3, 2, 3);
            txtPendapatan.Name = "txtPendapatan";
            txtPendapatan.Size = new Size(154, 27);
            txtPendapatan.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "ID Pendapatan";
            // 
            // comboJenisPendapatan
            // 
            comboJenisPendapatan.Anchor = AnchorStyles.Left;
            comboJenisPendapatan.FlatStyle = FlatStyle.Flat;
            comboJenisPendapatan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboJenisPendapatan.FormattingEnabled = true;
            comboJenisPendapatan.Location = new Point(4, 342);
            comboJenisPendapatan.Margin = new Padding(3, 4, 3, 4);
            comboJenisPendapatan.Name = "comboJenisPendapatan";
            comboJenisPendapatan.Size = new Size(287, 36);
            comboJenisPendapatan.TabIndex = 13;
            comboJenisPendapatan.SelectedIndexChanged += comboJenisPendapatan_SelectedIndexChanged;
            // 
            // lblTotalBersih
            // 
            lblTotalBersih.Anchor = AnchorStyles.Right;
            lblTotalBersih.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalBersih.Location = new Point(621, 345);
            lblTotalBersih.Margin = new Padding(2, 0, 2, 0);
            lblTotalBersih.Name = "lblTotalBersih";
            lblTotalBersih.Size = new Size(205, 33);
            lblTotalBersih.TabIndex = 1;
            lblTotalBersih.Text = "0.00";
            lblTotalBersih.TextAlign = ContentAlignment.MiddleRight;
            lblTotalBersih.Click += lblTotalBersih_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(13, 4);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 23);
            label11.TabIndex = 5;
            label11.Text = "Filter :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(553, 3);
            dateTimePicker2.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(178, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(254, 4);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 23);
            label10.TabIndex = 8;
            label10.Text = "Rentang :";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(338, 3);
            dateTimePicker3.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(178, 27);
            dateTimePicker3.TabIndex = 9;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(521, 3);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(27, 23);
            label12.TabIndex = 10;
            label12.Text = "To";
            // 
            // comboBulan
            // 
            comboBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBulan.FormattingEnabled = true;
            comboBulan.Location = new Point(72, 3);
            comboBulan.Margin = new Padding(2, 3, 2, 3);
            comboBulan.Name = "comboBulan";
            comboBulan.Size = new Size(169, 28);
            comboBulan.TabIndex = 11;
            comboBulan.SelectedIndexChanged += comboBulan_SelectedIndexChanged;
            // 
            // lblNoData
            // 
            lblNoData.AutoSize = true;
            lblNoData.BackColor = SystemColors.ControlDark;
            lblNoData.Location = new Point(322, 178);
            lblNoData.Margin = new Padding(2, 0, 2, 0);
            lblNoData.Name = "lblNoData";
            lblNoData.Size = new Size(112, 20);
            lblNoData.TabIndex = 12;
            lblNoData.Text = "Tidak Ada Data";
            lblNoData.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 52);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(746, 2);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(72, 32);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // TabelPendapatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1095, 482);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
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