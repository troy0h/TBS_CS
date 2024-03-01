namespace TBS_CS
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            CustomerBook = new Button();
            CustomerView = new Button();
            CustomerDelivery = new Button();
            logout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CustomerBook
            // 
            CustomerBook.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerBook.Location = new Point(392, 326);
            CustomerBook.Name = "CustomerBook";
            CustomerBook.Size = new Size(240, 75);
            CustomerBook.TabIndex = 0;
            CustomerBook.Text = "Book Trip";
            CustomerBook.UseVisualStyleBackColor = true;
            CustomerBook.Click += button1_Click;
            // 
            // CustomerView
            // 
            CustomerView.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerView.Location = new Point(392, 407);
            CustomerView.Name = "CustomerView";
            CustomerView.Size = new Size(240, 75);
            CustomerView.TabIndex = 2;
            CustomerView.Text = "View Trips";
            CustomerView.UseVisualStyleBackColor = true;
            // 
            // CustomerDelivery
            // 
            CustomerDelivery.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerDelivery.Location = new Point(392, 245);
            CustomerDelivery.Name = "CustomerDelivery";
            CustomerDelivery.Size = new Size(240, 75);
            CustomerDelivery.TabIndex = 3;
            CustomerDelivery.Text = "Book Delivery";
            CustomerDelivery.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.Location = new Point(392, 488);
            logout.Name = "logout";
            logout.Size = new Size(240, 75);
            logout.TabIndex = 4;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = true;
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
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(logout);
            Controls.Add(CustomerDelivery);
            Controls.Add(CustomerView);
            Controls.Add(CustomerBook);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CustomerBook;
        private Button CustomerView;
        private Button CustomerDelivery;
        private Button logout;
        private PictureBox pictureBox1;
    }
}