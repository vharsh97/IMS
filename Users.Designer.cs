
namespace IMS
{
    partial class Users
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDropdown);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Controls.Add(this.emailText);
            this.leftPanel.Controls.Add(this.phoneText);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.passwordText);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.usernameText);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.nameText);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.nameErrorLabel);
            this.leftPanel.Controls.Add(this.usernameErrorLabel);
            this.leftPanel.Controls.Add(this.passwordErrorLabel);
            this.leftPanel.Controls.Add(this.phoneErrorLabel);
            this.leftPanel.Controls.Add(this.emailErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 581);
            this.leftPanel.TabIndex = 1;
            this.leftPanel.Controls.SetChildIndex(this.emailErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneText, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailText, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDropdown, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(806, 581);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(12, 192);
            this.nameText.MaxLength = 35;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(225, 27);
            this.nameText.TabIndex = 4;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(12, 245);
            this.usernameText.MaxLength = 20;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(225, 27);
            this.usernameText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usename";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 298);
            this.passwordText.MaxLength = 20;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(225, 27);
            this.passwordText.TabIndex = 8;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(12, 351);
            this.phoneText.MaxLength = 10;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(225, 27);
            this.phoneText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone (+91 - XXXXXXXXXX)";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(12, 404);
            this.emailText.MaxLength = 50;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(225, 27);
            this.emailText.TabIndex = 12;
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 60);
            this.panel4.TabIndex = 11;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.nameErrorLabel.Location = new System.Drawing.Point(54, 163);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.nameErrorLabel.TabIndex = 12;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.usernameErrorLabel.Location = new System.Drawing.Point(77, 217);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.usernameErrorLabel.TabIndex = 13;
            this.usernameErrorLabel.Text = "*";
            this.usernameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.passwordErrorLabel.Location = new System.Drawing.Point(77, 270);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.passwordErrorLabel.TabIndex = 14;
            this.passwordErrorLabel.Text = "*";
            this.passwordErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.phoneErrorLabel.Location = new System.Drawing.Point(200, 323);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.phoneErrorLabel.TabIndex = 15;
            this.phoneErrorLabel.Text = "*";
            this.phoneErrorLabel.Visible = false;
            this.phoneErrorLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.emailErrorLabel.Location = new System.Drawing.Point(52, 376);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(25, 35);
            this.emailErrorLabel.TabIndex = 16;
            this.emailErrorLabel.Text = "*";
            this.emailErrorLabel.Visible = false;
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
            this.userIDGV,
            this.NameGV,
            this.usernameGV,
            this.passwordGV,
            this.phoneGV,
            this.emailGV,
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
            this.dataGridView1.Size = new System.Drawing.Size(806, 465);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.MinimumWidth = 6;
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // usernameGV
            // 
            this.usernameGV.HeaderText = "Username";
            this.usernameGV.MinimumWidth = 6;
            this.usernameGV.Name = "usernameGV";
            this.usernameGV.ReadOnly = true;
            // 
            // passwordGV
            // 
            this.passwordGV.HeaderText = "Password";
            this.passwordGV.MinimumWidth = 6;
            this.passwordGV.Name = "passwordGV";
            this.passwordGV.ReadOnly = true;
            this.passwordGV.Visible = false;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 6;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // emailGV
            // 
            this.emailGV.HeaderText = "Email";
            this.emailGV.MinimumWidth = 6;
            this.emailGV.Name = "emailGV";
            this.emailGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // statusDropdown
            // 
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDropdown.Location = new System.Drawing.Point(12, 457);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(225, 28);
            this.statusDropdown.TabIndex = 18;
            this.statusDropdown.SelectedIndexChanged += new System.EventHandler(this.statusDropdown_SelectedIndexChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 581);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusDropdown;
    }
}