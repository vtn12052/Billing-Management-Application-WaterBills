using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace Water_Bills
{
    public partial class LoginForm : Form
    {
        [DllImport("GDI32.dll", EntryPoint = "CreateRoundRectRgn")] // This line imports the CreateRoundRectRgn function from GDI32.dll, which is used to create a rounded rectangle region for the form's shape.
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect, 
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);
        private Point _mouseLocation;
        public LoginForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 7, 7)); // This line creates a rounded rectangle region for the form's shape.
            signinbt.KeyPress += new KeyPressEventHandler(signinbt_KeyPress);
        }


        public string LoginUser { get; set; } // This property stores the username of the logged-in user.
        // These methods are used to custom sign in button:
        private void signinbt_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP; Initial Catalog=waterbill; Integrated Security=True; Encrypt=False"))
            {
                con.Open();
                using (SqlCommand login = new SqlCommand("SELECT * FROM useraccount WHERE username = @user AND password = @pass", con))
                {
                    login.Parameters.AddWithValue("@user", username_lg.Text);
                    login.Parameters.AddWithValue("@pass", pass_lg.Text);
                    using (SqlDataReader reader = login.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reader.Read();
                            string loginUser = reader["username"].ToString();
                            MainForm mainForm = new MainForm(loginUser);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            username_lg.Text = "";
                            pass_lg.Text = "";
                        }
                    }
                }
            }
        }
        private void username_lg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbt_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pass_lg.Focus();
            }
        }
        private void pass_lg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbt_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Up)
            {
                username_lg.Focus();
            }
        }


        // These methods are used to custom exit and minimize buttons:
        private void exit_lg_MouseHover(object sender, EventArgs e)
        {
            exit_lg.BackColor = Color.Red;
            exit_lg.ForeColor = Color.White;
        }
        private void exit_lg_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void exit_lg_MouseLeave(object sender, EventArgs e)
        {
            exit_lg.ForeColor = Color.FromArgb(36, 99, 176);
            exit_lg.BackColor = Color.FromArgb(224, 234, 241);
        }
        private void minimize_lg_MouseEnter(object sender, EventArgs e)
        {
            minimize_lg.BackColor = Color.FromArgb(186, 195, 202);
        }
        private void minimize_lg_MouseLeave(object sender, EventArgs e)
        {
            minimize_lg.BackColor = Color.FromArgb(224, 234, 241);
        }
        private void minimize_lg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // These methods are used to show and hide elements:
        private void username_lg_TextChanged(object sender, EventArgs e)
        {
            hidetext1.Visible = string.IsNullOrWhiteSpace(username_lg.Text);
        }
        private void pass_lg_TextChanged(object sender, EventArgs e)
        {
            hidetext2.Visible = string.IsNullOrWhiteSpace(pass_lg.Text);
        }
        private void username_lg_MouseEnter(object sender, EventArgs e)
        {
            hidetext1.SendToBack();
            hidetext2.BringToFront();
        }
        private void username_lg_MouseLeave(object sender, EventArgs e)
        {
            hidetext1.BringToFront();
        }
        private void pass_lg_MouseEnter(object sender, EventArgs e)
        {
            hidetext2.SendToBack();
            hidetext1.BringToFront();
        }
        private void pass_lg_MouseLeave(object sender, EventArgs e)
        {
            hidetext2.BringToFront();
        }
        private void showpass_lg_CheckedChanged(object sender, EventArgs e)
        {
            pass_lg.PasswordChar = showpass_lg.Checked ? '\0' : '•';
            pass_lg.Focus();
        }


        // These methods are used to switch between login and register forms:
        private void registerlink_Click(object sender, EventArgs e)
        {
            RegisterForm.BringToFront();
            RegisterForm.Visible = true;
            exit_lg.Visible = false;
            minimize_lg.Visible = false;
        }
        private void registerlink_MouseEnter(object sender, EventArgs e)
        {
            registerlink.ForeColor = Color.Blue;
            registerlink.Font = new Font("Tahoma", 8, FontStyle.Underline);
        }
        private void registerlink_MouseLeave(object sender, EventArgs e)
        {
            registerlink.ForeColor = Color.DimGray;
            registerlink.Font = new Font("Tahoma", 8, FontStyle.Bold);
        }

        // These methods are used to make the form draggable:
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mouseLocation = e.Location;
        }
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - _mouseLocation.X, this.Location.Y + e.Y - _mouseLocation.Y);
        }


        // These methods are used to custom goback button:
        private void exit_rg_Click(object sender, EventArgs e)
        {
            RegisterForm.Visible = false;
            exit_lg.Visible = true;
            minimize_lg.Visible = true;
        }
        private void exit_rg_MouseEnter(object sender, EventArgs e)
        {
            exit_rg.BackColor = Color.FromArgb(186, 195, 202);
        }
        private void exit_rg_MouseLeave(object sender, EventArgs e)
        {
            exit_rg.BackColor = Color.FromArgb(224, 234, 241);
        }
        private void RegisterForm_VisibleChanged(object sender, EventArgs e)
        {
            exit_rg.BringToFront();
            exit_rg.Visible = RegisterForm.Visible;
        }


        // This method used for press enter instead of button.
        private void signinbt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signinbt_Click(sender, e);
            }
        }
    }
}
