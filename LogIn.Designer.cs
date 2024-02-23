namespace TBS_CS
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(393, 237);
            label6.Name = "label6";
            label6.Size = new Size(238, 90);
            label6.TabIndex = 25;
            label6.Text = "Log In";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(392, 561);
            button2.Name = "button2";
            button2.Size = new Size(240, 75);
            button2.TabIndex = 23;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(392, 480);
            button1.Name = "button1";
            button1.Size = new Size(240, 75);
            button1.TabIndex = 22;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(392, 399);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 18;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 348);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 17;
            label1.Text = "Username:";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(487, 399);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '☠';
            PasswordInput.Size = new Size(136, 23);
            PasswordInput.TabIndex = 14;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(487, 350);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(136, 23);
            UsernameInput.TabIndex = 13;
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
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Name = "LogIn";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private PictureBox pictureBox1;
    }
}