namespace Water_Bills
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pass_lg = new System.Windows.Forms.TextBox();
            this.header1 = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.signinbt = new System.Windows.Forms.Button();
            this.hidetext2 = new System.Windows.Forms.Label();
            this.showpass_lg = new System.Windows.Forms.CheckBox();
            this.background_lg = new System.Windows.Forms.PictureBox();
            this.logo_lg = new System.Windows.Forms.PictureBox();
            this.username_lg = new System.Windows.Forms.TextBox();
            this.hidetext1 = new System.Windows.Forms.Label();
            this.textboxpanel1 = new System.Windows.Forms.Panel();
            this.textboxpanel2 = new System.Windows.Forms.Panel();
            this.header3 = new System.Windows.Forms.Label();
            this.registerlink = new System.Windows.Forms.Label();
            this.exit_lg = new System.Windows.Forms.Button();
            this.minimize_lg = new System.Windows.Forms.Button();
            this.exit_rg = new System.Windows.Forms.Button();
            this.RegisterForm = new Water_Bills.UC4_Register();
            ((System.ComponentModel.ISupportInitialize)(this.background_lg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_lg)).BeginInit();
            this.textboxpanel1.SuspendLayout();
            this.textboxpanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pass_lg
            // 
            this.pass_lg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_lg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pass_lg.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lg.Location = new System.Drawing.Point(9, 0);
            this.pass_lg.Name = "pass_lg";
            this.pass_lg.PasswordChar = '•';
            this.pass_lg.Size = new System.Drawing.Size(279, 34);
            this.pass_lg.TabIndex = 1;
            this.pass_lg.TextChanged += new System.EventHandler(this.pass_lg_TextChanged);
            this.pass_lg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_lg_KeyDown);
            this.pass_lg.MouseEnter += new System.EventHandler(this.pass_lg_MouseEnter);
            this.pass_lg.MouseLeave += new System.EventHandler(this.pass_lg_MouseLeave);
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.header1.Location = new System.Drawing.Point(80, 193);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(80, 18);
            this.header1.TabIndex = 2;
            this.header1.Text = "Username:";
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.header2.Location = new System.Drawing.Point(80, 273);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(74, 18);
            this.header2.TabIndex = 3;
            this.header2.Text = "Password:";
            // 
            // signinbt
            // 
            this.signinbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.signinbt.FlatAppearance.BorderSize = 0;
            this.signinbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinbt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signinbt.Location = new System.Drawing.Point(84, 384);
            this.signinbt.Name = "signinbt";
            this.signinbt.Size = new System.Drawing.Size(290, 51);
            this.signinbt.TabIndex = 4;
            this.signinbt.Text = "SIGN IN";
            this.signinbt.UseVisualStyleBackColor = false;
            this.signinbt.Click += new System.EventHandler(this.signinbt_Click);
            // 
            // hidetext2
            // 
            this.hidetext2.AutoSize = true;
            this.hidetext2.BackColor = System.Drawing.Color.White;
            this.hidetext2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hidetext2.Location = new System.Drawing.Point(12, 7);
            this.hidetext2.Name = "hidetext2";
            this.hidetext2.Size = new System.Drawing.Size(100, 16);
            this.hidetext2.TabIndex = 3;
            this.hidetext2.Text = "Enter password";
            // 
            // showpass_lg
            // 
            this.showpass_lg.AutoSize = true;
            this.showpass_lg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass_lg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.showpass_lg.Location = new System.Drawing.Point(84, 342);
            this.showpass_lg.Name = "showpass_lg";
            this.showpass_lg.Size = new System.Drawing.Size(120, 20);
            this.showpass_lg.TabIndex = 7;
            this.showpass_lg.Text = "Show Password";
            this.showpass_lg.UseVisualStyleBackColor = true;
            this.showpass_lg.CheckedChanged += new System.EventHandler(this.showpass_lg_CheckedChanged);
            // 
            // background_lg
            // 
            this.background_lg.Image = ((System.Drawing.Image)(resources.GetObject("background_lg.Image")));
            this.background_lg.Location = new System.Drawing.Point(-323, -62);
            this.background_lg.Name = "background_lg";
            this.background_lg.Size = new System.Drawing.Size(944, 786);
            this.background_lg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_lg.TabIndex = 8;
            this.background_lg.TabStop = false;
            this.background_lg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.background_lg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            // 
            // logo_lg
            // 
            this.logo_lg.Image = ((System.Drawing.Image)(resources.GetObject("logo_lg.Image")));
            this.logo_lg.Location = new System.Drawing.Point(147, 111);
            this.logo_lg.Name = "logo_lg";
            this.logo_lg.Size = new System.Drawing.Size(157, 68);
            this.logo_lg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_lg.TabIndex = 9;
            this.logo_lg.TabStop = false;
            // 
            // username_lg
            // 
            this.username_lg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_lg.Dock = System.Windows.Forms.DockStyle.Right;
            this.username_lg.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.username_lg.Location = new System.Drawing.Point(9, 0);
            this.username_lg.Name = "username_lg";
            this.username_lg.Size = new System.Drawing.Size(279, 34);
            this.username_lg.TabIndex = 1;
            this.username_lg.TextChanged += new System.EventHandler(this.username_lg_TextChanged);
            this.username_lg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_lg_KeyDown);
            this.username_lg.MouseEnter += new System.EventHandler(this.username_lg_MouseEnter);
            this.username_lg.MouseLeave += new System.EventHandler(this.username_lg_MouseLeave);
            // 
            // hidetext1
            // 
            this.hidetext1.AutoSize = true;
            this.hidetext1.BackColor = System.Drawing.Color.White;
            this.hidetext1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hidetext1.Location = new System.Drawing.Point(12, 7);
            this.hidetext1.Name = "hidetext1";
            this.hidetext1.Size = new System.Drawing.Size(101, 16);
            this.hidetext1.TabIndex = 2;
            this.hidetext1.Text = "Enter username";
            // 
            // textboxpanel1
            // 
            this.textboxpanel1.BackColor = System.Drawing.Color.White;
            this.textboxpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxpanel1.Controls.Add(this.hidetext1);
            this.textboxpanel1.Controls.Add(this.username_lg);
            this.textboxpanel1.Location = new System.Drawing.Point(84, 214);
            this.textboxpanel1.Name = "textboxpanel1";
            this.textboxpanel1.Size = new System.Drawing.Size(290, 34);
            this.textboxpanel1.TabIndex = 10;
            // 
            // textboxpanel2
            // 
            this.textboxpanel2.BackColor = System.Drawing.Color.White;
            this.textboxpanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxpanel2.Controls.Add(this.hidetext2);
            this.textboxpanel2.Controls.Add(this.pass_lg);
            this.textboxpanel2.Location = new System.Drawing.Point(84, 294);
            this.textboxpanel2.Name = "textboxpanel2";
            this.textboxpanel2.Size = new System.Drawing.Size(290, 34);
            this.textboxpanel2.TabIndex = 11;
            // 
            // header3
            // 
            this.header3.AutoSize = true;
            this.header3.BackColor = System.Drawing.Color.Transparent;
            this.header3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.header3.Location = new System.Drawing.Point(120, 448);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(139, 16);
            this.header3.TabIndex = 12;
            this.header3.Text = "Don\'t have an account?";
            // 
            // registerlink
            // 
            this.registerlink.AutoSize = true;
            this.registerlink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerlink.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerlink.ForeColor = System.Drawing.Color.DimGray;
            this.registerlink.Location = new System.Drawing.Point(265, 448);
            this.registerlink.Name = "registerlink";
            this.registerlink.Size = new System.Drawing.Size(62, 16);
            this.registerlink.TabIndex = 13;
            this.registerlink.Text = "Register";
            this.registerlink.Click += new System.EventHandler(this.registerlink_Click);
            this.registerlink.MouseEnter += new System.EventHandler(this.registerlink_MouseEnter);
            this.registerlink.MouseLeave += new System.EventHandler(this.registerlink_MouseLeave);
            // 
            // exit_lg
            // 
            this.exit_lg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.exit_lg.FlatAppearance.BorderSize = 0;
            this.exit_lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_lg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.exit_lg.Location = new System.Drawing.Point(406, 8);
            this.exit_lg.Name = "exit_lg";
            this.exit_lg.Size = new System.Drawing.Size(40, 37);
            this.exit_lg.TabIndex = 15;
            this.exit_lg.Text = "X";
            this.exit_lg.UseVisualStyleBackColor = false;
            this.exit_lg.Click += new System.EventHandler(this.exit_lg_Click);
            this.exit_lg.MouseLeave += new System.EventHandler(this.exit_lg_MouseLeave);
            this.exit_lg.MouseHover += new System.EventHandler(this.exit_lg_MouseHover);
            // 
            // minimize_lg
            // 
            this.minimize_lg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.minimize_lg.FlatAppearance.BorderSize = 0;
            this.minimize_lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_lg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_lg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.minimize_lg.Location = new System.Drawing.Point(366, 8);
            this.minimize_lg.Name = "minimize_lg";
            this.minimize_lg.Size = new System.Drawing.Size(40, 37);
            this.minimize_lg.TabIndex = 16;
            this.minimize_lg.Text = "──";
            this.minimize_lg.UseVisualStyleBackColor = false;
            this.minimize_lg.Click += new System.EventHandler(this.minimize_lg_Click);
            this.minimize_lg.MouseEnter += new System.EventHandler(this.minimize_lg_MouseEnter);
            this.minimize_lg.MouseLeave += new System.EventHandler(this.minimize_lg_MouseLeave);
            // 
            // exit_rg
            // 
            this.exit_rg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.exit_rg.FlatAppearance.BorderSize = 0;
            this.exit_rg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_rg.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_rg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.exit_rg.Location = new System.Drawing.Point(398, 8);
            this.exit_rg.Name = "exit_rg";
            this.exit_rg.Size = new System.Drawing.Size(40, 37);
            this.exit_rg.TabIndex = 20;
            this.exit_rg.Text = "<";
            this.exit_rg.UseVisualStyleBackColor = false;
            this.exit_rg.Visible = false;
            this.exit_rg.Click += new System.EventHandler(this.exit_rg_Click);
            // 
            // RegisterForm
            // 
            this.RegisterForm.Location = new System.Drawing.Point(1, 97);
            this.RegisterForm.Name = "RegisterForm";
            this.RegisterForm.Size = new System.Drawing.Size(454, 377);
            this.RegisterForm.TabIndex = 21;
            this.RegisterForm.Visible = false;
            this.RegisterForm.VisibleChanged += new System.EventHandler(this.RegisterForm_VisibleChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(454, 640);
            this.Controls.Add(this.registerlink);
            this.Controls.Add(this.header3);
            this.Controls.Add(this.textboxpanel2);
            this.Controls.Add(this.textboxpanel1);
            this.Controls.Add(this.logo_lg);
            this.Controls.Add(this.showpass_lg);
            this.Controls.Add(this.signinbt);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.minimize_lg);
            this.Controls.Add(this.exit_lg);
            this.Controls.Add(this.exit_rg);
            this.Controls.Add(this.RegisterForm);
            this.Controls.Add(this.background_lg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterBills";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.background_lg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_lg)).EndInit();
            this.textboxpanel1.ResumeLayout(false);
            this.textboxpanel1.PerformLayout();
            this.textboxpanel2.ResumeLayout(false);
            this.textboxpanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pass_lg;
        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.Button signinbt;
        private System.Windows.Forms.CheckBox showpass_lg;
        private System.Windows.Forms.Label hidetext2;
        private System.Windows.Forms.PictureBox background_lg;
        private System.Windows.Forms.PictureBox logo_lg;
        private System.Windows.Forms.TextBox username_lg;
        private System.Windows.Forms.Label hidetext1;
        private System.Windows.Forms.Panel textboxpanel1;
        private System.Windows.Forms.Panel textboxpanel2;
        private System.Windows.Forms.Label header3;
        private System.Windows.Forms.Label registerlink;
        private System.Windows.Forms.Button exit_lg;
        private System.Windows.Forms.Button minimize_lg;
        private System.Windows.Forms.Button exit_rg;
        private UC4_Register RegisterForm;
    }
}