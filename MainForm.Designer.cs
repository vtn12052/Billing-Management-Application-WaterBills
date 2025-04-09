namespace Water_Bills
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.editlist = new System.Windows.Forms.Button();
            this.billmn = new System.Windows.Forms.Button();
            this.homep = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.minimize_mf = new System.Windows.Forms.Button();
            this.exit_mf = new System.Windows.Forms.Button();
            this.welcome_page1 = new Water_Bills.UC1_HomePage();
            this.editlist1 = new Water_Bills.UC3_EditList();
            this.bill_management1 = new Water_Bills.UC2_BillsManagement();
            this.welcomeuser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 674);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 674);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.sidepanel);
            this.panel3.Controls.Add(this.logout);
            this.panel3.Controls.Add(this.editlist);
            this.panel3.Controls.Add(this.billmn);
            this.panel3.Controls.Add(this.homep);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 674);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidepanel.Location = new System.Drawing.Point(0, 256);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(10, 58);
            this.sidepanel.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.Control;
            this.logout.Location = new System.Drawing.Point(-3, 488);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(221, 51);
            this.logout.TabIndex = 5;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // editlist
            // 
            this.editlist.FlatAppearance.BorderSize = 0;
            this.editlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editlist.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlist.ForeColor = System.Drawing.SystemColors.Control;
            this.editlist.Location = new System.Drawing.Point(-3, 410);
            this.editlist.Name = "editlist";
            this.editlist.Size = new System.Drawing.Size(221, 51);
            this.editlist.TabIndex = 4;
            this.editlist.Text = "Edit Customer List";
            this.editlist.UseVisualStyleBackColor = true;
            this.editlist.Click += new System.EventHandler(this.editlist_Click);
            // 
            // billmn
            // 
            this.billmn.FlatAppearance.BorderSize = 0;
            this.billmn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billmn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billmn.ForeColor = System.Drawing.SystemColors.Control;
            this.billmn.Location = new System.Drawing.Point(-3, 333);
            this.billmn.Name = "billmn";
            this.billmn.Size = new System.Drawing.Size(221, 51);
            this.billmn.TabIndex = 1;
            this.billmn.Text = "Bill Management";
            this.billmn.UseVisualStyleBackColor = true;
            this.billmn.Click += new System.EventHandler(this.billmn_Click);
            // 
            // homep
            // 
            this.homep.FlatAppearance.BorderSize = 0;
            this.homep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homep.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homep.ForeColor = System.Drawing.SystemColors.Control;
            this.homep.Location = new System.Drawing.Point(-3, 260);
            this.homep.Name = "homep";
            this.homep.Size = new System.Drawing.Size(221, 51);
            this.homep.TabIndex = 3;
            this.homep.Text = "Home Page";
            this.homep.UseVisualStyleBackColor = true;
            this.homep.Click += new System.EventHandler(this.homep_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.welcomeuser);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.welcome_page1);
            this.panel5.Controls.Add(this.editlist1);
            this.panel5.Controls.Add(this.bill_management1);
            this.panel5.Location = new System.Drawing.Point(218, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1193, 639);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(367, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.minimize_mf);
            this.panel4.Controls.Add(this.exit_mf);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(218, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 37);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // minimize_mf
            // 
            this.minimize_mf.BackColor = System.Drawing.Color.Transparent;
            this.minimize_mf.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_mf.FlatAppearance.BorderSize = 0;
            this.minimize_mf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_mf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_mf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.minimize_mf.Location = new System.Drawing.Point(1098, 0);
            this.minimize_mf.Name = "minimize_mf";
            this.minimize_mf.Size = new System.Drawing.Size(40, 37);
            this.minimize_mf.TabIndex = 18;
            this.minimize_mf.Text = "──";
            this.minimize_mf.UseVisualStyleBackColor = false;
            this.minimize_mf.Click += new System.EventHandler(this.minimize_mf_Click);
            this.minimize_mf.MouseEnter += new System.EventHandler(this.minimize_mf_MouseEnter);
            this.minimize_mf.MouseLeave += new System.EventHandler(this.minimize_mf_MouseLeave);
            // 
            // exit_mf
            // 
            this.exit_mf.BackColor = System.Drawing.Color.Transparent;
            this.exit_mf.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_mf.FlatAppearance.BorderSize = 0;
            this.exit_mf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_mf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_mf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.exit_mf.Location = new System.Drawing.Point(1138, 0);
            this.exit_mf.Name = "exit_mf";
            this.exit_mf.Size = new System.Drawing.Size(40, 37);
            this.exit_mf.TabIndex = 17;
            this.exit_mf.Text = "X";
            this.exit_mf.UseVisualStyleBackColor = false;
            this.exit_mf.Click += new System.EventHandler(this.exit_mf_Click);
            this.exit_mf.MouseLeave += new System.EventHandler(this.exit_mf_MouseLeave);
            this.exit_mf.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // welcome_page1
            // 
            this.welcome_page1.Location = new System.Drawing.Point(0, 12);
            this.welcome_page1.Name = "welcome_page1";
            this.welcome_page1.Size = new System.Drawing.Size(1193, 652);
            this.welcome_page1.TabIndex = 8;
            // 
            // editlist1
            // 
            this.editlist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editlist1.Location = new System.Drawing.Point(0, 0);
            this.editlist1.Name = "editlist1";
            this.editlist1.Size = new System.Drawing.Size(1193, 639);
            this.editlist1.TabIndex = 3;
            // 
            // bill_management1
            // 
            this.bill_management1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_management1.Location = new System.Drawing.Point(0, 0);
            this.bill_management1.Name = "bill_management1";
            this.bill_management1.Size = new System.Drawing.Size(1193, 639);
            this.bill_management1.TabIndex = 0;
            // 
            // welcomeuser
            // 
            this.welcomeuser.AutoSize = true;
            this.welcomeuser.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(176)))));
            this.welcomeuser.Location = new System.Drawing.Point(499, 212);
            this.welcomeuser.Name = "welcomeuser";
            this.welcomeuser.Size = new System.Drawing.Size(362, 35);
            this.welcomeuser.TabIndex = 9;
            this.welcomeuser.Text = "Welcome @user to WaterBills!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 674);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterBills";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UC2_BillsManagement bill_management1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button billmn;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button editlist;
        private System.Windows.Forms.Button homep;
        private UC3_EditList editlist1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UC1_HomePage welcome_page1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button minimize_mf;
        private System.Windows.Forms.Button exit_mf;
        private System.Windows.Forms.Label welcomeuser;
    }
}

