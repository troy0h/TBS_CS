using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBS_CS
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Take Me Back button
            Form form = new TaxiMenu();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameInput.Text))
            {
                MessageBox.Show("Username box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(PasswordInput.Text))
            {
                MessageBox.Show("Password box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Try to get user
            string[] user = SQL.GetUser(UsernameInput.Text, PasswordInput.Text);

            if (user[0] == "fail")
            {
                MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Int32.Parse(user[0]);
            if (user[3] == "Customer")
            {
                Form form = new CustomerDashboard(id);
                form.Show();
                this.Hide();
            }
            else if (user[3] == "Driver")
            {
                Form form = new DriverDashboard(id);
                form.Show();
                this.Hide();
            }
            else if (user[3] == "Admin")
            {
                Form form = new AdminDashboard(id);
                form.Show();
                this.Hide();
            }
        }
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
