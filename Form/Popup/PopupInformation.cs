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
    public partial class PopupInformation : Form
    {
        public PopupInformation(string txtLabel = null, Image icon = null)
        {
            InitializeComponent();
            this.TopMost = true; // agar selalu diatas atau tidak tertimpa

            this.Load += async (s, e) =>
            {
                FormAnimator.FadeIn(this, "lbl2", txtLabel,"PictureBox1",icon);
                await Task.Delay(2000);
                FormAnimator.FadeOut(this);
            };
        }
    }
}
