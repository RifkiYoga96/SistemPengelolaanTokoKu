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
    public partial class Pendapatan_UC : UserControl
    {
        public Pendapatan_UC()
        {
            InitializeComponent();
            InitComponent();
            RegisterEvent();
        }

        private void InitComponent()
        {
            comboTimeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> listTime = new List<string>
            {
                "Hari ini",
                "Kemarin",
                "7 hari lalu",
                "1 bulan lalu",
                "3 bulan lalu",
                "Atur rentang waktu"
            };
            comboTimeFilter.DataSource = listTime;
        }

        private void RegisterEvent()
        {
            comboTimeFilter.SelectedIndexChanged += ComboTimeFilter_SelectedIndexChanged;
        }

        private void ComboTimeFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(comboTimeFilter.SelectedIndex == 5)
            {
                var filterForm = new Filter_Form();
                filterForm.Location = new Point(Cursor.Position.X, Cursor.Position.Y - comboTimeFilter.DropDownHeight);
                filterForm.ShowDialog();
            }
        }
    }
}
