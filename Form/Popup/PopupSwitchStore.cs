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
    public partial class PopupSwitchStore : Form
    {
        public PopupSwitchStore()
        {
            InitializeComponent();
            this.TopMost = true; // agar selalu diatas atau tidak tertimpa

            this.Load += async (s, e) =>
            {
                FormAnimator.FadeIn(this, "lbl2", "Scurity Sensor - TikTok");
                await Task.Delay(2000);
                FormAnimator.FadeOut(this);
            };
        }
    }
}
