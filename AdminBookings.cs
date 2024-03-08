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
    public partial class AdminBookings : Form
    {
        public int id { get; set; }
        public AdminBookings(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new AdminDashboard(id);
            form.Show();
            this.Hide();
        }
    }
}
