namespace Shopee
{
    partial class Dashboard_UC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            lblPendapatanBersih = new Label();
            label10 = new Label();
            panel5 = new Panel();
            lblPendapatanKotor = new Label();
            label8 = new Label();
            panel4 = new Panel();
            lblProdukTerjual = new Label();
            label5 = new Label();
            panel1 = new Panel();
            comboRangeTime = new ComboBox();
            panel2 = new Panel();
            label11 = new Label();
            numericAdmin = new NumericUpDown();
            label4 = new Label();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            gridProdukProfit = new DataGridView();
            label3 = new Label();
            panel7 = new Panel();
            gridProdukTerjual = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAdmin).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdukProfit).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdukTerjual).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Location = new Point(33, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1068, 154);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.YellowGreen;
            panel6.Controls.Add(lblPendapatanBersih);
            panel6.Controls.Add(label10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(712, 0);
            panel6.Margin = new Padding(0, 0, 25, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(331, 154);
            panel6.TabIndex = 5;
            // 
            // lblPendapatanBersih
            // 
            lblPendapatanBersih.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPendapatanBersih.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendapatanBersih.Location = new Point(2, 62);
            lblPendapatanBersih.Name = "lblPendapatanBersih";
            lblPendapatanBersih.Size = new Size(326, 50);
            lblPendapatanBersih.TabIndex = 11;
            lblPendapatanBersih.Text = "Rp12.450.000";
            lblPendapatanBersih.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(17, 13);
            label10.Name = "label10";
            label10.Size = new Size(209, 28);
            label10.TabIndex = 11;
            label10.Text = "PENDAPATAN BERSIH";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Controls.Add(lblPendapatanKotor);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(356, 0);
            panel5.Margin = new Padding(0, 0, 25, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 154);
            panel5.TabIndex = 4;
            // 
            // lblPendapatanKotor
            // 
            lblPendapatanKotor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPendapatanKotor.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendapatanKotor.Location = new Point(3, 62);
            lblPendapatanKotor.Name = "lblPendapatanKotor";
            lblPendapatanKotor.Size = new Size(326, 50);
            lblPendapatanKotor.TabIndex = 11;
            lblPendapatanKotor.Text = "Rp21.230.000";
            lblPendapatanKotor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 13);
            label8.Name = "label8";
            label8.Size = new Size(205, 28);
            label8.TabIndex = 11;
            label8.Text = "PENDAPATAN KOTOR";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightBlue;
            panel4.Controls.Add(lblProdukTerjual);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0, 0, 25, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 154);
            panel4.TabIndex = 3;
            // 
            // lblProdukTerjual
            // 
            lblProdukTerjual.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblProdukTerjual.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblProdukTerjual.Location = new Point(2, 62);
            lblProdukTerjual.Name = "lblProdukTerjual";
            lblProdukTerjual.Size = new Size(326, 50);
            lblProdukTerjual.TabIndex = 11;
            lblProdukTerjual.Text = "30";
            lblProdukTerjual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 13);
            label5.Name = "label5";
            label5.Size = new Size(176, 28);
            label5.TabIndex = 11;
            label5.Text = "PRODUK TERJUAL";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(61, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 224);
            panel1.TabIndex = 1;
            // 
            // comboRangeTime
            // 
            comboRangeTime.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboRangeTime.FormattingEnabled = true;
            comboRangeTime.Location = new Point(61, 14);
            comboRangeTime.Name = "comboRangeTime";
            comboRangeTime.Size = new Size(221, 31);
            comboRangeTime.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(numericAdmin);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(61, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 115);
            panel2.TabIndex = 2;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(124, 56);
            label11.Name = "label11";
            label11.Size = new Size(29, 28);
            label11.TabIndex = 15;
            label11.Text = "%";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericAdmin
            // 
            numericAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericAdmin.Location = new Point(27, 56);
            numericAdmin.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericAdmin.Name = "numericAdmin";
            numericAdmin.Size = new Size(92, 31);
            numericAdmin.TabIndex = 14;
            numericAdmin.TextAlign = HorizontalAlignment.Center;
            numericAdmin.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 11);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 10;
            label4.Text = "ADMIN";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Location = new Point(61, 448);
            panel3.Name = "panel3";
            panel3.Size = new Size(1113, 215);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel8, 1, 0);
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1066, 173);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(gridProdukProfit);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(536, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(527, 167);
            panel8.TabIndex = 9;
            // 
            // gridProdukProfit
            // 
            gridProdukProfit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridProdukProfit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdukProfit.Location = new Point(10, 38);
            gridProdukProfit.Name = "gridProdukProfit";
            gridProdukProfit.RowHeadersWidth = 51;
            gridProdukProfit.RowTemplate.Height = 29;
            gridProdukProfit.Size = new Size(490, 126);
            gridProdukProfit.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 30);
            label3.TabIndex = 8;
            label3.Text = "TOP PRODUK PROFIT";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(gridProdukTerjual);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(527, 167);
            panel7.TabIndex = 8;
            // 
            // gridProdukTerjual
            // 
            gridProdukTerjual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridProdukTerjual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdukTerjual.Location = new Point(10, 38);
            gridProdukTerjual.Name = "gridProdukTerjual";
            gridProdukTerjual.RowHeadersWidth = 51;
            gridProdukTerjual.RowTemplate.Height = 29;
            gridProdukTerjual.Size = new Size(476, 126);
            gridProdukTerjual.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);
            label1.TabIndex = 8;
            label1.Text = "TOP PRODUK TERJUAL";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1007, 14);
            label2.Name = "label2";
            label2.Size = new Size(167, 35);
            label2.TabIndex = 7;
            label2.Text = "DASHBOARD";
            // 
            // Dashboard_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            Controls.Add(comboRangeTime);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard_UC";
            Size = new Size(1231, 797);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAdmin).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdukProfit).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdukTerjual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView gridProdukTerjual;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Label lblProdukTerjual;
        private Panel panel6;
        private Label lblPendapatanBersih;
        private Label label10;
        private Panel panel5;
        private Label lblPendapatanKotor;
        private Label label8;
        private Label label11;
        private NumericUpDown numericAdmin;
        private ComboBox comboRangeTime;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel8;
        private DataGridView gridProdukProfit;
        private Label label3;
        private Panel panel7;
    }
}
