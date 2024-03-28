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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTrips));
            CustomerBookings = new ListBox();
            cancelbooking = new Button();
            back = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CustomerBookings
            // 
            CustomerBookings.FormattingEnabled = true;
            CustomerBookings.ItemHeight = 15;
            CustomerBookings.Location = new Point(260, 240);
            CustomerBookings.Name = "CustomerBookings";
            CustomerBookings.Size = new Size(504, 349);
            CustomerBookings.TabIndex = 0;
            // 
            // cancelbooking
            // 
            cancelbooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelbooking.Location = new Point(260, 642);
            cancelbooking.Name = "cancelbooking";
            cancelbooking.Size = new Size(240, 75);
            cancelbooking.TabIndex = 1;
            cancelbooking.Text = "Cancel Booking";
            cancelbooking.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            back.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.Location = new Point(524, 642);
            back.Name = "back";
            back.Size = new Size(240, 75);
            back.TabIndex = 2;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
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
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ViewTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(back);
            Controls.Add(cancelbooking);
            Controls.Add(CustomerBookings);
            Name = "ViewTrips";
            Text = "ViewTrips";
            Load += ViewTrips_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomerBookings;
        private Button cancelbooking;
        private Button back;
        private PictureBox pictureBox1;
    }
}