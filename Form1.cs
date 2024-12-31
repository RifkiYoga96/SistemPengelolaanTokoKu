namespace Shopee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        private void inputPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPenjualan IP = new InputPenjualan();
            IP.MdiParent = this;
            IP.Dock = DockStyle.Fill;
            IP.Show();
        }

        private void bahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelBahan TB = new TabelBahan();
            TB.MdiParent = this;
            TB.Dock = DockStyle.Fill;
            TB.Show();
        }

        private void kebutuhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomponenProduk KP = new KomponenProduk();
            KP.MdiParent = this;
            KP.Dock = DockStyle.Fill;
            KP.Show();
        }

        private void pendapatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelPendapatan TP = new TabelPendapatan();
            TP.MdiParent = this;
            TP.Dock = DockStyle.Fill;
            TP.Show();
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelProduk TP = new TabelProduk();
            TP.MdiParent = this;
            TP.Dock = DockStyle.Fill;
            TP.Show();
        }

        private void inputBiayaIklanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Iklan ip = new Input_Iklan(); 
            ip.MdiParent = this;
            ip.Dock = DockStyle.Fill;
            ip.Show();
        }
    }
}
