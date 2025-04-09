using System;
using System.Drawing;
using System.Windows.Forms;


namespace Water_Bills
{
    public partial class MainForm : Form
    {
        private RefreshHelper refresh;
        private Point _mouseLocation;
        private string loginUser;
        public MainForm(string username)
        {
            InitializeComponent();
            refresh = new RefreshHelper();
            loginUser = username;
        }


        // This method used for update welcome text.
        private void MainForm_Load(object sender, EventArgs e)
        {
            welcomeuser.Text = "Welcome " + loginUser + " to WaterBills!";
        }


        // These methods are used to switch between user controls
        private void homep_Click(object sender, EventArgs e)
        {
            sidepanel.Height = homep.Height;
            sidepanel.Top = homep.Top;
            welcome_page1.BringToFront();
            welcomeuser.BringToFront();
        }
        private void billmn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = billmn.Height;
            sidepanel.Top = billmn.Top;
            bill_management1.BringToFront();
            refresh.RefreshDataGridView(bill_management1.dataGridView1);
        }
        private void editlist_Click(object sender, EventArgs e)
        {
            editlist1.dataGridView2_CellClick(editlist1, new DataGridViewCellEventArgs(0, 0));
            sidepanel.Height = editlist.Height;
            sidepanel.Top = editlist.Top;
            editlist1.BringToFront();
            refresh.RefreshDataGridView(editlist1.dataGridView2);
        }
        private void logout_Click(object sender, EventArgs e)
        {
            sidepanel.Height = logout.Height;
            sidepanel.Top = logout.Top;
            var confirmResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.OK)
            {
                new LoginForm().Show();
                this.Close();
            }
        }


        // These methods is used to custom exit and minimize buttons
        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit_mf.BackColor = Color.Red;
            exit_mf.ForeColor = Color.White;
        }
        private void exit_mf_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit and log out?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void exit_mf_MouseLeave(object sender, EventArgs e)
        {
            exit_mf.ForeColor = Color.FromArgb(36, 99, 176);
            exit_mf.BackColor = Color.Transparent;
        }
        private void minimize_mf_MouseEnter(object sender, EventArgs e)
        {
            minimize_mf.BackColor = Color.FromArgb(36, 99, 176);
        }
        private void minimize_mf_MouseLeave(object sender, EventArgs e)
        {
            minimize_mf.BackColor = Color.Transparent;
        }
        private void minimize_mf_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // These methods is used to make the form draggable
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(e.X, e.Y);
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLocation.X;
                int dy = e.Location.Y - _mouseLocation.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}
