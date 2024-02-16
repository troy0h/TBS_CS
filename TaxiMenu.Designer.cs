namespace TBS_CS
{
    partial class TaxiMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxiMenu));
            LogIn = new Button();
            Register = new Button();
            Exit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.Anchor = AnchorStyles.None;
            LogIn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn.Location = new Point(392, 337);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(240, 75);
            LogIn.TabIndex = 0;
            LogIn.Text = "Log in";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // Register
            // 
            Register.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register.Location = new Point(392, 418);
            Register.Name = "Register";
            Register.Size = new Size(240, 78);
            Register.TabIndex = 1;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(392, 502);
            Exit.Name = "Exit";
            Exit.Size = new Size(240, 75);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 222);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // TaxiMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(Exit);
            Controls.Add(Register);
            Controls.Add(LogIn);
            Name = "TaxiMenu";
            Text = "Taxi Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LogIn;
        private Button Register;
        private Button Exit;
        private PictureBox pictureBox1;
    }
}