#region copyright
// MouseJiggler.Test - Mouse Wiggler Application
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
using ApprovalTests.Reporters;
using ApprovalTests.Wpf;
using MouseJiggler.Net;
using System;
using System.Drawing;
using System.Windows;
using Xunit;

namespace MouseJiggler.Test
{
    public class MainWindowTest
    {
        private readonly MainWindow _mainWindow;

        public MainWindowTest()
        {
            _mainWindow = new MainWindow();
        }

        [StaFact]
        [UseReporter(typeof(DiffReporter))]
        public void MainWindow_NotNull_Initialize()
        {
            Assert.NotNull(_mainWindow);
        }

        [StaFact]
        [UseReporter(typeof(DiffReporter))]
        public void SetGetMousePosition_True_SetPosition()
        {
            Random random = new Random();
            double x = random.Next(0, 500);
            double y = random.Next(0, 500);

            _mainWindow.SetMousePosition(x, y);

            Assert.Equal((int)x, _mainWindow.GetMousePosition().X);
            Assert.Equal((int)y, _mainWindow.GetMousePosition().Y);
        }

        [StaFact]
        [UseReporter(typeof(DiffReporter))]
        public void PerformCursorVibrate_True_CursorIsVibrating()
        {
            Assert.True(_mainWindow.PerformCursorVibrate());
        }

        [StaFact]
        [UseReporter(typeof(DiffReporter))]
        public void WindowTray_Minimize_WhenClicked()
        {
            _mainWindow.WindowTray_Click(null, null);
            Assert.Equal(WindowState.Minimized, _mainWindow.WindowState);
        }
    }
}
