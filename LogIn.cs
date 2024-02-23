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
            this.Hide();
            form.Show();
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
            if (user[2] == "Customer")
            {
                Form form = new CustomerDashboard();
                this.Hide();
                form.Show();
            }
            else if (user[2] == "Driver")
            {
                Form form = new DriverDashboard();
                this.Hide();
                form.Show();
            }
            else if (user[2] == "Admin")
            {
                Form form = new AdminDashboard();
                this.Hide();
                form.Show();
            }
        }
    }
}
