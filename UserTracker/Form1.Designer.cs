namespace UserTracker
{
    partial class UserTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSettings = new Button();
            btnModeration = new Button();
            btnReports = new Button();
            lblProgramName = new Label();
            btnStopModeration = new Button();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(272, 110);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(97, 41);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnModeration
            // 
            btnModeration.Location = new Point(104, 110);
            btnModeration.Name = "btnModeration";
            btnModeration.Size = new Size(78, 41);
            btnModeration.TabIndex = 1;
            btnModeration.Text = "Moderation";
            btnModeration.UseVisualStyleBackColor = true;
            btnModeration.Click += btnModeration_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(27, 110);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(71, 41);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // lblProgramName
            // 
            lblProgramName.AutoSize = true;
            lblProgramName.Font = new Font("Segoe UI", 30F);
            lblProgramName.Location = new Point(74, 38);
            lblProgramName.Name = "lblProgramName";
            lblProgramName.Size = new Size(238, 54);
            lblProgramName.TabIndex = 3;
            lblProgramName.Text = "User Tracker";
            // 
            // btnStopModeration
            // 
            btnStopModeration.Location = new Point(188, 110);
            btnStopModeration.Name = "btnStopModeration";
            btnStopModeration.Size = new Size(78, 41);
            btnStopModeration.TabIndex = 4;
            btnStopModeration.Text = "Stop moderation";
            btnStopModeration.UseVisualStyleBackColor = true;
            btnStopModeration.Click += button1_Click;
            // 
            // UserTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 201);
            Controls.Add(btnStopModeration);
            Controls.Add(lblProgramName);
            Controls.Add(btnReports);
            Controls.Add(btnModeration);
            Controls.Add(btnSettings);
            Name = "UserTracker";
            Text = "User Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private Button btnModeration;
        private Button btnReports;
        private Label lblProgramName;
        private Button btnStopModeration;
    }
}
