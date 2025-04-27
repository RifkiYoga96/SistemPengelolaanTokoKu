namespace Shopee
{
    partial class Pendapatan_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            comboTimeFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            lblPage = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPage);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(comboTimeFilter);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(29, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 592);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 86, 179);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 24);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 1;
            button1.Text = "➕ Add Data";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1067, 445);
            dataGridView1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(14, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  🔍Search Data";
            txtSearch.Size = new Size(268, 31);
            txtSearch.TabIndex = 3;
            // 
            // comboTimeFilter
            // 
            comboTimeFilter.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboTimeFilter.FormattingEnabled = true;
            comboTimeFilter.Location = new Point(289, 14);
            comboTimeFilter.Name = "comboTimeFilter";
            comboTimeFilter.Size = new Size(162, 31);
            comboTimeFilter.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(727, 17);
            label1.Name = "label1";
            label1.Size = new Size(354, 25);
            label1.TabIndex = 5;
            label1.Text = "Periode : All time";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(951, 28);
            label2.Name = "label2";
            label2.Size = new Size(173, 35);
            label2.TabIndex = 6;
            label2.Text = "PENDAPATAN";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(1012, 531);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 38);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.Location = new Point(857, 531);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(98, 38);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // lblPage
            // 
            lblPage.BackColor = Color.FromArgb(0, 86, 179);
            lblPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPage.ForeColor = Color.White;
            lblPage.Location = new Point(952, 531);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(63, 38);
            lblPage.TabIndex = 9;
            lblPage.Text = "12";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(75, 535);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(80, 31);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 537);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 12;
            label3.Text = "Show";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(159, 537);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 13;
            label4.Text = "Entries";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Pendapatan_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Pendapatan_UC";
            Size = new Size(1157, 704);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private ComboBox comboTimeFilter;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label lblPage;
        private Button btnPrevious;
        private Button btnNext;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}
