namespace TBS_CS
{
    partial class BookDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDelivery));
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            DropOffAddBox = new TextBox();
            DateBox = new TextBox();
            TimeBox = new TextBox();
            PickUpAddBox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Comic Sans MS", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(487, 392);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 25);
            comboBox1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Comic Sans MS", 12F);
            label7.Location = new Point(396, 394);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 27;
            label7.Text = "Taxi Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Comic Sans MS", 12F);
            label6.Location = new Point(436, 353);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 26;
            label6.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Comic Sans MS", 12F);
            label5.Location = new Point(436, 313);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 25;
            label5.Text = "Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Comic Sans MS", 12F);
            label2.Location = new Point(325, 473);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 24;
            label2.Text = "Drop Off Post Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(340, 433);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 23;
            label1.Text = "Pick Up Post Code:";
            // 
            // DropOffAddBox
            // 
            DropOffAddBox.Font = new Font("Comic Sans MS", 9F);
            DropOffAddBox.Location = new Point(487, 472);
            DropOffAddBox.Name = "DropOffAddBox";
            DropOffAddBox.Size = new Size(145, 24);
            DropOffAddBox.TabIndex = 22;
            // 
            // DateBox
            // 
            DateBox.Font = new Font("Comic Sans MS", 9F);
            DateBox.Location = new Point(487, 352);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(145, 24);
            DateBox.TabIndex = 21;
            // 
            // TimeBox
            // 
            TimeBox.Font = new Font("Comic Sans MS", 9F);
            TimeBox.Location = new Point(487, 312);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(145, 24);
            TimeBox.TabIndex = 20;
            // 
            // PickUpAddBox
            // 
            PickUpAddBox.Font = new Font("Comic Sans MS", 9F);
            PickUpAddBox.Location = new Point(487, 432);
            PickUpAddBox.Name = "PickUpAddBox";
            PickUpAddBox.Size = new Size(145, 24);
            PickUpAddBox.TabIndex = 19;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F);
            button2.Location = new Point(392, 519);
            button2.Name = "button2";
            button2.Size = new Size(240, 75);
            button2.TabIndex = 18;
            button2.Text = "Request Delivery";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F);
            button1.Location = new Point(392, 600);
            button1.Name = "button1";
            button1.Size = new Size(240, 75);
            button1.TabIndex = 17;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // BookDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
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
            Controls.Add(pictureBox1);
            Name = "BookDelivery";
            Text = "BookDelivery";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion 

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox DropOffAddBox;
        private TextBox DateBox;
        private TextBox TimeBox;
        private TextBox PickUpAddBox;
        private Button button2;
        private Button button1;
    }
}