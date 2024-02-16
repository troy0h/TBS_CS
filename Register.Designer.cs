namespace TBS_CS
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            FullnameInput = new TextBox();
            PhoneNumberInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(491, 311);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(136, 24);
            UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(491, 351);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(136, 24);
            PasswordInput.TabIndex = 1;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // FullnameInput
            // 
            FullnameInput.Location = new Point(491, 391);
            FullnameInput.Name = "FullnameInput";
            FullnameInput.Size = new Size(136, 24);
            FullnameInput.TabIndex = 2;
            // 
            // PhoneNumberInput
            // 
            PhoneNumberInput.Location = new Point(491, 431);
            PhoneNumberInput.Name = "PhoneNumberInput";
            PhoneNumberInput.Size = new Size(136, 24);
            PhoneNumberInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 312);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 352);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 392);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 6;
            label3.Text = "Full name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(372, 432);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 7;
            label4.Text = "Phone number:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(491, 471);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 25);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(396, 518);
            button1.Name = "button1";
            button1.Size = new Size(240, 75);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(396, 599);
            button2.Name = "button2";
            button2.Size = new Size(240, 75);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(397, 473);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 11;
            label5.Text = "User type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(309, 205);
            label6.Name = "label6";
            label6.Size = new Size(411, 90);
            label6.TabIndex = 12;
            label6.Text = "Registration";
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
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneNumberInput);
            Controls.Add(FullnameInput);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private TextBox FullnameInput;
        private TextBox PhoneNumberInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}