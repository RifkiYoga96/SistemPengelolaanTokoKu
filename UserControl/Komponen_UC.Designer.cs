namespace Shopee
{
    partial class Komponen_UC
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
            panel1 = new Panel();
            lblPaginationInfo = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            lblPage = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            comboKeteranganStok = new ComboBox();
            txtSearch = new TextBox();
            btnAddData = new Button();
            label2 = new Label();
            menuStrip = new ContextMenuStrip(components);
            editMenuStrip = new ToolStripMenuItem();
            deleteMenuStrip = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblPaginationInfo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(lblPage);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(comboKeteranganStok);
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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1045, 434);
            dataGridView1.TabIndex = 2;
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
            // comboKeteranganStok
            // 
            comboKeteranganStok.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboKeteranganStok.FormattingEnabled = true;
            comboKeteranganStok.Location = new Point(300, 14);
            comboKeteranganStok.Name = "comboKeteranganStok";
            comboKeteranganStok.Size = new Size(213, 31);
            comboKeteranganStok.TabIndex = 4;
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
            label2.Location = new Point(968, 25);
            label2.Name = "label2";
            label2.Size = new Size(156, 35);
            label2.TabIndex = 6;
            label2.Text = "KOMPONEN";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { editMenuStrip, deleteMenuStrip });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(137, 64);
            // 
            // editMenuStrip
            // 
            editMenuStrip.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            editMenuStrip.Name = "editMenuStrip";
            editMenuStrip.Size = new Size(136, 30);
            editMenuStrip.Text = "Edit";
            // 
            // deleteMenuStrip
            // 
            deleteMenuStrip.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteMenuStrip.Name = "deleteMenuStrip";
            deleteMenuStrip.Size = new Size(136, 30);
            deleteMenuStrip.Text = "Delete";
            // 
            // Komponen_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAddData);
            Name = "Komponen_UC";
            Size = new Size(1157, 704);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAddData;
        private ComboBox comboKeteranganStok;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label2;
        private Label lblPage;
        private Button btnPrevious;
        private Button btnNext;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label lblPaginationInfo;
        private ContextMenuStrip menuStrip;
        private ToolStripMenuItem editMenuStrip;
        private ToolStripMenuItem deleteMenuStrip;
    }
}
