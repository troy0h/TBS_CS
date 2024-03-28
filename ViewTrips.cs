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
    public partial class ViewTrips : Form
    {
        public int id { get; set; }
        public ViewTrips(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ViewTrips_Load(object sender, EventArgs e)
        {
            List<string> UserTrips = SQL.GetUserTrips(this.id);
            foreach (var trip in UserTrips)
            {
                CustomerBookings.Items.Add(trip);
            }
        }

        private void cancelbooking_Click(object sender, EventArgs e)
        {
            string text = CustomerBookings.SelectedItem.ToString();
            string[] textArray = text.Split(", ");
            SQL.DeleteTrip(textArray[1]);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new CustomerDashboard(id);
            form.Show();
            this.Hide();
        }
    }
}
