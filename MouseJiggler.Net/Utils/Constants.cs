#region copyright
// MouseJiggler.Net - Mouse Wiggler Application
// Copyright © 2020 LEONEL SARMIENTO
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.
#endregion
namespace MouseJiggler.Net.Utils
{
    static class Constants
    {   // DLL Imports
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
    }
}
