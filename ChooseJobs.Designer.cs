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
            canceljobs = new Button();
            acceptjob = new Button();
            DriverJobs = new ListBox();
            pictureBox1 = new PictureBox();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // canceljobs
            // 
            canceljobs.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canceljobs.Location = new Point(524, 561);
            canceljobs.Name = "canceljobs";
            canceljobs.Size = new Size(240, 75);
            canceljobs.TabIndex = 6;
            canceljobs.Text = "Cancel Job";
            canceljobs.UseVisualStyleBackColor = true;
            // 
            // acceptjob
            // 
            acceptjob.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acceptjob.Location = new Point(260, 561);
            acceptjob.Name = "acceptjob";
            acceptjob.Size = new Size(240, 75);
            acceptjob.TabIndex = 8;
            acceptjob.Text = "Accept Job";
            acceptjob.UseVisualStyleBackColor = true;
            // 
            // DriverJobs
            // 
            DriverJobs.FormattingEnabled = true;
            DriverJobs.ItemHeight = 15;
            DriverJobs.Location = new Point(260, 272);
            DriverJobs.Name = "DriverJobs";
            DriverJobs.Size = new Size(504, 274);
            DriverJobs.TabIndex = 7;
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // back
            // 
            back.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.Location = new Point(392, 642);
            back.Name = "back";
            back.Size = new Size(240, 75);
            back.TabIndex = 10;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // ChooseJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(back);
            Controls.Add(pictureBox1);
            Controls.Add(acceptjob);
            Controls.Add(DriverJobs);
            Controls.Add(canceljobs);
            Name = "ChooseJobs";
            Text = "ChooseJobs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button canceljobs;
        private Button acceptjob;
        private ListBox DriverJobs;
        private PictureBox pictureBox1;
        private Button back;
    }
}