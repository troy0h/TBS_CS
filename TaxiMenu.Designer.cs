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
            LogIn = new Button();
            Register = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn.Location = new Point(480, 480);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(193, 177);
            LogIn.TabIndex = 0;
            LogIn.Text = "Log in";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // Register
            // 
            Register.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register.Location = new Point(272, 480);
            Register.Name = "Register";
            Register.Size = new Size(193, 177);
            Register.TabIndex = 1;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(921, 651);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 66);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // TaxiMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(Exit);
            Controls.Add(Register);
            Controls.Add(LogIn);
            Name = "TaxiMenu";
            Text = "Taxi Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button LogIn;
        private Button Register;
        private Button Exit;
    }
}