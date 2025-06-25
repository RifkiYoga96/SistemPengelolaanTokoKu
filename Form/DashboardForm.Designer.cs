namespace Shopee
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            mainPanel = new Panel();
            btnDashboard = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTransaksi = new Button();
            btnProduk = new Button();
            btnKomponen = new Button();
            btnKomponenProduk = new Button();
            btnOperasional = new Button();
            btnKalkulator = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 52);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 17, 40);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 69);
            panel2.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(230, 235, 240);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(280, 69);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(710, 608);
            mainPanel.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(280, 56);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "     🏠 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnTransaksi);
            flowLayoutPanel1.Controls.Add(btnProduk);
            flowLayoutPanel1.Controls.Add(btnKomponen);
            flowLayoutPanel1.Controls.Add(btnKomponenProduk);
            flowLayoutPanel1.Controls.Add(btnOperasional);
            flowLayoutPanel1.Controls.Add(btnKalkulator);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 69);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(280, 608);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = SystemColors.Control;
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransaksi.ForeColor = Color.Black;
            btnTransaksi.Location = new Point(0, 56);
            btnTransaksi.Margin = new Padding(0);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(280, 56);
            btnTransaksi.TabIndex = 1;
            btnTransaksi.Text = "     💸 Transaksi";
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnProduk
            // 
            btnProduk.FlatAppearance.BorderSize = 0;
            btnProduk.FlatStyle = FlatStyle.Flat;
            btnProduk.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduk.Location = new Point(0, 112);
            btnProduk.Margin = new Padding(0);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(280, 56);
            btnProduk.TabIndex = 2;
            btnProduk.Text = "     \U0001f6d2 Produk";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            // 
            // btnKomponen
            // 
            btnKomponen.FlatAppearance.BorderSize = 0;
            btnKomponen.FlatStyle = FlatStyle.Flat;
            btnKomponen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKomponen.Location = new Point(0, 168);
            btnKomponen.Margin = new Padding(0);
            btnKomponen.Name = "btnKomponen";
            btnKomponen.Size = new Size(280, 56);
            btnKomponen.TabIndex = 3;
            btnKomponen.Text = "     🔩 Komponen";
            btnKomponen.TextAlign = ContentAlignment.MiddleLeft;
            btnKomponen.UseVisualStyleBackColor = true;
            // 
            // btnKomponenProduk
            // 
            btnKomponenProduk.FlatAppearance.BorderSize = 0;
            btnKomponenProduk.FlatStyle = FlatStyle.Flat;
            btnKomponenProduk.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKomponenProduk.Location = new Point(0, 224);
            btnKomponenProduk.Margin = new Padding(0);
            btnKomponenProduk.Name = "btnKomponenProduk";
            btnKomponenProduk.Size = new Size(280, 56);
            btnKomponenProduk.TabIndex = 4;
            btnKomponenProduk.Text = "     \U0001f9f0 Komponen Produk";
            btnKomponenProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnKomponenProduk.UseVisualStyleBackColor = true;
            // 
            // btnOperasional
            // 
            btnOperasional.FlatAppearance.BorderSize = 0;
            btnOperasional.FlatStyle = FlatStyle.Flat;
            btnOperasional.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOperasional.Location = new Point(0, 280);
            btnOperasional.Margin = new Padding(0);
            btnOperasional.Name = "btnOperasional";
            btnOperasional.Size = new Size(280, 56);
            btnOperasional.TabIndex = 5;
            btnOperasional.Text = "     \U0001f9f0 Operasional";
            btnOperasional.TextAlign = ContentAlignment.MiddleLeft;
            btnOperasional.UseVisualStyleBackColor = true;
            // 
            // btnKalkulator
            // 
            btnKalkulator.FlatAppearance.BorderSize = 0;
            btnKalkulator.FlatStyle = FlatStyle.Flat;
            btnKalkulator.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKalkulator.Location = new Point(0, 336);
            btnKalkulator.Margin = new Padding(0);
            btnKalkulator.Name = "btnKalkulator";
            btnKalkulator.Size = new Size(280, 56);
            btnKalkulator.TabIndex = 6;
            btnKalkulator.Text = "     \U0001f9f0 Kalkulator Iklan && Laba";
            btnKalkulator.TextAlign = ContentAlignment.MiddleLeft;
            btnKalkulator.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 677);
            Controls.Add(mainPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel mainPanel;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTransaksi;
        private Button btnProduk;
        private Button btnKomponen;
        private Button btnKomponenProduk;
        private Button btnOperasional;
        private Button btnKalkulator;
    }
}