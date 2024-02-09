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
    public partial class TaxiMenu : Form
    {
        public TaxiMenu()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Form form = new LogIn();
            this.Hide();
            form.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            this.Hide();
            form.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
