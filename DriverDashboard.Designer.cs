﻿namespace TBS_CS
{
    partial class DriverDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverDashboard));
            DriverBooking = new Button();
            ChooseJob = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DriverBooking
            // 
            DriverBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DriverBooking.Location = new Point(392, 426);
            DriverBooking.Name = "DriverBooking";
            DriverBooking.Size = new Size(240, 75);
            DriverBooking.TabIndex = 1;
            DriverBooking.Text = "Go Back";
            DriverBooking.UseVisualStyleBackColor = true;
            DriverBooking.Click += DriverBooking_Click;
            // 
            // ChooseJob
            // 
            ChooseJob.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseJob.Location = new Point(392, 287);
            ChooseJob.Name = "ChooseJob";
            ChooseJob.Size = new Size(240, 75);
            ChooseJob.TabIndex = 2;
            ChooseJob.Text = "Choose Available Jobs";
            ChooseJob.UseVisualStyleBackColor = true;
            ChooseJob.Click += ChooseJob_Click;
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
            // DriverDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(ChooseJob);
            Controls.Add(DriverBooking);
            Name = "DriverDashboard";
            Text = "DriverDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button DriverBooking;
        private Button ChooseJob;
        private PictureBox pictureBox1;
    }
}