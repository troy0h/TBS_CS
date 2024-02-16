namespace TBS_CS
{
    partial class CustomerDashboard
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
            CustomerBook = new Button();
            CustomerDelete = new Button();
            CustomerView = new Button();
            SuspendLayout();
            // 
            // CustomerBook
            // 
            CustomerBook.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerBook.Location = new Point(268, 391);
            CustomerBook.Name = "CustomerBook";
            CustomerBook.Size = new Size(135, 129);
            CustomerBook.TabIndex = 0;
            CustomerBook.Text = "Book";
            CustomerBook.UseVisualStyleBackColor = true;
            CustomerBook.Click += button1_Click;
            // 
            // CustomerDelete
            // 
            CustomerDelete.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerDelete.Location = new Point(435, 391);
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Size = new Size(135, 129);
            CustomerDelete.TabIndex = 1;
            CustomerDelete.Text = "Delete";
            CustomerDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            CustomerView.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerView.Location = new Point(594, 391);
            CustomerView.Name = "CustomerView";
            CustomerView.Size = new Size(135, 129);
            CustomerView.TabIndex = 2;
            CustomerView.Text = "View";
            CustomerView.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.checkers;
            ClientSize = new Size(1008, 729);
            Controls.Add(CustomerView);
            Controls.Add(CustomerDelete);
            Controls.Add(CustomerBook);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button CustomerBook;
        private Button CustomerDelete;
        private Button CustomerView;
    }
}