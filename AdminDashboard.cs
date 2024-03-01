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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new TaxiMenu();
            form.Show();
            this.Hide();
        }

        private void AdminBooking_Click(object sender, EventArgs e)
        {
            Form form = new AdminBookings();
            form.Show();
            this.Hide();
        }

        private void AdminDrivers_Click(object sender, EventArgs e)
        {
            Form form = new AdminDrivers();
            form.Show();
            this.Hide();
        }

        private void AdminCustomers_Click(object sender, EventArgs e)
        {
            Form form = new AdminCustomers();
            form.Show();
            this.Hide();
        }
    }
}
