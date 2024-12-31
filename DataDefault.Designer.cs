namespace Shopee
{
    partial class DataDefault
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            panel1 = new Panel();
            btnInputBahan = new Button();
            label1 = new Label();
            panel2 = new Panel();
            InputJumlahGrid = new DataGridView();
            btnInputJumlah = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputJumlahGrid).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Resistor", "Relay" });
            checkedListBox1.Location = new Point(8, 28);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(193, 220);
            checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(338, 296);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(93, 27);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnInputBahan);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 286);
            panel1.TabIndex = 2;
            // 
            // btnInputBahan
            // 
            btnInputBahan.BackColor = SystemColors.Highlight;
            btnInputBahan.FlatStyle = FlatStyle.Flat;
            btnInputBahan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInputBahan.ForeColor = Color.White;
            btnInputBahan.Location = new Point(126, 252);
            btnInputBahan.Margin = new Padding(2);
            btnInputBahan.Name = "btnInputBahan";
            btnInputBahan.Size = new Size(75, 27);
            btnInputBahan.TabIndex = 3;
            btnInputBahan.Text = "Input";
            btnInputBahan.UseVisualStyleBackColor = false;
            btnInputBahan.Click += btnInputBahan_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 0;
            label1.Text = "Input Bahan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(InputJumlahGrid);
            panel2.Controls.Add(btnInputJumlah);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(221, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 286);
            panel2.TabIndex = 4;
            // 
            // InputJumlahGrid
            // 
            InputJumlahGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InputJumlahGrid.Location = new Point(3, 27);
            InputJumlahGrid.Name = "InputJumlahGrid";
            InputJumlahGrid.RowTemplate.Height = 25;
            InputJumlahGrid.Size = new Size(202, 220);
            InputJumlahGrid.TabIndex = 4;
            // 
            // btnInputJumlah
            // 
            btnInputJumlah.BackColor = SystemColors.Highlight;
            btnInputJumlah.FlatStyle = FlatStyle.Flat;
            btnInputJumlah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInputJumlah.ForeColor = Color.White;
            btnInputJumlah.Location = new Point(130, 252);
            btnInputJumlah.Margin = new Padding(2);
            btnInputJumlah.Name = "btnInputJumlah";
            btnInputJumlah.Size = new Size(75, 27);
            btnInputJumlah.TabIndex = 3;
            btnInputJumlah.Text = "Input";
            btnInputJumlah.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 21);
            label2.TabIndex = 0;
            label2.Text = "Input Jumlah";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataDefault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 328);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "DataDefault";
            Text = "DataDefault";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InputJumlahGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button btnInputBahan;
        private Panel panel2;
        private DataGridView InputJumlahGrid;
        private Button btnInputJumlah;
        private Label label2;
    }
}