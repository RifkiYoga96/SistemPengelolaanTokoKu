namespace Shopee
{
    partial class TransaksiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiUC));
            panel1 = new Panel();
            lblPaginationInfo = new Label();
            panel2 = new Panel();
            lblPendapatan = new Label();
            dataGridView1 = new DataGridView();
            comboTotal = new ComboBox();
            comboSorting = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            lblPeriode = new Label();
            lblPage = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            comboTimeFilter = new ComboBox();
            txtSearch = new TextBox();
            btnAddData = new Button();
            label2 = new Label();
            menuStrip = new ContextMenuStrip(components);
            deleteMenuStrip = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblPaginationInfo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboSorting);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(lblPeriode);
            panel1.Controls.Add(lblPage);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(comboTimeFilter);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(29, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 592);
            panel1.TabIndex = 0;
            // 
            // lblPaginationInfo
            // 
            lblPaginationInfo.Anchor = AnchorStyles.Bottom;
            lblPaginationInfo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaginationInfo.Location = new Point(378, 538);
            lblPaginationInfo.Name = "lblPaginationInfo";
            lblPaginationInfo.Size = new Size(331, 25);
            lblPaginationInfo.TabIndex = 17;
            lblPaginationInfo.Text = "Showing 1 to 20 of 40 entries";
            lblPaginationInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblPendapatan);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(comboTotal);
            panel2.Location = new Point(25, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 433);
            panel2.TabIndex = 16;
            // 
            // lblPendapatan
            // 
            lblPendapatan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPendapatan.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendapatan.Location = new Point(520, 393);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(517, 35);
            lblPendapatan.TabIndex = 7;
            lblPendapatan.Text = "Rp18.200.500";
            lblPendapatan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1043, 383);
            dataGridView1.TabIndex = 2;
            // 
            // comboTotal
            // 
            comboTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboTotal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTotal.Font = new Font("Segoe UI", 13.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboTotal.FormattingEnabled = true;
            comboTotal.Location = new Point(3, 390);
            comboTotal.Name = "comboTotal";
            comboTotal.Size = new Size(376, 38);
            comboTotal.TabIndex = 15;
            // 
            // comboSorting
            // 
            comboSorting.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboSorting.FormattingEnabled = true;
            comboSorting.Location = new Point(524, 14);
            comboSorting.Name = "comboSorting";
            comboSorting.Size = new Size(176, 31);
            comboSorting.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(172, 537);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 13;
            label4.Text = "Entries";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 537);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 12;
            label3.Text = "Show";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(88, 535);
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(80, 31);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblPeriode
            // 
            lblPeriode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPeriode.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeriode.Location = new Point(739, 15);
            lblPeriode.Name = "lblPeriode";
            lblPeriode.Size = new Size(331, 25);
            lblPeriode.TabIndex = 5;
            lblPeriode.Text = "Periode : All time";
            lblPeriode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPage.BackColor = Color.FromArgb(0, 86, 179);
            lblPage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPage.ForeColor = Color.White;
            lblPage.Location = new Point(940, 531);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(63, 38);
            lblPage.TabIndex = 9;
            lblPage.Text = "1";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.BackColor = Color.White;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.Location = new Point(845, 531);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(98, 38);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(1000, 531);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 38);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // comboTimeFilter
            // 
            comboTimeFilter.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboTimeFilter.FormattingEnabled = true;
            comboTimeFilter.Location = new Point(300, 14);
            comboTimeFilter.Name = "comboTimeFilter";
            comboTimeFilter.Size = new Size(218, 31);
            comboTimeFilter.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(25, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  🔍Search product name";
            txtSearch.Size = new Size(268, 31);
            txtSearch.TabIndex = 3;
            // 
            // btnAddData
            // 
            btnAddData.BackColor = Color.FromArgb(0, 86, 179);
            btnAddData.FlatAppearance.BorderSize = 0;
            btnAddData.FlatStyle = FlatStyle.Flat;
            btnAddData.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddData.ForeColor = Color.White;
            btnAddData.Location = new Point(29, 24);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(146, 43);
            btnAddData.TabIndex = 1;
            btnAddData.Text = "➕ Add Data";
            btnAddData.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(951, 28);
            label2.Name = "label2";
            label2.Size = new Size(173, 35);
            label2.TabIndex = 6;
            label2.Text = "PENDAPATAN";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { deleteMenuStrip });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(215, 62);
            // 
            // deleteMenuStrip
            // 
            deleteMenuStrip.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteMenuStrip.Image = (Image)resources.GetObject("deleteMenuStrip.Image");
            deleteMenuStrip.Name = "deleteMenuStrip";
            deleteMenuStrip.Size = new Size(214, 30);
            deleteMenuStrip.Text = "Delete";
            // 
            // TransaksiUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAddData);
            Name = "TransaksiUC";
            Size = new Size(1157, 704);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAddData;
        private ComboBox comboTimeFilter;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label lblPeriode;
        private Label label2;
        private Label lblPage;
        private Button btnPrevious;
        private Button btnNext;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboSorting;
        private Panel panel2;
        private ComboBox comboTotal;
        private Label lblPendapatan;
        private Label lblPaginationInfo;
        private ContextMenuStrip menuStrip;
        private ToolStripMenuItem deleteMenuStrip;
    }
}
