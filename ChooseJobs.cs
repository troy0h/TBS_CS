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
    public partial class ChooseJobs : Form
    {
        public ChooseJobs()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new DriverDashboard();
            form.Show();
            this.Hide();
        }
    }
}
