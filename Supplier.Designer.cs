
namespace IMS
{
    partial class Supplier
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
            this.supplierCompanyTxt = new System.Windows.Forms.TextBox();
            this.personNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone1Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone2Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ntnTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.supplierNameErrorLabel = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone1ErrorLabel = new System.Windows.Forms.Label();
            this.contactPersonErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.ntnErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(96, 27);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.ntnTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.phone2Txt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.phone1Txt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.personNameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.supplierCompanyTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.supplierNameErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.Add(this.ntnErrorLabel);
            this.leftPanel.Controls.Add(this.addressErrorLabel);
            this.leftPanel.Controls.Add(this.contactPersonErrorLabel);
            this.leftPanel.Controls.Add(this.phone1ErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 636);
            this.leftPanel.Controls.SetChildIndex(this.phone1ErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierCompanyTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.personNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone2Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(643, 636);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name/Company";
            // 
            // supplierCompanyTxt
            // 
            this.supplierCompanyTxt.Location = new System.Drawing.Point(12, 191);
            this.supplierCompanyTxt.MaxLength = 100;
            this.supplierCompanyTxt.Name = "supplierCompanyTxt";
            this.supplierCompanyTxt.Size = new System.Drawing.Size(224, 27);
            this.supplierCompanyTxt.TabIndex = 3;
            // 
            // personNameTxt
            // 
            this.personNameTxt.Location = new System.Drawing.Point(12, 244);
            this.personNameTxt.MaxLength = 100;
            this.personNameTxt.Name = "personNameTxt";
            this.personNameTxt.Size = new System.Drawing.Size(224, 27);
            this.personNameTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Person";
            // 
            // phone1Txt
            // 
            this.phone1Txt.Location = new System.Drawing.Point(12, 297);
            this.phone1Txt.MaxLength = 10;
            this.phone1Txt.Name = "phone1Txt";
            this.phone1Txt.Size = new System.Drawing.Size(224, 27);
            this.phone1Txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone 1";
            // 
            // phone2Txt
            // 
            this.phone2Txt.Location = new System.Drawing.Point(12, 350);
            this.phone2Txt.MaxLength = 10;
            this.phone2Txt.Name = "phone2Txt";
            this.phone2Txt.Size = new System.Drawing.Size(224, 27);
            this.phone2Txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone 2";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(12, 403);
            this.addressTxt.MaxLength = 100;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(224, 27);
            this.addressTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // ntnTxt
            // 
            this.ntnTxt.Location = new System.Drawing.Point(12, 456);
            this.ntnTxt.MaxLength = 100;
            this.ntnTxt.Name = "ntnTxt";
            this.ntnTxt.Size = new System.Drawing.Size(224, 27);
            this.ntnTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "NTN #";
            // 
            // supplierNameErrorLabel
            // 
            this.supplierNameErrorLabel.AutoSize = true;
            this.supplierNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierNameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.supplierNameErrorLabel.Location = new System.Drawing.Point(183, 163);
            this.supplierNameErrorLabel.Name = "supplierNameErrorLabel";
            this.supplierNameErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.supplierNameErrorLabel.TabIndex = 15;
            this.supplierNameErrorLabel.Text = "*";
            this.supplierNameErrorLabel.Visible = false;
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(12, 509);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(224, 28);
            this.statusDD.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status";
            // 
            // phone1ErrorLabel
            // 
            this.phone1ErrorLabel.AutoSize = true;
            this.phone1ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1ErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.phone1ErrorLabel.Location = new System.Drawing.Point(69, 269);
            this.phone1ErrorLabel.Name = "phone1ErrorLabel";
            this.phone1ErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.phone1ErrorLabel.TabIndex = 18;
            this.phone1ErrorLabel.Text = "*";
            this.phone1ErrorLabel.Visible = false;
            // 
            // contactPersonErrorLabel
            // 
            this.contactPersonErrorLabel.AutoSize = true;
            this.contactPersonErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.contactPersonErrorLabel.Location = new System.Drawing.Point(115, 218);
            this.contactPersonErrorLabel.Name = "contactPersonErrorLabel";
            this.contactPersonErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.contactPersonErrorLabel.TabIndex = 19;
            this.contactPersonErrorLabel.Text = "*";
            this.contactPersonErrorLabel.Visible = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.addressErrorLabel.Location = new System.Drawing.Point(70, 375);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.addressErrorLabel.TabIndex = 20;
            this.addressErrorLabel.Text = "*";
            this.addressErrorLabel.Visible = false;
            // 
            // ntnErrorLabel
            // 
            this.ntnErrorLabel.AutoSize = true;
            this.ntnErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntnErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ntnErrorLabel.Location = new System.Drawing.Point(58, 428);
            this.ntnErrorLabel.Name = "ntnErrorLabel";
            this.ntnErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.ntnErrorLabel.TabIndex = 21;
            this.ntnErrorLabel.Text = "*";
            this.ntnErrorLabel.Visible = false;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrorLabel.Location = new System.Drawing.Point(57, 481);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.statusErrorLabel.TabIndex = 22;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
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
            this.suppIDGV,
            this.companyNameGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
            this.statusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 520);
            this.dataGridView1.TabIndex = 3;
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "SuppID";
            this.suppIDGV.MinimumWidth = 6;
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // companyNameGV
            // 
            this.companyNameGV.HeaderText = "Company Name";
            this.companyNameGV.MinimumWidth = 6;
            this.companyNameGV.Name = "companyNameGV";
            this.companyNameGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact Person";
            this.personGV.MinimumWidth = 6;
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.MinimumWidth = 6;
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone2";
            this.phone2GV.MinimumWidth = 6;
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.MinimumWidth = 6;
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.MinimumWidth = 6;
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 636);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ntnTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone1Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplierCompanyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label supplierNameErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.Label ntnErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label contactPersonErrorLabel;
        private System.Windows.Forms.Label phone1ErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}