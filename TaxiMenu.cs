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
            form.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            form.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void TaxiMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }
    }
}
