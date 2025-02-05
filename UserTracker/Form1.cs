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
            KeyLogger.StartLoggingAsync();
        }

        private void btnStopModeration_Click(object sender, EventArgs e)
        {
            AppTracker.StopMonitoring();
            KeyLogger.StopLogging();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            this.Hide();
            reportForm.ShowDialog();
            this.Show();
        }
    }
}
