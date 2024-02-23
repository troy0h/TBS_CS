namespace TBS_CS
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
            DriverBooking = new Button();
            ChooseJob = new Button();
            SuspendLayout();
            // 
            // DriverBooking
            // 
            DriverBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DriverBooking.Location = new Point(552, 274);
            DriverBooking.Name = "DriverBooking";
            DriverBooking.Size = new Size(135, 129);
            DriverBooking.TabIndex = 1;
            DriverBooking.Text = "View Jobs";
            DriverBooking.UseVisualStyleBackColor = true;
            // 
            // ChooseJob
            // 
            ChooseJob.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseJob.Location = new Point(364, 274);
            ChooseJob.Name = "ChooseJob";
            ChooseJob.Size = new Size(135, 129);
            ChooseJob.TabIndex = 2;
            ChooseJob.Text = "Choose Available Jobs";
            ChooseJob.UseVisualStyleBackColor = true;
            // 
            // DriverDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(ChooseJob);
            Controls.Add(DriverBooking);
            Name = "DriverDashboard";
            Text = "DriverDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button DriverBooking;
        private Button ChooseJob;
    }
}