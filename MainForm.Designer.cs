
namespace ShopeeApiWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCode = new TextBox();
            btnGetToken = new Button();
            btnGetOrders = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(12, 12);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(400, 23);
            txtCode.TabIndex = 0;
            // 
            // btnGetToken
            // 
            btnGetToken.Location = new Point(418, 12);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(100, 23);
            btnGetToken.TabIndex = 1;
            btnGetToken.Text = "Get Token";
            btnGetToken.UseVisualStyleBackColor = true;
            // 
            // btnGetOrders
            // 
            btnGetOrders.Location = new Point(524, 12);
            btnGetOrders.Name = "btnGetOrders";
            btnGetOrders.Size = new Size(100, 23);
            btnGetOrders.TabIndex = 2;
            btnGetOrders.Text = "Get Orders";
            btnGetOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(612, 242);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 298);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(612, 60);
            textBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 370);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetOrders);
            Controls.Add(btnGetToken);
            Controls.Add(txtCode);
            Name = "MainForm";
            Text = "Shopee API Demo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
    }
}
