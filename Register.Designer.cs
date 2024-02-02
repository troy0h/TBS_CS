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
            SuspendLayout();
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(453, 310);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(136, 24);
            UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(453, 369);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '☠';
            PasswordInput.Size = new Size(136, 24);
            PasswordInput.TabIndex = 1;
            // 
            // FullnameInput
            // 
            FullnameInput.Location = new Point(453, 425);
            FullnameInput.Name = "FullnameInput";
            FullnameInput.Size = new Size(136, 24);
            FullnameInput.TabIndex = 2;
            // 
            // PhoneNumberInput
            // 
            PhoneNumberInput.Location = new Point(453, 482);
            PhoneNumberInput.Name = "PhoneNumberInput";
            PhoneNumberInput.Size = new Size(136, 24);
            PhoneNumberInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 308);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 370);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(364, 426);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 6;
            label3.Text = "Full name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(337, 483);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 7;
            label4.Text = "Phone number:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(453, 535);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 25);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(561, 580);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(390, 580);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 10;
            button2.Text = "Take me back!";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(359, 537);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 11;
            label5.Text = "User type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(309, 201);
            label6.Name = "label6";
            label6.Size = new Size(411, 90);
            label6.TabIndex = 12;
            label6.Text = "Registration";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
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
    }
}