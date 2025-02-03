namespace UserTracker
{
    partial class SettingsForm
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
            btnSave = new Button();
            btnReset = new Button();
            btnBack = new Button();
            chkModeration = new CheckBox();
            chkReports = new CheckBox();
            chkKeyRecording = new CheckBox();
            chkAppRecording = new CheckBox();
            txtLogPath = new TextBox();
            btnBrowse = new Button();
            lblLogPath = new Label();
            lblForbiddenWords = new Label();
            txtNewWord = new TextBox();
            btnAddWord = new Button();
            btnRemoveWord = new Button();
            lstWords = new ListBox();
            lstApps = new ListBox();
            btnRemoveApp = new Button();
            btnAddApp = new Button();
            txtNewApp = new TextBox();
            lblForbiddenApps = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(700, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSaveSettings_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(606, 407);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 31);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(512, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 31);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // chkModeration
            // 
            chkModeration.AutoSize = true;
            chkModeration.Location = new Point(26, 31);
            chkModeration.Name = "chkModeration";
            chkModeration.Size = new Size(126, 19);
            chkModeration.TabIndex = 3;
            chkModeration.Text = "Enable Moderation";
            chkModeration.UseVisualStyleBackColor = true;
            chkModeration.CheckedChanged += chkModeration_CheckedChanged;
            // 
            // chkReports
            // 
            chkReports.AutoSize = true;
            chkReports.Location = new Point(26, 106);
            chkReports.Name = "chkReports";
            chkReports.Size = new Size(104, 19);
            chkReports.TabIndex = 4;
            chkReports.Text = "Enable Reports";
            chkReports.UseVisualStyleBackColor = true;
            // 
            // chkKeyRecording
            // 
            chkKeyRecording.AutoSize = true;
            chkKeyRecording.Location = new Point(50, 56);
            chkKeyRecording.Name = "chkKeyRecording";
            chkKeyRecording.Size = new Size(136, 19);
            chkKeyRecording.TabIndex = 5;
            chkKeyRecording.Text = "Enable key recording";
            chkKeyRecording.UseVisualStyleBackColor = true;
            chkKeyRecording.Visible = false;
            chkKeyRecording.CheckedChanged += chkKeyRecording_CheckedChanged;
            // 
            // chkAppRecording
            // 
            chkAppRecording.AutoSize = true;
            chkAppRecording.Location = new Point(50, 81);
            chkAppRecording.Name = "chkAppRecording";
            chkAppRecording.Size = new Size(138, 19);
            chkAppRecording.TabIndex = 6;
            chkAppRecording.Text = "Enable app recording";
            chkAppRecording.UseVisualStyleBackColor = true;
            chkAppRecording.Visible = false;
            // 
            // txtLogPath
            // 
            txtLogPath.Location = new Point(263, 31);
            txtLogPath.Name = "txtLogPath";
            txtLogPath.Size = new Size(391, 23);
            txtLogPath.TabIndex = 7;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(660, 31);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(128, 23);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Choose Path";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowsePath_Click;
            // 
            // lblLogPath
            // 
            lblLogPath.AutoSize = true;
            lblLogPath.Location = new Point(271, 12);
            lblLogPath.Name = "lblLogPath";
            lblLogPath.Size = new Size(31, 15);
            lblLogPath.TabIndex = 9;
            lblLogPath.Text = "Path";
            // 
            // lblForbiddenWords
            // 
            lblForbiddenWords.AutoSize = true;
            lblForbiddenWords.Location = new Point(26, 146);
            lblForbiddenWords.Name = "lblForbiddenWords";
            lblForbiddenWords.Size = new Size(65, 15);
            lblForbiddenWords.TabIndex = 10;
            lblForbiddenWords.Text = "Write word";
            // 
            // txtNewWord
            // 
            txtNewWord.Location = new Point(26, 174);
            txtNewWord.Name = "txtNewWord";
            txtNewWord.Size = new Size(309, 23);
            txtNewWord.TabIndex = 11;
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(26, 203);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(146, 23);
            btnAddWord.TabIndex = 14;
            btnAddWord.Text = "Add word";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // btnRemoveWord
            // 
            btnRemoveWord.Location = new Point(189, 203);
            btnRemoveWord.Name = "btnRemoveWord";
            btnRemoveWord.Size = new Size(146, 23);
            btnRemoveWord.TabIndex = 15;
            btnRemoveWord.Text = "Remove word";
            btnRemoveWord.UseVisualStyleBackColor = true;
            btnRemoveWord.Click += btnRemoveWord_Click;
            // 
            // lstWords
            // 
            lstWords.FormattingEnabled = true;
            lstWords.ItemHeight = 15;
            lstWords.Location = new Point(26, 245);
            lstWords.Name = "lstWords";
            lstWords.Size = new Size(309, 109);
            lstWords.TabIndex = 16;
            // 
            // lstApps
            // 
            lstApps.FormattingEnabled = true;
            lstApps.ItemHeight = 15;
            lstApps.Location = new Point(418, 245);
            lstApps.Name = "lstApps";
            lstApps.Size = new Size(309, 109);
            lstApps.TabIndex = 21;
            // 
            // btnRemoveApp
            // 
            btnRemoveApp.Location = new Point(581, 203);
            btnRemoveApp.Name = "btnRemoveApp";
            btnRemoveApp.Size = new Size(146, 23);
            btnRemoveApp.TabIndex = 20;
            btnRemoveApp.Text = "Remove app";
            btnRemoveApp.UseVisualStyleBackColor = true;
            btnRemoveApp.Click += btnRemoveApp_Click;
            // 
            // btnAddApp
            // 
            btnAddApp.Location = new Point(418, 203);
            btnAddApp.Name = "btnAddApp";
            btnAddApp.Size = new Size(148, 23);
            btnAddApp.TabIndex = 19;
            btnAddApp.Text = "Add app";
            btnAddApp.UseVisualStyleBackColor = true;
            btnAddApp.Click += btnAddApp_Click;
            // 
            // txtNewApp
            // 
            txtNewApp.Location = new Point(418, 174);
            txtNewApp.Name = "txtNewApp";
            txtNewApp.Size = new Size(309, 23);
            txtNewApp.TabIndex = 18;
            // 
            // lblForbiddenApps
            // 
            lblForbiddenApps.AutoSize = true;
            lblForbiddenApps.Location = new Point(418, 146);
            lblForbiddenApps.Name = "lblForbiddenApps";
            lblForbiddenApps.Size = new Size(65, 15);
            lblForbiddenApps.TabIndex = 17;
            lblForbiddenApps.Text = "Write word";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstApps);
            Controls.Add(btnRemoveApp);
            Controls.Add(btnAddApp);
            Controls.Add(txtNewApp);
            Controls.Add(lblForbiddenApps);
            Controls.Add(lstWords);
            Controls.Add(btnRemoveWord);
            Controls.Add(btnAddWord);
            Controls.Add(txtNewWord);
            Controls.Add(lblForbiddenWords);
            Controls.Add(lblLogPath);
            Controls.Add(btnBrowse);
            Controls.Add(txtLogPath);
            Controls.Add(chkAppRecording);
            Controls.Add(chkKeyRecording);
            Controls.Add(chkReports);
            Controls.Add(chkModeration);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ChkModeration_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnSave;
        private Button btnReset;
        private Button btnBack;
        private CheckBox chkModeration;
        private CheckBox chkReports;
        private CheckBox chkKeyRecording;
        private CheckBox chkAppRecording;
        private TextBox txtLogPath;
        private Button btnBrowse;
        private Label lblLogPath;
        private Label lblForbiddenWords;
        private TextBox txtNewWord;
        private Button btnAddWord;
        private Button btnRemoveWord;
        private ListBox lstWords;
        private ListBox lstApps;
        private Button btnRemoveApp;
        private Button btnAddApp;
        private TextBox txtNewApp;
        private Label lblForbiddenApps;
    }
}