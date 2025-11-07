using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public static class FormAnimator
    {
        public static void FadeIn(Form form, string labelName = null, string labelText = null, string pictureBoxName = null, Image icon = null, int interval = 20, double step = 0.05)
        {
            // Ubah teks label jika parameter ada
            if (!string.IsNullOrEmpty(labelName) && !string.IsNullOrEmpty(labelText))
            {
                if (FindControlRecursive(form, labelName) is Label lbl)
                    lbl.Text = labelText;
            }

            // Ubah gambar PictureBox jika parameter ada
            if (!string.IsNullOrEmpty(pictureBoxName) && icon != null)
            {
                if (FindControlRecursive(form, pictureBoxName) is PictureBox pic)
                    pic.Image = icon;
            }

            form.Opacity = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += step;
                }
                else
                {
                    form.Opacity = 1;
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        // Fungsi untuk mencari kontrol secara rekursif (termasuk di dalam panel, groupbox, dsb)
        private static Control FindControlRecursive(Control parent, string name)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return c;

                Control child = FindControlRecursive(c, name);
                if (child != null)
                    return child;
            }
            return null;
        }

        public static void FadeOut(Form form, int interval = 20, double step = 0.05)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity > 0)
                {
                    form.Opacity -= step;
                }
                else
                {
                    form.Opacity = 0;
                    timer.Stop();
                    timer.Dispose();
                    form.Close();
                }
            };
            timer.Start();
        }
    }
}
