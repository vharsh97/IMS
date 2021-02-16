﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.suplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.perUnitTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.cartBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.supplierErrorLabel = new System.Windows.Forms.Label();
            this.barcodeErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(687, 60);
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(105, 27);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.totLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.cartBtn);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.quantityTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.productTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.perUnitTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.suplierDD);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.supplierErrorLabel);
            this.leftPanel.Controls.Add(this.quantityErrorLabel);
            this.leftPanel.Controls.Add(this.barcodeErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 643);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.suplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.perUnitTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.cartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel4);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(687, 643);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Supplier";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(12, 219);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(225, 27);
            this.barcodeTxt.TabIndex = 3;
            this.barcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTxt_Validating);
            // 
            // suplierDD
            // 
            this.suplierDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suplierDD.FormattingEnabled = true;
            this.suplierDD.Location = new System.Drawing.Point(12, 165);
            this.suplierDD.Name = "suplierDD";
            this.suplierDD.Size = new System.Drawing.Size(225, 28);
            this.suplierDD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Per Unit Price";
            // 
            // perUnitTxt
            // 
            this.perUnitTxt.Location = new System.Drawing.Point(12, 325);
            this.perUnitTxt.Name = "perUnitTxt";
            this.perUnitTxt.Size = new System.Drawing.Size(225, 27);
            this.perUnitTxt.TabIndex = 7;
            this.perUnitTxt.TextChanged += new System.EventHandler(this.perUnitTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product";
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(12, 272);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(225, 27);
            this.productTxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Select Quantity";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(12, 378);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(225, 27);
            this.quantityTxt.TabIndex = 9;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            // 
            // cartBtn
            // 
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.FlatAppearance.BorderSize = 2;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Location = new System.Drawing.Point(12, 411);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(225, 46);
            this.cartBtn.TabIndex = 10;
            this.cartBtn.Text = "ADD TO CART";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Amount";
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLabel.Location = new System.Drawing.Point(12, 526);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(68, 37);
            this.totLabel.TabIndex = 12;
            this.totLabel.Text = "0.00";
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
            this.quantityGV,
            this.perUnitPriceGV,
            this.totalAmountGV,
            this.deleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 458);
            this.dataGridView1.TabIndex = 4;
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
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.MinimumWidth = 6;
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // perUnitPriceGV
            // 
            this.perUnitPriceGV.HeaderText = "Per Unit Price";
            this.perUnitPriceGV.MinimumWidth = 6;
            this.perUnitPriceGV.Name = "perUnitPriceGV";
            this.perUnitPriceGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.MinimumWidth = 6;
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.MinimumWidth = 6;
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 574);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 69);
            this.panel4.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.43231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.56769F));
            this.tableLayoutPanel2.Controls.Add(this.grossLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(687, 69);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // grossLabel
            // 
            this.grossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(479, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(205, 69);
            this.grossLabel.TabIndex = 14;
            this.grossLabel.Text = "0.00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(470, 69);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gross Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // supplierErrorLabel
            // 
            this.supplierErrorLabel.AutoSize = true;
            this.supplierErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.supplierErrorLabel.Location = new System.Drawing.Point(116, 137);
            this.supplierErrorLabel.Name = "supplierErrorLabel";
            this.supplierErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.supplierErrorLabel.TabIndex = 14;
            this.supplierErrorLabel.Text = "*";
            this.supplierErrorLabel.Visible = false;
            // 
            // barcodeErrorLabel
            // 
            this.barcodeErrorLabel.AutoSize = true;
            this.barcodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.barcodeErrorLabel.Location = new System.Drawing.Point(75, 193);
            this.barcodeErrorLabel.Name = "barcodeErrorLabel";
            this.barcodeErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.barcodeErrorLabel.TabIndex = 17;
            this.barcodeErrorLabel.Text = "*";
            this.barcodeErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.quantityErrorLabel.Location = new System.Drawing.Point(118, 351);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.quantityErrorLabel.TabIndex = 18;
            this.quantityErrorLabel.Text = "*";
            this.quantityErrorLabel.Visible = false;
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
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox suplierDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox perUnitTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label supplierErrorLabel;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.Label barcodeErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}