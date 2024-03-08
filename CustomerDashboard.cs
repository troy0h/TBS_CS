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
    public partial class CustomerDashboard : Form
    {
        public int id { get; set; }

        public CustomerDashboard(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new BookTrip(id);
            form.Show();
            this.Hide();
        }

        private void CustomerDelivery_Click(object sender, EventArgs e)
        {
            Form form = new BookDelivery(id);
            form.Show();
            this.Hide();
        }

        private void CustomerView_Click(object sender, EventArgs e)
        {
            Form form = new ViewTrips(id);
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form form = new TaxiMenu();
            form.Show();
            this.Hide();
        }
    }
}
