namespace Water_Bills
{
    partial class UC4_Register
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
            this.header5 = new System.Windows.Forms.Label();
            this.hidetext1a = new System.Windows.Forms.Label();
            this.username_rg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header6 = new System.Windows.Forms.Label();
            this.hidetext2a = new System.Windows.Forms.Label();
            this.pass_rg = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerbt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hidetext3a = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.header7 = new System.Windows.Forms.Label();
            this.header4 = new System.Windows.Forms.Label();
            this.showpass_rg = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // header5
            // 
            this.header5.AutoSize = true;
            this.header5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.header5.Location = new System.Drawing.Point(81, 50);
            this.header5.Name = "header5";
            this.header5.Size = new System.Drawing.Size(80, 18);
            this.header5.TabIndex = 11;
            this.header5.Text = "Username:";
            // 
            // hidetext1a
            // 
            this.hidetext1a.AutoSize = true;
            this.hidetext1a.BackColor = System.Drawing.Color.White;
            this.hidetext1a.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hidetext1a.Location = new System.Drawing.Point(12, 7);
            this.hidetext1a.Margin = new System.Windows.Forms.Padding(0);
            this.hidetext1a.Name = "hidetext1a";
            this.hidetext1a.Size = new System.Drawing.Size(101, 16);
            this.hidetext1a.TabIndex = 2;
            this.hidetext1a.Text = "Enter username";
            // 
            // username_rg
            // 
            this.username_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_rg.Dock = System.Windows.Forms.DockStyle.Right;
            this.username_rg.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_rg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.username_rg.Location = new System.Drawing.Point(9, 0);
            this.username_rg.Name = "username_rg";
            this.username_rg.Size = new System.Drawing.Size(279, 34);
            this.username_rg.TabIndex = 1;
            this.username_rg.TextChanged += new System.EventHandler(this.username_rg_TextChanged);
            this.username_rg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_rg_KeyDown);
            this.username_rg.MouseEnter += new System.EventHandler(this.username_rg_MouseEnter);
            this.username_rg.MouseLeave += new System.EventHandler(this.username_rg_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hidetext1a);
            this.panel1.Controls.Add(this.username_rg);
            this.panel1.Location = new System.Drawing.Point(85, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 34);
            this.panel1.TabIndex = 12;
            // 
            // header6
            // 
            this.header6.AutoSize = true;
            this.header6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.header6.Location = new System.Drawing.Point(81, 126);
            this.header6.Name = "header6";
            this.header6.Size = new System.Drawing.Size(74, 18);
            this.header6.TabIndex = 12;
            this.header6.Text = "Password:";
            // 
            // hidetext2a
            // 
            this.hidetext2a.AutoSize = true;
            this.hidetext2a.BackColor = System.Drawing.Color.White;
            this.hidetext2a.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hidetext2a.Location = new System.Drawing.Point(12, 7);
            this.hidetext2a.Name = "hidetext2a";
            this.hidetext2a.Size = new System.Drawing.Size(127, 16);
            this.hidetext2a.TabIndex = 3;
            this.hidetext2a.Text = "Enter new password";
            // 
            // pass_rg
            // 
            this.pass_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_rg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pass_rg.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_rg.Location = new System.Drawing.Point(9, 0);
            this.pass_rg.Name = "pass_rg";
            this.pass_rg.PasswordChar = '•';
            this.pass_rg.Size = new System.Drawing.Size(279, 34);
            this.pass_rg.TabIndex = 1;
            this.pass_rg.TextChanged += new System.EventHandler(this.pass_rg_TextChanged);
            this.pass_rg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_rg_KeyDown);
            this.pass_rg.MouseEnter += new System.EventHandler(this.pass_rg_MouseEnter);
            this.pass_rg.MouseLeave += new System.EventHandler(this.pass_rg_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hidetext2a);
            this.panel2.Controls.Add(this.pass_rg);
            this.panel2.Location = new System.Drawing.Point(85, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 34);
            this.panel2.TabIndex = 13;
            // 
            // registerbt
            // 
            this.registerbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.registerbt.FlatAppearance.BorderSize = 0;
            this.registerbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registerbt.Location = new System.Drawing.Point(84, 307);
            this.registerbt.Name = "registerbt";
            this.registerbt.Size = new System.Drawing.Size(290, 51);
            this.registerbt.TabIndex = 14;
            this.registerbt.Text = "REGISTER";
            this.registerbt.UseVisualStyleBackColor = false;
            this.registerbt.Click += new System.EventHandler(this.registerbt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.hidetext3a);
            this.panel3.Controls.Add(this.confirmpass);
            this.panel3.Location = new System.Drawing.Point(85, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 34);
            this.panel3.TabIndex = 16;
            // 
            // hidetext3a
            // 
            this.hidetext3a.AutoSize = true;
            this.hidetext3a.BackColor = System.Drawing.Color.White;
            this.hidetext3a.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hidetext3a.Location = new System.Drawing.Point(12, 7);
            this.hidetext3a.Name = "hidetext3a";
            this.hidetext3a.Size = new System.Drawing.Size(148, 16);
            this.hidetext3a.TabIndex = 3;
            this.hidetext3a.Text = "Re-enter new password";
            // 
            // confirmpass
            // 
            this.confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpass.Dock = System.Windows.Forms.DockStyle.Right;
            this.confirmpass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass.Location = new System.Drawing.Point(9, 0);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.PasswordChar = '•';
            this.confirmpass.Size = new System.Drawing.Size(279, 34);
            this.confirmpass.TabIndex = 1;
            this.confirmpass.TextChanged += new System.EventHandler(this.confirmpass_TextChanged);
            this.confirmpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmpass_KeyDown);
            this.confirmpass.MouseEnter += new System.EventHandler(this.confirmpass_MouseEnter);
            this.confirmpass.MouseLeave += new System.EventHandler(this.confirmpass_MouseLeave);
            // 
            // header7
            // 
            this.header7.AutoSize = true;
            this.header7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.header7.Location = new System.Drawing.Point(81, 202);
            this.header7.Name = "header7";
            this.header7.Size = new System.Drawing.Size(129, 18);
            this.header7.TabIndex = 15;
            this.header7.Text = "Confirm password:";
            // 
            // header4
            // 
            this.header4.AutoSize = true;
            this.header4.BackColor = System.Drawing.Color.Transparent;
            this.header4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.header4.Location = new System.Drawing.Point(132, 11);
            this.header4.Name = "header4";
            this.header4.Size = new System.Drawing.Size(191, 24);
            this.header4.TabIndex = 17;
            this.header4.Text = "CREATE ACCOUNT";
            // 
            // showpass_rg
            // 
            this.showpass_rg.AutoSize = true;
            this.showpass_rg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass_rg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.showpass_rg.Location = new System.Drawing.Point(84, 273);
            this.showpass_rg.Name = "showpass_rg";
            this.showpass_rg.Size = new System.Drawing.Size(120, 20);
            this.showpass_rg.TabIndex = 18;
            this.showpass_rg.Text = "Show Password";
            this.showpass_rg.UseVisualStyleBackColor = true;
            this.showpass_rg.CheckedChanged += new System.EventHandler(this.showpass_rg_CheckedChanged);
            // 
            // UC4_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showpass_rg);
            this.Controls.Add(this.header4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.header7);
            this.Controls.Add(this.header6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.registerbt);
            this.Controls.Add(this.header5);
            this.Controls.Add(this.panel1);
            this.Name = "UC4_Register";
            this.Size = new System.Drawing.Size(454, 377);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label header5;
        private System.Windows.Forms.Label hidetext1a;
        private System.Windows.Forms.TextBox username_rg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header6;
        private System.Windows.Forms.Label hidetext2a;
        private System.Windows.Forms.TextBox pass_rg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button registerbt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label hidetext3a;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Label header7;
        private System.Windows.Forms.Label header4;
        private System.Windows.Forms.CheckBox showpass_rg;
    }
}
