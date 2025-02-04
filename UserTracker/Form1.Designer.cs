namespace UserTracker
{
    partial class Form1
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
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(240, 95);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(104, 56);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnModeration
            // 
            btnModeration.Location = new Point(141, 95);
            btnModeration.Name = "btnModeration";
            btnModeration.Size = new Size(93, 56);
            btnModeration.TabIndex = 1;
            btnModeration.Text = "Moderation";
            btnModeration.UseVisualStyleBackColor = true;
            btnModeration.Click += btnModeration_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(46, 95);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(89, 56);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 201);
            Controls.Add(lblProgramName);
            Controls.Add(btnReports);
            Controls.Add(btnModeration);
            Controls.Add(btnSettings);
            Name = "Form1";
            Text = "User Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private Button btnModeration;
        private Button btnReports;
        private Label lblProgramName;
    }
}
