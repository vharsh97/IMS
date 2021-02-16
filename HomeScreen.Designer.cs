
namespace IMS
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.salesBtn = new System.Windows.Forms.Button();
            this.purchaseInvoiceBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.productDD = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.proPricingBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 549);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(809, 549);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.salesBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseInvoiceBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productDD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoryBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplierBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proPricingBtn, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 493);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // salesBtn
            // 
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesBtn.FlatAppearance.BorderSize = 2;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Location = new System.Drawing.Point(647, 3);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(159, 92);
            this.salesBtn.TabIndex = 4;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // purchaseInvoiceBtn
            // 
            this.purchaseInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseInvoiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInvoiceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseInvoiceBtn.FlatAppearance.BorderSize = 2;
            this.purchaseInvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseInvoiceBtn.Location = new System.Drawing.Point(486, 3);
            this.purchaseInvoiceBtn.Name = "purchaseInvoiceBtn";
            this.purchaseInvoiceBtn.Size = new System.Drawing.Size(155, 92);
            this.purchaseInvoiceBtn.TabIndex = 3;
            this.purchaseInvoiceBtn.Text = "Purchase Invoice";
            this.purchaseInvoiceBtn.UseVisualStyleBackColor = true;
            this.purchaseInvoiceBtn.Click += new System.EventHandler(this.purchaseInvoiceBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockBtn.FlatAppearance.BorderSize = 2;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Location = new System.Drawing.Point(325, 3);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(155, 92);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // productDD
            // 
            this.productDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productDD.FlatAppearance.BorderSize = 2;
            this.productDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDD.Location = new System.Drawing.Point(164, 3);
            this.productDD.Name = "productDD";
            this.productDD.Size = new System.Drawing.Size(155, 92);
            this.productDD.TabIndex = 1;
            this.productDD.Text = "Products";
            this.productDD.UseVisualStyleBackColor = true;
            this.productDD.Click += new System.EventHandler(this.productDD_Click);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(155, 92);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryBtn.FlatAppearance.BorderSize = 2;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Location = new System.Drawing.Point(3, 101);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(155, 92);
            this.categoryBtn.TabIndex = 5;
            this.categoryBtn.Text = "Categories";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplierBtn.FlatAppearance.BorderSize = 2;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Location = new System.Drawing.Point(164, 101);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(155, 92);
            this.supplierBtn.TabIndex = 6;
            this.supplierBtn.Text = "Suppliers";
            this.supplierBtn.UseVisualStyleBackColor = true;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // proPricingBtn
            // 
            this.proPricingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proPricingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proPricingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proPricingBtn.FlatAppearance.BorderSize = 2;
            this.proPricingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proPricingBtn.Location = new System.Drawing.Point(325, 101);
            this.proPricingBtn.Name = "proPricingBtn";
            this.proPricingBtn.Size = new System.Drawing.Size(155, 92);
            this.proPricingBtn.TabIndex = 7;
            this.proPricingBtn.Text = "Product Pricing";
            this.proPricingBtn.UseVisualStyleBackColor = true;
            this.proPricingBtn.Click += new System.EventHandler(this.proPricingBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 549);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button purchaseInvoiceBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button productDD;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button proPricingBtn;
    }
}