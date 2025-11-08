namespace Shopee
{
    partial class PopupIncorrect
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
            lbl1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Segoe UI Semibold", 12.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(3, 95);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(281, 36);
            lbl1.TabIndex = 0;
            lbl1.Text = "Data Berhasil Dihapus\r\n";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.salah_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(110, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PopupIncorrect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 149);
            Controls.Add(pictureBox1);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupIncorrect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl1;
        private PictureBox pictureBox1;
    }
}