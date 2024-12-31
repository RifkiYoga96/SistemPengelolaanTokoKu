namespace Shopee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            menuStrip1 = new MenuStrip();
            tabelToolStripMenuItem = new ToolStripMenuItem();
            bahanToolStripMenuItem = new ToolStripMenuItem();
            pendapatanToolStripMenuItem = new ToolStripMenuItem();
            produkToolStripMenuItem = new ToolStripMenuItem();
            kebutuhanToolStripMenuItem = new ToolStripMenuItem();
            inputPenjualanToolStripMenuItem = new ToolStripMenuItem();
            inputBiayaIklanToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripTabItem1
            // 
            toolStripTabItem1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // 
            // 
            toolStripTabItem1.Panel.Name = "ribbonPanel1";
            toolStripTabItem1.Panel.ScrollPosition = 0;
            toolStripTabItem1.Panel.TabIndex = 2;
            toolStripTabItem1.Panel.Text = "toolStripTabItem1";
            toolStripTabItem1.Position = 0;
            toolStripTabItem1.Size = new Size(174, 43);
            toolStripTabItem1.Tag = "1";
            toolStripTabItem1.Text = "toolStripTabItem1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tabelToolStripMenuItem, inputPenjualanToolStripMenuItem, inputBiayaIklanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(906, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tabelToolStripMenuItem
            // 
            tabelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bahanToolStripMenuItem, pendapatanToolStripMenuItem, produkToolStripMenuItem, kebutuhanToolStripMenuItem });
            tabelToolStripMenuItem.Name = "tabelToolStripMenuItem";
            tabelToolStripMenuItem.Size = new Size(46, 22);
            tabelToolStripMenuItem.Text = "Tabel";
            // 
            // bahanToolStripMenuItem
            // 
            bahanToolStripMenuItem.Name = "bahanToolStripMenuItem";
            bahanToolStripMenuItem.Size = new Size(137, 22);
            bahanToolStripMenuItem.Text = "Bahan";
            bahanToolStripMenuItem.Click += bahanToolStripMenuItem_Click;
            // 
            // pendapatanToolStripMenuItem
            // 
            pendapatanToolStripMenuItem.Name = "pendapatanToolStripMenuItem";
            pendapatanToolStripMenuItem.Size = new Size(137, 22);
            pendapatanToolStripMenuItem.Text = "Pendapatan";
            pendapatanToolStripMenuItem.Click += pendapatanToolStripMenuItem_Click;
            // 
            // produkToolStripMenuItem
            // 
            produkToolStripMenuItem.Name = "produkToolStripMenuItem";
            produkToolStripMenuItem.Size = new Size(137, 22);
            produkToolStripMenuItem.Text = "Produk";
            produkToolStripMenuItem.Click += produkToolStripMenuItem_Click;
            // 
            // kebutuhanToolStripMenuItem
            // 
            kebutuhanToolStripMenuItem.Name = "kebutuhanToolStripMenuItem";
            kebutuhanToolStripMenuItem.Size = new Size(137, 22);
            kebutuhanToolStripMenuItem.Text = "Kebutuhan";
            kebutuhanToolStripMenuItem.Click += kebutuhanToolStripMenuItem_Click;
            // 
            // inputPenjualanToolStripMenuItem
            // 
            inputPenjualanToolStripMenuItem.Name = "inputPenjualanToolStripMenuItem";
            inputPenjualanToolStripMenuItem.Size = new Size(102, 22);
            inputPenjualanToolStripMenuItem.Text = "Input Penjualan";
            inputPenjualanToolStripMenuItem.Click += inputPenjualanToolStripMenuItem_Click;
            // 
            // inputBiayaIklanToolStripMenuItem
            // 
            inputBiayaIklanToolStripMenuItem.Name = "inputBiayaIklanToolStripMenuItem";
            inputBiayaIklanToolStripMenuItem.Size = new Size(106, 22);
            inputBiayaIklanToolStripMenuItem.Text = "Input Biaya Iklan";
            inputBiayaIklanToolStripMenuItem.Click += inputBiayaIklanToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 486);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tabelToolStripMenuItem;
        private ToolStripMenuItem bahanToolStripMenuItem;
        private ToolStripMenuItem pendapatanToolStripMenuItem;
        private ToolStripMenuItem produkToolStripMenuItem;
        private ToolStripMenuItem inputPenjualanToolStripMenuItem;
        private ToolStripMenuItem kebutuhanToolStripMenuItem;
        private ToolStripMenuItem inputBiayaIklanToolStripMenuItem;
    }
}
