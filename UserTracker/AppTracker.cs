using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTracker
{
    public class AppTracker
    {
        private static string projectPath = Application.StartupPath;
        private static string settingsPath = Path.Combine(projectPath, "settings.txt");
        private static string forbiddenAppsPath = Path.Combine(projectPath, "forbidden_apps.txt");
        private static string logFilePath;
        private static bool isLoggingEnable = false;
        private static bool isModerationEnable = false;
        private static bool isAppLoggingEnable = false;
        private static bool isAppModerationEnable = false;
        private static string[] forbiddenApps = new string[0];

        public static async Task StartMonitoringAsync()
        {
            LoadSettings();

            await Task.Run(() =>
            {
                while (true)
                {
                    MonitorProcesses();
                }
            });
        }

        private static void LoadSettings()
        {
            if (File.Exists(settingsPath))
            {
                string[] settings = File.ReadAllLines(settingsPath);
                if (settings.Length >= 7)
                {
                    isLoggingEnable = bool.Parse(settings[0]);
                    isAppLoggingEnable = bool.Parse(settings[2]);
                    isModerationEnable = bool.Parse(settings[3]);
                    isAppModerationEnable = bool.Parse(settings[5]);
                    logFilePath = Path.Combine(settings[6], "app_activity.txt");
                }
            }

            if (File.Exists(forbiddenAppsPath))
            {
                forbiddenApps = File.ReadAllLines(forbiddenAppsPath);
            }
        }

        private static void MonitorProcesses()
        {
            foreach (var process in Process.GetProcesses())
            {
                string processName = process.ProcessName;

                if (isLoggingEnable && isAppLoggingEnable)
                {
                    LogProcess(processName);
                }

                if (forbiddenApps.Contains(processName))
                {
                    if (isModerationEnable && isAppModerationEnable)
                    {
                        try
                        {
                            process.Kill();
                            LogProcess($"Closed forbidden app: {processName} {DateTime.Now}");
                        }
                        catch (Exception ex)
                        {
                            LogProcess($"Failed to close {processName}: {ex.Message}");
                        }
                    }
                }
            }
        }

        private static void LogProcess(string process)
        {
            string log = $"{DateTime.Now}: {process}";
            File.AppendAllText(logFilePath, log + "\n");
        }
    }
}
