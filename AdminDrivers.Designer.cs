﻿namespace TBS_CS
{
    partial class AdminDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDrivers));
            back = new Button();
            DriverList = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.Location = new Point(392, 552);
            back.Name = "back";
            back.Size = new Size(240, 75);
            back.TabIndex = 7;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // DriverList
            // 
            DriverList.FormattingEnabled = true;
            DriverList.ItemHeight = 15;
            DriverList.Location = new Point(260, 272);
            DriverList.Name = "DriverList";
            DriverList.Size = new Size(504, 274);
            DriverList.TabIndex = 8;
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
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AdminDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(DriverList);
            Controls.Add(back);
            Name = "AdminDrivers";
            Text = "AdminDrivers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private ListBox DriverList;
        private PictureBox pictureBox1;
    }
}