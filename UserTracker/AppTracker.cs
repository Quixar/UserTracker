using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UserTracker
{
    public class AppTracker
    {
        private static string projectPath = Application.StartupPath;
        private static string settingsPath = Path.Combine(projectPath, "settings.txt");
        private static string forbiddenAppsPath = Path.Combine(projectPath, "forbidden_apps.txt");
        private static string logFilePath;
        private static string closedAppsLogFilePath;
        private static bool isLoggingEnable = false;
        private static bool isModerationEnable = false;
        private static bool isAppLoggingEnable = false;
        private static bool isAppModerationEnable = false;
        private static string[] forbiddenApps = new string[0];

        private static ConcurrentDictionary<string, bool> loggedProcesses = new ConcurrentDictionary<string, bool>();
        private static CancellationTokenSource cancellationTokenSource;

        public static async Task StartMonitoringAsync()
        {
            LoadSettings();

            File.WriteAllText(logFilePath, string.Empty);
            File.WriteAllText(closedAppsLogFilePath, string.Empty);

            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            await Task.WhenAll(
                Task.Run(async () => await MonitorProcessesAsync(token), token),
                Task.Run(async () => await MonitorForbiddenAppsAsync(token), token)
            );
        }

        public static void StopMonitoring()
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource.Dispose();
                cancellationTokenSource = null;
            }
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
                    closedAppsLogFilePath = Path.Combine(settings[6], "closed_apps.txt");
                }
            }

            if (File.Exists(forbiddenAppsPath))
            {
                forbiddenApps = File.ReadAllLines(forbiddenAppsPath);
            }
        }

        private static async Task MonitorProcessesAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                foreach (var process in Process.GetProcesses())
                {
                    try
                    {
                        string processName = process.ProcessName;

                        if (isLoggingEnable && isAppLoggingEnable)
                        {
                            if (loggedProcesses.TryAdd(processName, true))
                            {
                                LogProcess(logFilePath, processName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LogProcess(logFilePath, $"Ошибка доступа к процессу: {ex.Message}");
                    }
                }

                await Task.Delay(TimeSpan.FromSeconds(5), token);
            }
        }

        private static async Task MonitorForbiddenAppsAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var processes = Process.GetProcesses();

                Parallel.ForEach(processes, process =>
                {
                    string processName = process.ProcessName;

                    if (forbiddenApps.Contains(processName))
                    {
                        if (isModerationEnable && isAppModerationEnable)
                        {
                            try
                            {
                                process.Kill();
                                LogProcess(closedAppsLogFilePath, $"Closed forbidden app: {processName}");
                            }
                            catch (Exception ex)
                            {
                                LogProcess(closedAppsLogFilePath, $"Failed to close {processName}: {ex.Message}");
                            }
                        }
                    }
                });

                await Task.Delay(TimeSpan.FromMilliseconds(100), token);
            }
        }

        private static void LogProcess(string filePath, string message)
        {
            string log = $"{DateTime.Now}: {message}";
            File.AppendAllText(filePath, log + Environment.NewLine);
        }
    }
}
