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
            AdminBooking = new Button();
            AdminDrivers = new Button();
            AdminCustomers = new Button();
            SuspendLayout();
            // 
            // AdminBooking
            // 
            AdminBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminBooking.Location = new Point(383, 287);
            AdminBooking.Name = "AdminBooking";
            AdminBooking.Size = new Size(135, 129);
            AdminBooking.TabIndex = 2;
            AdminBooking.Text = "View Bookings";
            AdminBooking.UseVisualStyleBackColor = true;
            // 
            // AdminDrivers
            // 
            AdminDrivers.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminDrivers.Location = new Point(549, 287);
            AdminDrivers.Name = "AdminDrivers";
            AdminDrivers.Size = new Size(135, 129);
            AdminDrivers.TabIndex = 3;
            AdminDrivers.Text = "View Drivers";
            AdminDrivers.UseVisualStyleBackColor = true;
            // 
            // AdminCustomers
            // 
            AdminCustomers.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminCustomers.Location = new Point(469, 422);
            AdminCustomers.Name = "AdminCustomers";
            AdminCustomers.Size = new Size(135, 129);
            AdminCustomers.TabIndex = 4;
            AdminCustomers.Text = "View Customers";
            AdminCustomers.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(AdminCustomers);
            Controls.Add(AdminDrivers);
            Controls.Add(AdminBooking);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AdminBooking;
        private Button AdminDrivers;
        private Button AdminCustomers;
    }
}