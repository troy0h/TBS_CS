namespace TBS_CS
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            AdminBooking = new Button();
            AdminDrivers = new Button();
            AdminCustomers = new Button();
            pictureBox1 = new PictureBox();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AdminBooking
            // 
            AdminBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminBooking.Location = new Point(392, 273);
            AdminBooking.Name = "AdminBooking";
            AdminBooking.Size = new Size(240, 75);
            AdminBooking.TabIndex = 2;
            AdminBooking.Text = "View Bookings";
            AdminBooking.UseVisualStyleBackColor = true;
            AdminBooking.Click += AdminBooking_Click;
            // 
            // AdminDrivers
            // 
            AdminDrivers.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminDrivers.Location = new Point(392, 364);
            AdminDrivers.Name = "AdminDrivers";
            AdminDrivers.Size = new Size(240, 75);
            AdminDrivers.TabIndex = 3;
            AdminDrivers.Text = "View Drivers";
            AdminDrivers.UseVisualStyleBackColor = true;
            AdminDrivers.Click += AdminDrivers_Click;
            // 
            // AdminCustomers
            // 
            AdminCustomers.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminCustomers.Location = new Point(392, 460);
            AdminCustomers.Name = "AdminCustomers";
            AdminCustomers.Size = new Size(240, 75);
            AdminCustomers.TabIndex = 4;
            AdminCustomers.Text = "View Customers";
            AdminCustomers.UseVisualStyleBackColor = true;
            AdminCustomers.Click += AdminCustomers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 222);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // back
            // 
            back.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.Location = new Point(392, 559);
            back.Name = "back";
            back.Size = new Size(240, 75);
            back.TabIndex = 6;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(back);
            Controls.Add(pictureBox1);
            Controls.Add(AdminCustomers);
            Controls.Add(AdminDrivers);
            Controls.Add(AdminBooking);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AdminBooking;
        private Button AdminDrivers;
        private Button AdminCustomers;
        private PictureBox pictureBox1;
        private Button back;
    }
}