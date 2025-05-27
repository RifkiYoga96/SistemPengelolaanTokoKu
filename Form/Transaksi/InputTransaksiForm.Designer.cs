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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputTransaksiForm));
            comboProdukPendapatan = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            dtPendapatan = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            numericJumlahPendapatan = new NumericUpDown();
            lblJumlah = new Label();
            tabControl1 = new TabControl();
            tabPendapatan = new TabPage();
            label8 = new Label();
            numericNominalDiskon = new NumericUpDown();
            btnAddPendapatan = new Button();
            btnSavePendapatan = new Button();
            gridPendapatan = new DataGridView();
            label7 = new Label();
            numericHargaPendapatan = new NumericUpDown();
            tabPengeluaran = new TabPage();
            btnAddPengeluaran = new Button();
            btnSavePengeluaran = new Button();
            gridPengeluaran = new DataGridView();
            label5 = new Label();
            numericHargaPengeluaran = new NumericUpDown();
            dtPengeluaran = new DateTimePicker();
            comboPengeluaran = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            numericJumlahPengeluaran = new NumericUpDown();
            label10 = new Label();
            menuStripPendapatan = new ContextMenuStrip(components);
            deletePendapatan = new ToolStripMenuItem();
            menuStripPengeluaran = new ContextMenuStrip(components);
            deletePengeluaran = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericJumlahPendapatan).BeginInit();
            tabControl1.SuspendLayout();
            tabPendapatan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericNominalDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPendapatan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHargaPendapatan).BeginInit();
            tabPengeluaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPengeluaran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHargaPengeluaran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericJumlahPengeluaran).BeginInit();
            menuStripPendapatan.SuspendLayout();
            menuStripPengeluaran.SuspendLayout();
            SuspendLayout();
            // 
            // comboProdukPendapatan
            // 
            comboProdukPendapatan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProdukPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboProdukPendapatan.FormattingEnabled = true;
            comboProdukPendapatan.Location = new Point(26, 128);
            comboProdukPendapatan.Name = "comboProdukPendapatan";
            comboProdukPendapatan.Size = new Size(254, 31);
            comboProdukPendapatan.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, -3);
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
            panel1.Location = new Point(21, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 4);
            panel1.TabIndex = 7;
            // 
            // dtPendapatan
            // 
            dtPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtPendapatan.Location = new Point(26, 53);
            dtPendapatan.Name = "dtPendapatan";
            dtPendapatan.Size = new Size(254, 31);
            dtPendapatan.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 24);
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
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 15;
            label2.Text = "Produk";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericJumlahPendapatan
            // 
            numericJumlahPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericJumlahPendapatan.Location = new Point(26, 276);
            numericJumlahPendapatan.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericJumlahPendapatan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericJumlahPendapatan.Name = "numericJumlahPendapatan";
            numericJumlahPendapatan.Size = new Size(110, 31);
            numericJumlahPendapatan.TabIndex = 3;
            numericJumlahPendapatan.TextAlign = HorizontalAlignment.Center;
            numericJumlahPendapatan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJumlah.Location = new Point(26, 247);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(70, 25);
            lblJumlah.TabIndex = 17;
            lblJumlah.Text = "Jumlah";
            lblJumlah.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPendapatan);
            tabControl1.Controls.Add(tabPengeluaran);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(21, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(661, 446);
            tabControl1.TabIndex = 19;
            // 
            // tabPendapatan
            // 
            tabPendapatan.Controls.Add(label8);
            tabPendapatan.Controls.Add(numericNominalDiskon);
            tabPendapatan.Controls.Add(btnAddPendapatan);
            tabPendapatan.Controls.Add(btnSavePendapatan);
            tabPendapatan.Controls.Add(gridPendapatan);
            tabPendapatan.Controls.Add(label7);
            tabPendapatan.Controls.Add(numericHargaPendapatan);
            tabPendapatan.Controls.Add(dtPendapatan);
            tabPendapatan.Controls.Add(comboProdukPendapatan);
            tabPendapatan.Controls.Add(lblJumlah);
            tabPendapatan.Controls.Add(label4);
            tabPendapatan.Controls.Add(numericJumlahPendapatan);
            tabPendapatan.Controls.Add(label2);
            tabPendapatan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabPendapatan.Location = new Point(4, 32);
            tabPendapatan.Name = "tabPendapatan";
            tabPendapatan.Padding = new Padding(3);
            tabPendapatan.Size = new Size(653, 410);
            tabPendapatan.TabIndex = 0;
            tabPendapatan.Text = "Pendapatan";
            tabPendapatan.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(309, 315);
            label8.Name = "label8";
            label8.Size = new Size(145, 25);
            label8.TabIndex = 30;
            label8.Text = "Nominal Diskon";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericNominalDiskon
            // 
            numericNominalDiskon.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericNominalDiskon.Location = new Point(309, 344);
            numericNominalDiskon.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericNominalDiskon.Name = "numericNominalDiskon";
            numericNominalDiskon.Size = new Size(213, 31);
            numericNominalDiskon.TabIndex = 29;
            numericNominalDiskon.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddPendapatan
            // 
            btnAddPendapatan.BackColor = Color.Coral;
            btnAddPendapatan.FlatAppearance.BorderSize = 0;
            btnAddPendapatan.FlatStyle = FlatStyle.Flat;
            btnAddPendapatan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPendapatan.ForeColor = Color.White;
            btnAddPendapatan.Location = new Point(158, 338);
            btnAddPendapatan.Name = "btnAddPendapatan";
            btnAddPendapatan.Size = new Size(122, 39);
            btnAddPendapatan.TabIndex = 28;
            btnAddPendapatan.Text = "Add";
            btnAddPendapatan.UseVisualStyleBackColor = false;
            // 
            // btnSavePendapatan
            // 
            btnSavePendapatan.BackColor = Color.FromArgb(0, 86, 179);
            btnSavePendapatan.FlatAppearance.BorderSize = 0;
            btnSavePendapatan.FlatStyle = FlatStyle.Flat;
            btnSavePendapatan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavePendapatan.ForeColor = Color.White;
            btnSavePendapatan.Location = new Point(25, 338);
            btnSavePendapatan.Name = "btnSavePendapatan";
            btnSavePendapatan.Size = new Size(122, 39);
            btnSavePendapatan.TabIndex = 27;
            btnSavePendapatan.Text = "Save";
            btnSavePendapatan.UseVisualStyleBackColor = false;
            // 
            // gridPendapatan
            // 
            gridPendapatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPendapatan.Location = new Point(309, 24);
            gridPendapatan.Name = "gridPendapatan";
            gridPendapatan.RowHeadersWidth = 51;
            gridPendapatan.RowTemplate.Height = 29;
            gridPendapatan.Size = new Size(323, 283);
            gridPendapatan.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 173);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 20;
            label7.Text = "Harga";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericHargaPendapatan
            // 
            numericHargaPendapatan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericHargaPendapatan.Location = new Point(26, 202);
            numericHargaPendapatan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericHargaPendapatan.Name = "numericHargaPendapatan";
            numericHargaPendapatan.Size = new Size(254, 31);
            numericHargaPendapatan.TabIndex = 2;
            numericHargaPendapatan.TextAlign = HorizontalAlignment.Center;
            numericHargaPendapatan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPengeluaran
            // 
            tabPengeluaran.Controls.Add(btnAddPengeluaran);
            tabPengeluaran.Controls.Add(btnSavePengeluaran);
            tabPengeluaran.Controls.Add(gridPengeluaran);
            tabPengeluaran.Controls.Add(label5);
            tabPengeluaran.Controls.Add(numericHargaPengeluaran);
            tabPengeluaran.Controls.Add(dtPengeluaran);
            tabPengeluaran.Controls.Add(comboPengeluaran);
            tabPengeluaran.Controls.Add(label6);
            tabPengeluaran.Controls.Add(label9);
            tabPengeluaran.Controls.Add(numericJumlahPengeluaran);
            tabPengeluaran.Controls.Add(label10);
            tabPengeluaran.Location = new Point(4, 32);
            tabPengeluaran.Name = "tabPengeluaran";
            tabPengeluaran.Padding = new Padding(3);
            tabPengeluaran.Size = new Size(653, 410);
            tabPengeluaran.TabIndex = 1;
            tabPengeluaran.Text = "Pengeluaran";
            tabPengeluaran.UseVisualStyleBackColor = true;
            // 
            // btnAddPengeluaran
            // 
            btnAddPengeluaran.BackColor = Color.Coral;
            btnAddPengeluaran.FlatAppearance.BorderSize = 0;
            btnAddPengeluaran.FlatStyle = FlatStyle.Flat;
            btnAddPengeluaran.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPengeluaran.ForeColor = Color.White;
            btnAddPengeluaran.Location = new Point(156, 343);
            btnAddPengeluaran.Name = "btnAddPengeluaran";
            btnAddPengeluaran.Size = new Size(122, 39);
            btnAddPengeluaran.TabIndex = 41;
            btnAddPengeluaran.Text = "Add";
            btnAddPengeluaran.UseVisualStyleBackColor = false;
            // 
            // btnSavePengeluaran
            // 
            btnSavePengeluaran.BackColor = Color.FromArgb(0, 86, 179);
            btnSavePengeluaran.FlatAppearance.BorderSize = 0;
            btnSavePengeluaran.FlatStyle = FlatStyle.Flat;
            btnSavePengeluaran.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavePengeluaran.ForeColor = Color.White;
            btnSavePengeluaran.Location = new Point(23, 343);
            btnSavePengeluaran.Name = "btnSavePengeluaran";
            btnSavePengeluaran.Size = new Size(122, 39);
            btnSavePengeluaran.TabIndex = 40;
            btnSavePengeluaran.Text = "Save";
            btnSavePengeluaran.UseVisualStyleBackColor = false;
            // 
            // gridPengeluaran
            // 
            gridPengeluaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPengeluaran.Location = new Point(305, 29);
            gridPengeluaran.Name = "gridPengeluaran";
            gridPengeluaran.RowHeadersWidth = 51;
            gridPengeluaran.RowTemplate.Height = 29;
            gridPengeluaran.Size = new Size(321, 353);
            gridPengeluaran.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 178);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 39;
            label5.Text = "Harga";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericHargaPengeluaran
            // 
            numericHargaPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericHargaPengeluaran.Location = new Point(24, 207);
            numericHargaPengeluaran.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericHargaPengeluaran.Name = "numericHargaPengeluaran";
            numericHargaPengeluaran.Size = new Size(254, 31);
            numericHargaPengeluaran.TabIndex = 33;
            numericHargaPengeluaran.TextAlign = HorizontalAlignment.Center;
            numericHargaPengeluaran.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtPengeluaran
            // 
            dtPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtPengeluaran.Location = new Point(24, 58);
            dtPengeluaran.Name = "dtPengeluaran";
            dtPengeluaran.Size = new Size(254, 31);
            dtPengeluaran.TabIndex = 31;
            // 
            // comboPengeluaran
            // 
            comboPengeluaran.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboPengeluaran.FormattingEnabled = true;
            comboPengeluaran.Location = new Point(24, 133);
            comboPengeluaran.Name = "comboPengeluaran";
            comboPengeluaran.Size = new Size(254, 31);
            comboPengeluaran.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 252);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 37;
            label6.Text = "Jumlah";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 29);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 35;
            label9.Text = "Tanggal";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericJumlahPengeluaran
            // 
            numericJumlahPengeluaran.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            numericJumlahPengeluaran.Location = new Point(24, 281);
            numericJumlahPengeluaran.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericJumlahPengeluaran.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericJumlahPengeluaran.Name = "numericJumlahPengeluaran";
            numericJumlahPengeluaran.Size = new Size(110, 31);
            numericJumlahPengeluaran.TabIndex = 34;
            numericJumlahPengeluaran.TextAlign = HorizontalAlignment.Center;
            numericJumlahPengeluaran.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(24, 104);
            label10.Name = "label10";
            label10.Size = new Size(116, 25);
            label10.TabIndex = 36;
            label10.Text = "Pengeluaran";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStripPendapatan
            // 
            menuStripPendapatan.ImageScalingSize = new Size(20, 20);
            menuStripPendapatan.Items.AddRange(new ToolStripItem[] { deletePendapatan });
            menuStripPendapatan.Name = "menuStrip";
            menuStripPendapatan.Size = new Size(215, 62);
            // 
            // deletePendapatan
            // 
            deletePendapatan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deletePendapatan.Image = (Image)resources.GetObject("deletePendapatan.Image");
            deletePendapatan.Name = "deletePendapatan";
            deletePendapatan.Size = new Size(214, 30);
            deletePendapatan.Text = "Delete";
            // 
            // menuStripPengeluaran
            // 
            menuStripPengeluaran.ImageScalingSize = new Size(20, 20);
            menuStripPengeluaran.Items.AddRange(new ToolStripItem[] { deletePengeluaran });
            menuStripPengeluaran.Name = "menuStrip";
            menuStripPengeluaran.Size = new Size(141, 34);
            // 
            // deletePengeluaran
            // 
            deletePengeluaran.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deletePengeluaran.Image = (Image)resources.GetObject("deletePengeluaran.Image");
            deletePengeluaran.Name = "deletePengeluaran";
            deletePengeluaran.Size = new Size(140, 30);
            deletePengeluaran.Text = "Delete";
            // 
            // InputTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(694, 521);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "InputTransaksiForm";
            Text = "Input Transaksi";
            ((System.ComponentModel.ISupportInitialize)numericJumlahPendapatan).EndInit();
            tabControl1.ResumeLayout(false);
            tabPendapatan.ResumeLayout(false);
            tabPendapatan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericNominalDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPendapatan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHargaPendapatan).EndInit();
            tabPengeluaran.ResumeLayout(false);
            tabPengeluaran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPengeluaran).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHargaPengeluaran).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericJumlahPengeluaran).EndInit();
            menuStripPendapatan.ResumeLayout(false);
            menuStripPengeluaran.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboProdukPendapatan;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtPendapatan;
        private Label label4;
        private Label label2;
        private NumericUpDown numericJumlahPendapatan;
        private Label lblJumlah;
        private TabControl tabControl1;
        private TabPage tabPendapatan;
        private TabPage tabPengeluaran;
        private Label label7;
        private NumericUpDown numericHargaPendapatan;
        private DataGridView gridPendapatan;
        private Button btnAddPendapatan;
        private Button btnSavePendapatan;
        private Label label8;
        private NumericUpDown numericNominalDiskon;
        private Button btnAddPengeluaran;
        private Button btnSavePengeluaran;
        private DataGridView gridPengeluaran;
        private Label label5;
        private NumericUpDown numericHargaPengeluaran;
        private DateTimePicker dtPengeluaran;
        private ComboBox comboPengeluaran;
        private Label label6;
        private Label label9;
        private NumericUpDown numericJumlahPengeluaran;
        private Label label10;
        private ContextMenuStrip menuStripPendapatan;
        private ToolStripMenuItem deletePendapatan;
        private ContextMenuStrip menuStripPengeluaran;
        private ToolStripMenuItem deletePengeluaran;
    }
}