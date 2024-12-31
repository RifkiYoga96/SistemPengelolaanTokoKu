using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class DataDefault : Form
    {
        private DbDapper db = new DbDapper();
        BindingSource bs = new BindingSource();
        List<defaultdata> list = new List<defaultdata>();
        public static List<JumlahBahan> listcentang = new List<JumlahBahan>();
        private readonly BindingList<JumlahBahan> jumlahBahanlist = new BindingList<JumlahBahan>();
        public DataDefault()
        {
            InitializeComponent();
            list.Clear();
            listcentang.Clear();
            loaddata();
        }

        public void loaddata()
        {
            checkedListBox1.Items.Clear();
            var data = db.ListDefault();
            foreach (var item in data)
            {
                list.Add(new defaultdata { ID_Bahan = item.ID_Bahan, Nama_Bahan = item.Nama_Bahan,Jumlah = item.Jumlah });
            }

            bs.DataSource = list;
            checkedListBox1.DataSource = bs;
            checkedListBox1.DisplayMember = "Nama_Bahan";
            checkedListBox1.ValueMember = "ID_Bahan";
        }

        public void centang()
        {
            listcentang.Clear();
            foreach (var checkeditem in checkedListBox1.CheckedItems)
            {
                var item = (defaultdata)checkeditem;
                var dataBahan = new JumlahBahan
                {
                    ID_Bahan = item.ID_Bahan,
                    Nama_Bahan = item.Nama_Bahan,
                    Jumlah = item.Jumlah
                };
                jumlahBahanlist.Add(dataBahan); 
            }
            loadGrid();
        }

        private void loadGrid()
        {
            InputJumlahGrid.DataSource = null;
            InputJumlahGrid.DataSource = jumlahBahanlist;
        }

        public void SaveData()
        {
            //cek apakah jumlah ada yg 0
            foreach (var item in jumlahBahanlist)
            {
                if (item.Jumlah <= 0)
                {
                    MessageBox.Show("Jumlah Bahan Harus diisi dengan Valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            listcentang.Clear();

            foreach(var item in jumlahBahanlist)
            {
                listcentang.Add(new JumlahBahan
                {
                    ID_Bahan = item.ID_Bahan,
                    Jumlah = item.Jumlah
                });
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show($"{listcentang.Count.ToString()}");
        }

     

        private void btnInputBahan_Click(object sender, EventArgs e)
        {
            centang();
        }
        public class JumlahBahan
        {
            public int ID_Bahan { get; set; }
            public string Nama_Bahan { get; set; } = string.Empty;
            public int Jumlah { get; set; }
        }
    }
}
