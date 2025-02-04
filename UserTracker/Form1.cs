using System.Diagnostics;

namespace UserTracker
{
    public partial class UserTracker : Form
    {
        private static string settingsPath = Path.Combine(Application.StartupPath, "settings.txt");
        public UserTracker()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            this.Hide();
            settingsForm.ShowDialog();
            this.Show();
        }

        private void btnModeration_Click(object sender, EventArgs e)
        {
            AppTracker.StartMonitoringAsync();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppTracker.StopMonitoring();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            string folderPath = GetUserFolderPath();
            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("The specified folder was not found. Check your settings.");
            }
        }

        private string GetUserFolderPath()
        {
            if (File.Exists(settingsPath))
            {
                string[] settings = File.ReadAllLines(settingsPath);
                if (settings.Length >= 7)
                {
                    return settings[6];
                }
            }
            return string.Empty;
        }

    }
}
