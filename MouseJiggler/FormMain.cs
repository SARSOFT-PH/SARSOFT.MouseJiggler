using MouseJiggler.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class FormMain : Form
    {
        private int intensity;

        [DllImport(Constants.USER32)]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport(Constants.USER32)]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport(Constants.KERNEL32, CharSet = CharSet.Ansi, SetLastError = true)]
        internal static extern ExecutionStates SetThreadExecutionState(ExecutionStates esFlags);

        [Flags]
        public enum ExecutionStates : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        public FormMain()
        {
            InitializeComponent();
            RegisterHotKey(Handle, 1, Constants.MOD_ALT | Constants.MOD_NOREPEAT, (int)Keys.F1);
        }

        public static void FoceSystemAwake()
        {
            SetThreadExecutionState(ExecutionStates.ES_CONTINUOUS | ExecutionStates.ES_DISPLAY_REQUIRED | ExecutionStates.ES_SYSTEM_REQUIRED | ExecutionStates.ES_AWAYMODE_REQUIRED);
        }

        public static void ResetSystemDefault()
        {
            SetThreadExecutionState(ExecutionStates.ES_CONTINUOUS);
        }

        private void PicBodDonate_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.PAYPAL_URL);
        }

        private void PicBoxGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.GITHUB_URL);
        }

        protected override void WndProc(ref Message m)
        {
            if (WiggleTimer != null && m.Msg == Constants.WM_HOTKEY)
            {
                string msg = string.Empty;
                if (WiggleTimer.Enabled)
                {
                    msg = "Application has stop moving the cursor.";
                    WiggleTimer.Stop();
                    ResetSystemDefault();
                }
                else if (!WiggleTimer.Enabled)
                {
                    msg = "Application is now moving the cursor.";
                    FoceSystemAwake();
                    WiggleTimer.Start();
                }

                if (WindowState == FormWindowState.Minimized)
                {
                    ShowBalloonTip(msg);
                }

                Log(msg);
            }

            base.WndProc(ref m);
        }

        private void WiggleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                WiggleTimer.Interval = 8000;
                int miliInterval = (5 * WiggleIntensity.Maximum) - (4 * WiggleIntensity.Value);
                int newIntensity = WiggleIntensity.Value * 3;

                if (newIntensity != intensity)
                {
                    intensity = newIntensity;
                    Log("Wiggle was adjusted to " + WiggleIntensity.Value);
                }

                for (int i = 0; i <= intensity; i++)
                {
                    Thread.Sleep(miliInterval);
                    Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y - 1);
                    Thread.Sleep(miliInterval);
                    Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y + 1);
                    Thread.Sleep(miliInterval);
                    Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y + 1);
                    Thread.Sleep(miliInterval);
                    Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y - 1);
                }
            }
            catch (Exception er)
            {
                Error($"WiggleTimer_Tick() - ${er.Message}", er);
                WiggleTimer.Stop();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                string msg = "Application has been minimized!";
                ShowBalloonTip(msg);
                Log(msg);
            }
        }

        private void ShowBalloonTip(string text, ToolTipIcon icon = ToolTipIcon.None, double timeout = 0.5d)
        {
            try
            {
                notifyIcon1.BalloonTipIcon = icon;
                notifyIcon1.BalloonTipTitle = Text;
                notifyIcon1.BalloonTipText = text;
                if (notifyIcon1.Visible)
                {
                    notifyIcon1.ShowBalloonTip((int)(timeout * 100));
                }
            }
            catch (Exception e)
            {
                Error($"ShowBalloonTip() - ${e.Message}", e);
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Log(string msg)
        {
            RichTextBoxLogs.Text += $"[{DateTime.Now.ToString().ToUpper()}]: " + msg + Environment.NewLine;
        }

        private void Error(string msg, Exception e)
        {
            Log($"{msg} {Environment.NewLine + e.StackTrace}");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("Exiting...");
        }
    }
}
