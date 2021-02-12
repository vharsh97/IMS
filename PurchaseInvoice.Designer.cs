
namespace IMS
{
    partial class PurchaseInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.suplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(105, 27);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.textBox2);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.suplierDD);
            this.leftPanel.Controls.Add(this.textBox1);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(250, 643);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.textBox1, 0);
            this.leftPanel.Controls.SetChildIndex(this.suplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.textBox2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(687, 643);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Supplier";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 27);
            this.textBox1.TabIndex = 3;
            // 
            // suplierDD
            // 
            this.suplierDD.FormattingEnabled = true;
            this.suplierDD.Location = new System.Drawing.Point(12, 200);
            this.suplierDD.Name = "suplierDD";
            this.suplierDD.Size = new System.Drawing.Size(225, 28);
            this.suplierDD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Quantity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 27);
            this.textBox2.TabIndex = 6;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 643);
            this.Name = "PurchaseInvoice";
            this.Text = "Purchase Invoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox suplierDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}