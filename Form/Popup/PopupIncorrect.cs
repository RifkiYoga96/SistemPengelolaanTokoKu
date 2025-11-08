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
    public partial class PopupIncorrect : Form
    {
        public PopupIncorrect(string txtLabel = null)
        {
            InitializeComponent();
            this.TopMost = true; // agar selalu diatas atau tidak tertimpa

            this.Load += async (s, e) =>
            {
                FormAnimator.FadeIn(this, "lbl1", txtLabel);
                await Task.Delay(2000);
                FormAnimator.FadeOut(this);
            };
        }
    }
}
