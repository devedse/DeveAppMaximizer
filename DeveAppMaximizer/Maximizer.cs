using System;
using System.Runtime.InteropServices;

namespace DeveAppMaximizer
{
    public static class Maximizer
    {
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;
        // more here: http://www.pinvoke.net/default.aspx/user32.showwindow

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void Show(IntPtr hWnd)
        {
            ShowWindow(hWnd, SW_MAXIMIZE);
        }
    }
}
