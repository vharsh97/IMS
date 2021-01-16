
namespace IMS
{
    partial class settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.serverText = new System.Windows.Forms.TextBox();
            this.databaseText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.passwordText);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.userText);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.databaseText);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverText);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 601);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.userText, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordText, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // serverText
            // 
            this.serverText.Location = new System.Drawing.Point(9, 174);
            this.serverText.MaxLength = 50;
            this.serverText.Name = "serverText";
            this.serverText.Size = new System.Drawing.Size(232, 23);
            this.serverText.TabIndex = 3;
            // 
            // databaseText
            // 
            this.databaseText.Location = new System.Drawing.Point(9, 222);
            this.databaseText.MaxLength = 50;
            this.databaseText.Name = "databaseText";
            this.databaseText.Size = new System.Drawing.Size(232, 23);
            this.databaseText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(9, 272);
            this.userText.MaxLength = 30;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(232, 23);
            this.userText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "User ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(9, 350);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(125, 19);
            this.isCB.TabIndex = 10;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(9, 321);
            this.passwordText.MaxLength = 30;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(232, 23);
            this.passwordText.TabIndex = 9;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(9, 375);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(232, 29);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Name = "settings";
            this.Text = "settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox databaseText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverText;
        private System.Windows.Forms.Label label3;
    }
}