using MouseJiggler.Net.Utils;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;

namespace MouseJiggler.Net
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            Top = 0;
            Left = (SystemParameters.PrimaryScreenWidth - Width) / 2;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var helper = new WindowInteropHelper(this);
            HwndSource source = HwndSource.FromHwnd(helper.Handle);
            source.AddHook(new HwndSourceHook(WndProc));
            RegisterHotKey(helper.Handle, 1, Constants.MOD_CONTROL | Constants.MOD_SHIFT | Constants.MOD_NOREPEAT, (uint)KeyInterop.VirtualKeyFromKey(Key.F1));

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(15);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int miliInterval = 10;
            for (int i = 0; i <= 50; i++)
            {
                Thread.Sleep(miliInterval);
                SetCursorPos((int)GetMousePosition().X + 1, (int)GetMousePosition().Y - 1);
                Thread.Sleep(miliInterval);
                SetCursorPos((int)GetMousePosition().X - 1, (int)GetMousePosition().Y + 1);
                Thread.Sleep(miliInterval);
                SetCursorPos((int)GetMousePosition().X - 1, (int)GetMousePosition().Y + 1);
                Thread.Sleep(miliInterval);
                SetCursorPos((int)GetMousePosition().X + 1, (int)GetMousePosition().Y - 1);
            }
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == Constants.WM_HOTKEY)
            {
                if (timer.IsEnabled)
                {
                    timer.Stop();
                    LabelGuide.Text = "PRESS (CTR + SHIFT + F1) TO ACTIVATE";
                    LabelGuide.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBFBFBF"));
                }
                else
                {
                    timer.Start();
                    LabelGuide.Text = "ACTIVATED!";
                    LabelGuide.FontWeight = FontWeights.Bold;
                    LabelGuide.Foreground = Brushes.Lime;
                }
            }
            return IntPtr.Zero;
        }

        public static Point GetMousePosition()
        {
            var w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }

        [DllImport(Constants.USER32)]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport(Constants.USER32)]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport(Constants.USER32)]
        private static extern bool SetCursorPos(int x, int y);
        
        [DllImport(Constants.USER32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public int X;
            public int Y;
        };

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

        public static void FoceSystemAwake()
        {
            SetThreadExecutionState(ExecutionStates.ES_CONTINUOUS | ExecutionStates.ES_DISPLAY_REQUIRED | ExecutionStates.ES_SYSTEM_REQUIRED | ExecutionStates.ES_AWAYMODE_REQUIRED);
        }

        public static void ResetSystemDefault()
        {
            SetThreadExecutionState(ExecutionStates.ES_CONTINUOUS);
        }

        public void WindowTray_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public void WindowClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

    }
}
