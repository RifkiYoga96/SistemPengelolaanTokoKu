namespace Shopee
{
    partial class KomponenProduk
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
            panel1 = new Panel();
            label1 = new Label();
            DaftarGrid = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            KebutuhanGrid = new DataGridView();
            comboProduk = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editModeTool = new ToolStripMenuItem();
            normalModeTool = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DaftarGrid).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KebutuhanGrid).BeginInit();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DaftarGrid);
            panel1.Location = new Point(250, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 426);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 33);
            label1.TabIndex = 1;
            label1.Text = "Daftar Komponen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DaftarGrid
            // 
            DaftarGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaftarGrid.GridColor = SystemColors.ControlDarkDark;
            DaftarGrid.Location = new Point(8, 41);
            DaftarGrid.Name = "DaftarGrid";
            DaftarGrid.RowTemplate.Height = 25;
            DaftarGrid.Size = new Size(344, 375);
            DaftarGrid.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(KebutuhanGrid);
            panel2.Location = new Point(627, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 426);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(360, 33);
            label2.TabIndex = 1;
            label2.Text = "Kebutuhan Komponen";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KebutuhanGrid
            // 
            KebutuhanGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KebutuhanGrid.GridColor = SystemColors.ControlDarkDark;
            KebutuhanGrid.Location = new Point(8, 41);
            KebutuhanGrid.Name = "KebutuhanGrid";
            KebutuhanGrid.RowTemplate.Height = 25;
            KebutuhanGrid.Size = new Size(344, 375);
            KebutuhanGrid.TabIndex = 0;
            // 
            // comboProduk
            // 
            comboProduk.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProduk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboProduk.FormattingEnabled = true;
            comboProduk.Location = new Point(20, 38);
            comboProduk.Name = "comboProduk";
            comboProduk.Size = new Size(180, 23);
            comboProduk.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 17);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 1;
            label3.Text = "Produk";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboProduk);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 426);
            panel3.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(134, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editModeTool, normalModeTool });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // editModeTool
            // 
            editModeTool.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editModeTool.Name = "editModeTool";
            editModeTool.Size = new Size(180, 22);
            editModeTool.Text = "Edit Mode ✔";
            // 
            // normalModeTool
            // 
            normalModeTool.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            normalModeTool.Name = "normalModeTool";
            normalModeTool.Size = new Size(180, 22);
            normalModeTool.Text = "Normal Mode";
            // 
            // KomponenProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KomponenProduk";
            Text = "Komponen Produk";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DaftarGrid).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KebutuhanGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DaftarGrid;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView KebutuhanGrid;
        private ComboBox comboProduk;
        private Label label3;
        private Panel panel3;
        private Button btnSave;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editModeTool;
        private ToolStripMenuItem normalModeTool;
    }
}