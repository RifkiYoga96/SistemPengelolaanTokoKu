namespace Shopee
{
    partial class RentangTanggalForm
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
            dateTime1 = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            dateTime2 = new DateTimePicker();
            btnOk = new Button();
            SuspendLayout();
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(28, 48);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(200, 27);
            dateTime1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 20);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 14;
            label4.Text = "From date";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 86);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 16;
            label1.Text = "To date";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTime2
            // 
            dateTime2.Location = new Point(28, 114);
            dateTime2.Name = "dateTime2";
            dateTime2.Size = new Size(200, 27);
            dateTime2.TabIndex = 15;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(124, 163);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(104, 31);
            btnOk.TabIndex = 17;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // RentangTanggalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 215);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Controls.Add(dateTime2);
            Controls.Add(label4);
            Controls.Add(dateTime1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RentangTanggalForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Filter_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTime1;
        private Label label4;
        private Label label1;
        private DateTimePicker dateTime2;
        private Button btnOk;
    }
}