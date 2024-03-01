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
    public partial class DriverDashboard : Form
    {
        public DriverDashboard()
        {
            InitializeComponent();
        }

        private void DriverBooking_Click(object sender, EventArgs e)
        {
            Form form = new TaxiMenu();
            form.Show();
            this.Hide();
        }

        private void ChooseJob_Click(object sender, EventArgs e)
        {
            Form form = new ChooseJobs();
            form.Show();
            this.Hide();
        }
    }
}
