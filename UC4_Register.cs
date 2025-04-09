using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Water_Bills
{
    public partial class UC4_Register : UserControl
    {
        private Point _mouseLocation;
        public UC4_Register()
        {
            InitializeComponent();
            registerbt.KeyPress += new KeyPressEventHandler(registerbt_KeyPress);
        }


        // These methods are used to custom register button
        public void registerbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_rg.Text) || string.IsNullOrWhiteSpace(pass_rg.Text) || string.IsNullOrWhiteSpace(confirmpass.Text))
            {
                MessageBox.Show("Please enter the required information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pass_rg.Text == confirmpass.Text)
            {
                using (SqlConnection con = new SqlConnection("Data Source=KERO-LAPTOP; Initial Catalog=waterbill; Integrated Security=True; Encrypt=False"))
                {
                    con.Open();
                    using (SqlCommand checkuser = new SqlCommand("SELECT COUNT(*) FROM useraccount WHERE username = @user", con))
                    {
                        checkuser.Parameters.AddWithValue("@user", username_rg.Text);
                        int count = (int)checkuser.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already used", "Please try another username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            username_rg.Clear();
                            pass_rg.Clear();
                            confirmpass.Clear();
                            return;
                        }
                    }
                    using (SqlCommand register = new SqlCommand("INSERT INTO useraccount (username, password) VALUES (@user, @pass)", con))
                    {
                        register.Parameters.AddWithValue("@user", username_rg.Text);
                        register.Parameters.AddWithValue("@pass", pass_rg.Text);
                        register.ExecuteNonQuery();
                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pass_rg.Clear();
                confirmpass.Clear();
                return;
            }
        }
        private void HandleEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                registerbt_Click(sender, e);
        }
        private void username_rg_KeyDown(object sender, KeyEventArgs e)
        {
            HandleEnterKey(sender, e);
            if (e.KeyCode == Keys.Down)
            {
                pass_rg.Focus();
            }
        }
        private void pass_rg_KeyDown(object sender, KeyEventArgs e)
        {
            HandleEnterKey(sender, e);
            if (e.KeyCode == Keys.Down)
            {
                confirmpass.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                username_rg.Focus();
            }
        }
        private void confirmpass_KeyDown(object sender, KeyEventArgs e)
        {
            HandleEnterKey(sender, e);
            if (e.KeyCode == Keys.Up)
            {
                pass_rg.Focus();
            }
        }



        // These methods used for show and hidden elements
        private void showpass_rg_CheckedChanged(object sender, EventArgs e)
        {
            pass_rg.PasswordChar = showpass_rg.Checked ? '\0' : '•';
            confirmpass.PasswordChar = showpass_rg.Checked ? '\0' : '•';
            confirmpass.Focus();
        }
        private void username_rg_TextChanged(object sender, EventArgs e)
        {
            hidetext1a.Visible = string.IsNullOrWhiteSpace(username_rg.Text);
        }
        private void pass_rg_TextChanged(object sender, EventArgs e)
        {
            hidetext2a.Visible = string.IsNullOrWhiteSpace(pass_rg.Text);
        }
        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            hidetext3a.Visible = string.IsNullOrWhiteSpace(confirmpass.Text);
        }
        private void username_rg_MouseEnter(object sender, EventArgs e)
        {
            hidetext1a.SendToBack();
            hidetext2a.BringToFront();
            hidetext3a.BringToFront();
        }
        private void pass_rg_MouseEnter(object sender, EventArgs e)
        {
            hidetext2a.SendToBack();
            hidetext1a.BringToFront();
            hidetext3a.BringToFront();
        }
        private void confirmpass_MouseEnter(object sender, EventArgs e)
        {
            hidetext3a.SendToBack();
            hidetext1a.BringToFront();
            hidetext2a.BringToFront();
        }
        private void username_rg_MouseLeave(object sender, EventArgs e)
        {
            hidetext1a.BringToFront();
        }
        private void pass_rg_MouseLeave(object sender, EventArgs e)
        {
            hidetext2a.BringToFront();
        }
        private void confirmpass_MouseLeave(object sender, EventArgs e)
        {
            hidetext3a.BringToFront();
        }



        private void registerbt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                registerbt_Click(sender, e);
            }
        }
    }
}
