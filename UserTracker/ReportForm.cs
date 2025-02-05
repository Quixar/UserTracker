using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserTracker
{
    public partial class ReportForm : Form
    {
        private static string settingsPath = Path.Combine(Application.StartupPath, "settings.txt");
        public ReportForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void LoadData()
        {
            string appActPath = Path.Combine(GetUserFolderPath(), "app_activity.txt");
            string appModPath = Path.Combine(GetUserFolderPath(), "closed_apps.txt");
            string keyLogPath = Path.Combine(GetUserFolderPath(), "key_log.txt");
            string keyModPath = Path.Combine(GetUserFolderPath(), "banned_word_log.txt");

            if (File.Exists(appActPath))
            {
                lstAppLogger.Items.Clear();
                lstAppLogger.Items.AddRange(File.ReadAllLines(appActPath));
            }

            if (File.Exists(appModPath))
            {
                lstAppModeration.Items.Clear();
                lstAppModeration.Items.AddRange(File.ReadAllLines(appModPath));
            }

            if (File.Exists(keyLogPath))
            {
                lstKeyLogger.Items.Clear();
                lstKeyLogger.Items.AddRange(File.ReadAllLines(keyLogPath));
            }

            if (File.Exists(keyModPath))
            {
                lstKeyModeration.Items.Clear();
                lstKeyModeration.Items.AddRange(File.ReadAllLines(keyModPath));
            }
        }
    }
}
