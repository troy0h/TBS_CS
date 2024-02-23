using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TBS_CS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Populate combo box
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "--select--";
            comboBox1.Items.Insert(0, "Customer");
            comboBox1.Items.Insert(1, "Driver");
            comboBox1.Items.Insert(2, "Admin");
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
            // Register Button
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
            if (string.IsNullOrEmpty(FullnameInput.Text))
            {
                MessageBox.Show("Full Name box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(PhoneNumberInput.Text))
            {
                MessageBox.Show("Phone Number box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item for user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Attempt to make account
            SQL.CreateUser(UsernameInput.Text, PasswordInput.Text, FullnameInput.Text, PhoneNumberInput.Text, comboBox1.Text);
            MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
