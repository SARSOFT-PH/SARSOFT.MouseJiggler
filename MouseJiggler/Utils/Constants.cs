namespace MouseJiggler.Utils
{
    static class Constants
    {
        // DLL Imports
        public const string USER32 = "user32.dll";
        public const string KERNEL32 = "kernel32.dll";

        // Keyboard Mod
        public const int MOD_ALT = 0x0001;
        public const int MOD_CONTROL = 0x0002;
        public const int MOD_NOREPEAT = 0x4000;
        public const int MOD_SHIFT = 0x0004;
        public const int MOD_WIN = 0x0008;
        public const int WM_HOTKEY = 0x0312;

        // Windows Commands
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MONITOR_POWER = 0xF170;
        public const int SC_SCREENSAVE = 0xF140;

        private const string donnation_link = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=6JAKSVTCGHKCW&source=url";
        public const string PAYPAL_URL = donnation_link;

        private const string github_link = "https://github.com/SARSOFT-PH";
        public const string GITHUB_URL = github_link;
    }
}
