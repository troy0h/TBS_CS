namespace TBS_CS
{
    partial class BookTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTrip));
            button1 = new Button();
            button2 = new Button();
            PickUpAddBox = new TextBox();
            TimeBox = new TextBox();
            DateBox = new TextBox();
            DropOffAddBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F);
            button1.Location = new Point(396, 599);
            button1.Name = "button1";
            button1.Size = new Size(240, 75);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F);
            button2.Location = new Point(396, 518);
            button2.Name = "button2";
            button2.Size = new Size(240, 75);
            button2.TabIndex = 1;
            button2.Text = "Request taxi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PickUpAddBox
            // 
            PickUpAddBox.Font = new Font("Comic Sans MS", 9F);
            PickUpAddBox.Location = new Point(491, 431);
            PickUpAddBox.Name = "PickUpAddBox";
            PickUpAddBox.Size = new Size(145, 24);
            PickUpAddBox.TabIndex = 3;
            // 
            // TimeBox
            // 
            TimeBox.Font = new Font("Comic Sans MS", 9F);
            TimeBox.Location = new Point(491, 311);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(145, 24);
            TimeBox.TabIndex = 5;
            // 
            // DateBox
            // 
            DateBox.Font = new Font("Comic Sans MS", 9F);
            DateBox.Location = new Point(491, 351);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(145, 24);
            DateBox.TabIndex = 6;
            // 
            // DropOffAddBox
            // 
            DropOffAddBox.Font = new Font("Comic Sans MS", 9F);
            DropOffAddBox.Location = new Point(491, 471);
            DropOffAddBox.Name = "DropOffAddBox";
            DropOffAddBox.Size = new Size(145, 24);
            DropOffAddBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(344, 432);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 9;
            label1.Text = "Pick Up Post Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Comic Sans MS", 12F);
            label2.Location = new Point(329, 472);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 10;
            label2.Text = "Drop Off Post Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Comic Sans MS", 12F);
            label5.Location = new Point(440, 312);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 13;
            label5.Text = "Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Comic Sans MS", 12F);
            label6.Location = new Point(440, 352);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 14;
            label6.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Comic Sans MS", 12F);
            label7.Location = new Point(400, 393);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 15;
            label7.Text = "Taxi Type:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Comic Sans MS", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(491, 391);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 25);
            comboBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.BackgroundImage = Properties.Resources.Taxi_logo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(396, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 222);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // BookTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DropOffAddBox);
            Controls.Add(DateBox);
            Controls.Add(TimeBox);
            Controls.Add(PickUpAddBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BookTrip";
            Text = "BookTrip";
            Load += BookTrip_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox PickUpAddBox;
        private TextBox TimeBox;
        private TextBox DateBox;
        private TextBox DropOffAddBox;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}