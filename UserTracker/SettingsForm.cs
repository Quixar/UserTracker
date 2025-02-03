using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UserTracker
{
    public partial class SettingsForm : Form
    {
        private string projectPath = Application.StartupPath;

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            string settingsPath = Path.Combine(projectPath, "settings.txt");

            if (File.Exists(settingsPath))
            {
                string[] settings = File.ReadAllLines(settingsPath);
                if (settings.Length >= 5)
                {
                    chkReports.Checked = bool.Parse(settings[0]);
                    chkModeration.Checked = bool.Parse(settings[1]);
                    chkAppRecording.Checked = bool.Parse(settings[2]);
                    chkKeyRecording.Checked = bool.Parse(settings[3]);
                    txtLogPath.Text = settings[4];
                }
            }

            LoadForbiddenData();
        }

        private void LoadForbiddenData()
        {
            string forbiddenWordsPath = Path.Combine(projectPath, "forbidden_words.txt");
            string forbiddenAppsPath = Path.Combine(projectPath, "forbidden_apps.txt");

            if (File.Exists(forbiddenWordsPath))
            {
                lstWords.Items.Clear();
                lstWords.Items.AddRange(File.ReadAllLines(forbiddenWordsPath));
            }

            if (File.Exists(forbiddenAppsPath))
            {
                lstApps.Items.Clear();
                lstApps.Items.AddRange(File.ReadAllLines(forbiddenAppsPath));
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtLogPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewWord.Text))
            {
                if (!lstWords.Items.Contains(txtNewWord.Text))
                {
                    lstWords.Items.Add(txtNewWord.Text);
                    txtNewWord.Clear();
                }
                else
                {
                    MessageBox.Show($"Word: {txtNewWord.Text} already in list");
                }
            }
            else
            {
                MessageBox.Show("Field cannot be empty");
            }
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewApp.Text))
            {
                if (!lstApps.Items.Contains(txtNewApp.Text))
                {
                    lstApps.Items.Add(txtNewApp.Text);
                    txtNewApp.Clear();
                }
                else
                {
                    MessageBox.Show($"App: {txtNewApp.Text} already in list");
                }
            }
            else
            {
                MessageBox.Show("Field cannot be empty");
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogPath.Text))
            {
                MessageBox.Show("Select path to save report files");
                return;
            }

            string settingsPath = Path.Combine(projectPath, "settings.txt");
            string forbiddenWordsPath = Path.Combine(projectPath, "forbidden_words.txt");
            string forbiddenAppsPath = Path.Combine(projectPath, "forbidden_apps.txt");
            string logFilePath = Path.Combine(txtLogPath.Text, "activity_log.txt");

            try
            {
                File.WriteAllText(settingsPath, $"{chkReports.Checked}\n{chkModeration.Checked}\n{chkAppRecording.Checked}\n{chkKeyRecording.Checked}\n{txtLogPath.Text}");
                File.WriteAllLines(forbiddenWordsPath, lstWords.Items.Cast<string>());
                File.WriteAllLines(forbiddenAppsPath, lstApps.Items.Cast<string>());

                if (!File.Exists(logFilePath))
                {
                    File.Create(logFilePath).Close();
                }

                MessageBox.Show("Settings saved");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstWords.Items.Clear();
            lstApps.Items.Clear();

            string forbiddenWordsPath = Path.Combine(projectPath, "forbidden_words.txt");
            string forbiddenAppsPath = Path.Combine(projectPath, "forbidden_apps.txt");

            try
            {
                if (File.Exists(forbiddenWordsPath))
                {
                    File.WriteAllText(forbiddenWordsPath, string.Empty);
                }

                if (File.Exists(forbiddenAppsPath))
                {
                    File.WriteAllText(forbiddenAppsPath, string.Empty);
                }

                chkReports.Checked = false;
                chkModeration.Checked = false;
                chkAppRecording.Checked = false;
                chkKeyRecording.Checked = false;

                txtLogPath.Clear();
                txtNewWord.Clear();
                txtNewApp.Clear();

                MessageBox.Show("Settings reset");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting settings: {ex.Message}");
            }
        }

        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewWord.Text))
            {
                if (lstWords.Items.Contains(txtNewWord.Text))
                {
                    lstWords.Items.Remove(txtNewWord.Text);
                    txtNewWord.Clear();
                }
                else
                {
                    MessageBox.Show($"Word: {txtNewWord.Text} not in list");
                }
            }
            else
            {
                MessageBox.Show("Field cannot be empty");
            }
        }

        private void btnRemoveApp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewApp.Text))
            {
                if (lstApps.Items.Contains(txtNewApp.Text))
                {
                    lstApps.Items.Remove(txtNewApp.Text);
                    txtNewApp.Clear();
                }
                else
                {
                    MessageBox.Show($"App: {txtNewApp.Text} not in list");
                }
            }
            else
            {
                MessageBox.Show("Field cannot be empty");
            }
        }

        private void chkModeration_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkModeration.Checked;
            chkKeyRecording.Visible = isChecked;
            chkAppRecording.Visible = isChecked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkKeyRecording_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}