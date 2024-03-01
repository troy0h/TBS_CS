namespace TBS_CS
{
    partial class ChooseJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseJobs));
            SuspendLayout();
            // 
            // canceljobs
            // 
            canceljobs.Location = new Point(589, 386);
            canceljobs.Name = "canceljobs";
            canceljobs.Size = new Size(176, 101);
            canceljobs.TabIndex = 6;
            canceljobs.Text = "Cancel Job";
            canceljobs.UseVisualStyleBackColor = true;
            // 
            // acceptjob
            // 
            acceptjob.Location = new Point(261, 386);
            acceptjob.Name = "acceptjob";
            acceptjob.Size = new Size(176, 101);
            acceptjob.TabIndex = 8;
            acceptjob.Text = "Accept Job";
            acceptjob.UseVisualStyleBackColor = true;
            // 
            // DriverJobs
            // 
            SuspendLayout();
            // 
            // ChooseJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Name = "ChooseJobs";
            Text = "ChooseJobs";
            ClientSize = new Size(1008, 729);
            Name = "ChooseJobs";
            Text = "ChooseJobs";
            ResumeLayout(false);
        }

        #endregion

        private Button canceljobs;
        private Button acceptjob;
        private ListBox DriverJobs;
    }
}