﻿using System;
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
        public AdminBookings()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new AdminDashboard();
            form.Show();
            this.Hide();
        }
    }
}
