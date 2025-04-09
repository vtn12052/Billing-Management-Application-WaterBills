using System;
using System.Windows.Forms;

namespace Water_Bills
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) 
            {
                SetProcessDPIAware(); // Enable DPI awareness for Windows 7 and later, so that the application scales correctly on high-DPI displays.
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // The line starts the application with the LoginForm as the main form.
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")] // Import the SetProcessDPIAware function from user32.dll to enable DPI awareness.
        public static extern bool SetProcessDPIAware(); // This function is used to set the process DPI awareness.
    }
}
