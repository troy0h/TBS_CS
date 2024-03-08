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
    public partial class BookTrip : Form
    {
        public int id { get; set; }

        public BookTrip(int id)
        {
            InitializeComponent();
        }

        private void BookTrip_Load(object sender, EventArgs e)
        {
            // Populate combo box
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "--select--";
            comboBox1.Items.Insert(0, "Regular");
            comboBox1.Items.Insert(1, "Executive");
            comboBox1.Items.Insert(2, "Minivan");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Back button
            Form form = new CustomerDashboard(id);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Request Taxi button
            if (string.IsNullOrEmpty(TimeBox.Text))
            {
                MessageBox.Show("Time box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(DateBox.Text))
            {
                MessageBox.Show("Date box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(DropOffAddBox.Text))
            {
                MessageBox.Show("Drop Off Address box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(PickUpAddBox.Text))
            {
                MessageBox.Show("Pick Up Address box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item for taxi type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If none fail, then attempt to make the type
            SQL.CreateTrip(PickUpAddBox.Text, DropOffAddBox.Text, TimeBox.Text, id);
        }        
    }
}
