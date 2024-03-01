namespace TBS_CS
{
    partial class ViewJobs
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
            canceljobs = new Button();
            DriverJobs = new ListBox();
            SuspendLayout();
            // 
            // canceljobs
            // 
            canceljobs.Location = new Point(12, 386);
            canceljobs.Name = "canceljobs";
            canceljobs.Size = new Size(176, 101);
            canceljobs.TabIndex = 3;
            canceljobs.Text = "Cancel Job";
            canceljobs.UseVisualStyleBackColor = true;
            // 
            // DriverJobs
            // 
            DriverJobs.FormattingEnabled = true;
            DriverJobs.ItemHeight = 15;
            DriverJobs.Location = new Point(12, 12);
            DriverJobs.Name = "DriverJobs";
            DriverJobs.Size = new Size(984, 349);
            DriverJobs.TabIndex = 2;
            // 
            // ViewJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(canceljobs);
            Controls.Add(DriverJobs);
            Name = "ViewJobs";
            Text = "ViewJobs";
            ResumeLayout(false);
        }

        #endregion

        private Button canceljobs;
        private ListBox DriverJobs;
    }
}