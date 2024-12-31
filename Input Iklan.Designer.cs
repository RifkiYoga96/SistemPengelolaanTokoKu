namespace Shopee
{
    partial class Input_Iklan
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
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            biayaiklantxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tanggal2 = new DateTimePicker();
            tanggal1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Highlight;
            label2.Dock = DockStyle.Top;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(588, 36);
            label2.TabIndex = 3;
            label2.Text = "Input Biaya Iklan";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(biayaiklantxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tanggal2);
            panel1.Controls.Add(tanggal1);
            panel1.Location = new Point(142, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 335);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(191, 288);
            button1.Name = "button1";
            button1.Size = new Size(93, 33);
            button1.TabIndex = 6;
            button1.Text = "Input";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // biayaiklantxt
            // 
            biayaiklantxt.Location = new Point(37, 132);
            biayaiklantxt.Name = "biayaiklantxt";
            biayaiklantxt.PlaceholderText = "Masukkan Biaya Iklan!";
            biayaiklantxt.Size = new Size(218, 23);
            biayaiklantxt.TabIndex = 5;
            biayaiklantxt.KeyPress += biayaiklantxt_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 109);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Biaya Iklan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Tanggal";
            // 
            // tanggal2
            // 
            tanggal2.Location = new Point(37, 74);
            tanggal2.Name = "tanggal2";
            tanggal2.Size = new Size(218, 23);
            tanggal2.TabIndex = 2;
            // 
            // tanggal1
            // 
            tanggal1.Location = new Point(37, 45);
            tanggal1.Name = "tanggal1";
            tanggal1.Size = new Size(218, 23);
            tanggal1.TabIndex = 1;
            // 
            // Input_Iklan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 379);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Input_Iklan";
            Text = "Input_Iklan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Button button1;
        private TextBox biayaiklantxt;
        private Label label3;
        private Label label1;
        private DateTimePicker tanggal2;
        private DateTimePicker tanggal1;
    }
}