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
            panel3 = new Panel();
            label4 = new Label();
            txtTotalHarga = new TextBox();
            btnSave = new Button();
            label3 = new Label();
            comboProduk = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            KebutuhanGrid = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            DaftarGrid = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editModeTool = new ToolStripMenuItem();
            normalModeTool = new ToolStripMenuItem();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KebutuhanGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DaftarGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTotalHarga);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboProduk);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 10, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 557);
            panel3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 121);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 5;
            label4.Text = "Total Harga";
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalHarga.Location = new Point(23, 149);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.ReadOnly = true;
            txtTotalHarga.Size = new Size(258, 31);
            txtTotalHarga.TabIndex = 4;
            txtTotalHarga.Text = "Rp.400.000";
            txtTotalHarga.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(212, 510);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 23);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 1;
            label3.Text = "Produk";
            // 
            // comboProduk
            // 
            comboProduk.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProduk.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            comboProduk.FormattingEnabled = true;
            comboProduk.Location = new Point(23, 51);
            comboProduk.Margin = new Padding(3, 4, 3, 4);
            comboProduk.Name = "comboProduk";
            comboProduk.Size = new Size(258, 31);
            comboProduk.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Location = new Point(17, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1090, 565);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(KebutuhanGrid);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(715, 4);
            panel2.Margin = new Padding(10, 4, 10, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 557);
            panel2.TabIndex = 7;
            // 
            // KebutuhanGrid
            // 
            KebutuhanGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KebutuhanGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KebutuhanGrid.GridColor = SystemColors.ControlDarkDark;
            KebutuhanGrid.Location = new Point(9, 55);
            KebutuhanGrid.Margin = new Padding(3, 4, 3, 4);
            KebutuhanGrid.Name = "KebutuhanGrid";
            KebutuhanGrid.RowHeadersWidth = 51;
            KebutuhanGrid.RowTemplate.Height = 25;
            KebutuhanGrid.Size = new Size(345, 494);
            KebutuhanGrid.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(363, 44);
            label2.TabIndex = 1;
            label2.Text = "Komponen Digunakan";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DaftarGrid);
            panel1.Location = new Point(330, 4);
            panel1.Margin = new Padding(10, 4, 10, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 557);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 44);
            label1.TabIndex = 1;
            label1.Text = "Daftar Komponen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DaftarGrid
            // 
            DaftarGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DaftarGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaftarGrid.GridColor = SystemColors.ControlDarkDark;
            DaftarGrid.Location = new Point(9, 55);
            DaftarGrid.Margin = new Padding(3, 4, 3, 4);
            DaftarGrid.Name = "DaftarGrid";
            DaftarGrid.RowHeadersWidth = 51;
            DaftarGrid.RowTemplate.Height = 25;
            DaftarGrid.Size = new Size(345, 494);
            DaftarGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editModeTool, normalModeTool });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(175, 52);
            // 
            // editModeTool
            // 
            editModeTool.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editModeTool.Name = "editModeTool";
            editModeTool.Size = new Size(174, 24);
            editModeTool.Text = "Edit Mode ✔";
            // 
            // normalModeTool
            // 
            normalModeTool.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            normalModeTool.Name = "normalModeTool";
            normalModeTool.Size = new Size(174, 24);
            normalModeTool.Text = "Normal Mode";
            // 
            // Komponen_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Komponen_UC";
            Size = new Size(1124, 597);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KebutuhanGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DaftarGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label4;
        private TextBox txtTotalHarga;
        private Button btnSave;
        private Label label3;
        private ComboBox comboProduk;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private DataGridView DaftarGrid;
        private Panel panel2;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editModeTool;
        private ToolStripMenuItem normalModeTool;
        private DataGridView KebutuhanGrid;
    }
}
