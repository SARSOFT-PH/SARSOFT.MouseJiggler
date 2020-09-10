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
        [DllImport(Constants.USER32)]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport(Constants.USER32)]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport(Constants.KERNEL32, CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [Flags]
        public enum EXECUTION_STATE : uint
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
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }

        public static void ResetSystemDefault()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
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
            if (WiggleTimer != null)
            {
                if (m.Msg == Constants.WM_HOTKEY && WiggleTimer.Enabled)
                {
                    RichTextBoxLogs.Text += "Application has stop moving the cursor." + Environment.NewLine;
                    WiggleTimer.Stop();
                    ResetSystemDefault();
                }
                else if (m.Msg == Constants.WM_HOTKEY && !WiggleTimer.Enabled)
                {
                    RichTextBoxLogs.Text += "Application is now moving the cursor." + Environment.NewLine;
                    FoceSystemAwake();
                    WiggleTimer.Start();
                }
            }

            base.WndProc(ref m);
        }

        private void WiggleTimer_Tick(object sender, EventArgs e)
        {
            WiggleTimer.Interval = 8000;
            int miliInterval = (5 * WiggleIntensity.Maximum) - (4 * WiggleIntensity.Value);
            int intensity = WiggleIntensity.Value * 3;
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
    }
}
