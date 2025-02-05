namespace UserTracker
{
    partial class ReportForm
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
            lstKeyLogger = new ListBox();
            lstAppLogger = new ListBox();
            lstKeyModeration = new ListBox();
            lstAppModeration = new ListBox();
            btnBack = new Button();
            button1 = new Button();
            lblAppLogger = new Label();
            lblAppModeration = new Label();
            lblKeyLogger = new Label();
            lblKeyModeration = new Label();
            SuspendLayout();
            // 
            // lstKeyLogger
            // 
            lstKeyLogger.FormattingEnabled = true;
            lstKeyLogger.ItemHeight = 15;
            lstKeyLogger.Location = new Point(28, 42);
            lstKeyLogger.Name = "lstKeyLogger";
            lstKeyLogger.Size = new Size(287, 139);
            lstKeyLogger.TabIndex = 0;
            // 
            // lstAppLogger
            // 
            lstAppLogger.FormattingEnabled = true;
            lstAppLogger.ItemHeight = 15;
            lstAppLogger.Location = new Point(427, 42);
            lstAppLogger.Name = "lstAppLogger";
            lstAppLogger.Size = new Size(287, 139);
            lstAppLogger.TabIndex = 1;
            // 
            // lstKeyModeration
            // 
            lstKeyModeration.FormattingEnabled = true;
            lstKeyModeration.ItemHeight = 15;
            lstKeyModeration.Location = new Point(28, 231);
            lstKeyModeration.Name = "lstKeyModeration";
            lstKeyModeration.Size = new Size(287, 139);
            lstKeyModeration.TabIndex = 2;
            // 
            // lstAppModeration
            // 
            lstAppModeration.FormattingEnabled = true;
            lstAppModeration.ItemHeight = 15;
            lstAppModeration.Location = new Point(427, 231);
            lstAppModeration.Name = "lstAppModeration";
            lstAppModeration.Size = new Size(287, 139);
            lstAppModeration.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(600, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(697, 415);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 5;
            button1.Text = "Open Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblAppLogger
            // 
            lblAppLogger.AutoSize = true;
            lblAppLogger.Location = new Point(427, 14);
            lblAppLogger.Name = "lblAppLogger";
            lblAppLogger.Size = new Size(66, 15);
            lblAppLogger.TabIndex = 7;
            lblAppLogger.Text = "App logger";
            // 
            // lblAppModeration
            // 
            lblAppModeration.AutoSize = true;
            lblAppModeration.Location = new Point(427, 203);
            lblAppModeration.Name = "lblAppModeration";
            lblAppModeration.Size = new Size(94, 15);
            lblAppModeration.TabIndex = 8;
            lblAppModeration.Text = "App moderation";
            // 
            // lblKeyLogger
            // 
            lblKeyLogger.AutoSize = true;
            lblKeyLogger.Location = new Point(28, 14);
            lblKeyLogger.Name = "lblKeyLogger";
            lblKeyLogger.Size = new Size(63, 15);
            lblKeyLogger.TabIndex = 9;
            lblKeyLogger.Text = "Key logger";
            // 
            // lblKeyModeration
            // 
            lblKeyModeration.AutoSize = true;
            lblKeyModeration.Location = new Point(28, 203);
            lblKeyModeration.Name = "lblKeyModeration";
            lblKeyModeration.Size = new Size(91, 15);
            lblKeyModeration.TabIndex = 10;
            lblKeyModeration.Text = "Key moderation";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKeyModeration);
            Controls.Add(lblKeyLogger);
            Controls.Add(lblAppModeration);
            Controls.Add(lblAppLogger);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(lstAppModeration);
            Controls.Add(lstKeyModeration);
            Controls.Add(lstAppLogger);
            Controls.Add(lstKeyLogger);
            Name = "ReportForm";
            Text = "ReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKeyLogger;
        private ListBox lstAppLogger;
        private ListBox lstKeyModeration;
        private ListBox lstAppModeration;
        private Button btnBack;
        private Button button1;
        private Label lblAppLogger;
        private Label lblAppModeration;
        private Label lblKeyLogger;
        private Label lblKeyModeration;
    }
}