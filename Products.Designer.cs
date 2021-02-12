
namespace IMS
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.productText = new System.Windows.Forms.TextBox();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productErrorLabel = new System.Windows.Forms.Label();
            this.barcodeErrorLabel = new System.Windows.Forms.Label();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(110, 27);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.expiryDatePicker);
            this.leftPanel.Controls.Add(this.priceText);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.barcodeText);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.productText);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.productErrorLabel);
            this.leftPanel.Controls.Add(this.priceErrorLabel);
            this.leftPanel.Controls.Add(this.barcodeErrorLabel);
            this.leftPanel.Controls.Add(this.expiryErrorLabel);
            this.leftPanel.Controls.Add(this.categoryErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 663);
            this.leftPanel.Controls.SetChildIndex(this.categoryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.productErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.productText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceText, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryDatePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(727, 663);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // productText
            // 
            this.productText.Location = new System.Drawing.Point(12, 176);
            this.productText.Name = "productText";
            this.productText.Size = new System.Drawing.Size(225, 27);
            this.productText.TabIndex = 3;
            this.productText.TextChanged += new System.EventHandler(this.productText_TextChanged);
            // 
            // barcodeText
            // 
            this.barcodeText.Location = new System.Drawing.Point(12, 229);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(225, 27);
            this.barcodeText.TabIndex = 5;
            this.barcodeText.TextChanged += new System.EventHandler(this.barcodeText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Expiry Date";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(12, 335);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(225, 27);
            this.priceText.TabIndex = 9;
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // productErrorLabel
            // 
            this.productErrorLabel.AutoSize = true;
            this.productErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.productErrorLabel.Location = new System.Drawing.Point(110, 147);
            this.productErrorLabel.Name = "productErrorLabel";
            this.productErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.productErrorLabel.TabIndex = 13;
            this.productErrorLabel.Text = "*";
            this.productErrorLabel.Visible = false;
            // 
            // barcodeErrorLabel
            // 
            this.barcodeErrorLabel.AutoSize = true;
            this.barcodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.barcodeErrorLabel.Location = new System.Drawing.Point(69, 200);
            this.barcodeErrorLabel.Name = "barcodeErrorLabel";
            this.barcodeErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.barcodeErrorLabel.TabIndex = 14;
            this.barcodeErrorLabel.Text = "*";
            this.barcodeErrorLabel.Visible = false;
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.priceErrorLabel.Location = new System.Drawing.Point(47, 307);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.priceErrorLabel.TabIndex = 16;
            this.priceErrorLabel.Text = "*";
            this.priceErrorLabel.Visible = false;
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDatePicker.Location = new System.Drawing.Point(12, 282);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(225, 27);
            this.expiryDatePicker.TabIndex = 17;
            // 
            // expiryErrorLabel
            // 
            this.expiryErrorLabel.AutoSize = true;
            this.expiryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.expiryErrorLabel.Location = new System.Drawing.Point(91, 252);
            this.expiryErrorLabel.Name = "expiryErrorLabel";
            this.expiryErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.expiryErrorLabel.TabIndex = 18;
            this.expiryErrorLabel.Text = "*";
            this.expiryErrorLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Category";
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.categoryErrorLabel.Location = new System.Drawing.Point(74, 360);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.categoryErrorLabel.TabIndex = 21;
            this.categoryErrorLabel.Text = "*";
            this.categoryErrorLabel.Visible = false;
            // 
            // categoryDD
            // 
            this.categoryDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(12, 388);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(225, 28);
            this.categoryDD.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDGV,
            this.productNameGV,
            this.barcodeGV,
            this.expiryGV,
            this.priceGV,
            this.categoryIDGV,
            this.categoryGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(727, 547);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "ProductID";
            this.productIDGV.MinimumWidth = 6;
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.ReadOnly = true;
            this.productIDGV.Visible = false;
            // 
            // productNameGV
            // 
            this.productNameGV.HeaderText = "Product Name";
            this.productNameGV.MinimumWidth = 6;
            this.productNameGV.Name = "productNameGV";
            this.productNameGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.MinimumWidth = 6;
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.MinimumWidth = 6;
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.MinimumWidth = 6;
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // categoryIDGV
            // 
            this.categoryIDGV.HeaderText = "Category ID";
            this.categoryIDGV.MinimumWidth = 6;
            this.categoryIDGV.Name = "categoryIDGV";
            this.categoryIDGV.ReadOnly = true;
            this.categoryIDGV.Visible = false;
            // 
            // categoryGV
            // 
            this.categoryGV.HeaderText = "Category";
            this.categoryGV.MinimumWidth = 6;
            this.categoryGV.Name = "categoryGV";
            this.categoryGV.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 663);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
        private System.Windows.Forms.Label productErrorLabel;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.Label barcodeErrorLabel;
        private System.Windows.Forms.Label expiryErrorLabel;
        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGV;
    }
}