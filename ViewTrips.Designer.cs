namespace TBS_CS
{
    partial class ViewTrips
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
            CustomerBookings = new ListBox();
            cancelbooking = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // CustomerBookings
            // 
            CustomerBookings.FormattingEnabled = true;
            CustomerBookings.ItemHeight = 15;
            CustomerBookings.Location = new Point(260, 229);
            CustomerBookings.Name = "CustomerBookings";
            CustomerBookings.Size = new Size(504, 349);
            CustomerBookings.TabIndex = 0;
            // 
            // cancelbooking
            // 
            cancelbooking.Location = new Point(260, 603);
            cancelbooking.Name = "cancelbooking";
            cancelbooking.Size = new Size(176, 101);
            cancelbooking.TabIndex = 1;
            cancelbooking.Text = "Cancel Booking";
            cancelbooking.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            back.Location = new Point(588, 603);
            back.Name = "back";
            back.Size = new Size(176, 101);
            back.TabIndex = 2;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // ViewTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(back);
            Controls.Add(cancelbooking);
            Controls.Add(CustomerBookings);
            Name = "ViewTrips";
            Text = "ViewTrips";
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomerBookings;
        private Button cancelbooking;
        private Button back;
    }
}