using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BaharNarenjERP
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private static bool HasPriorInstance()
        {
            var currentProcess = Process.GetCurrentProcess();
            var fileName = currentProcess.StartInfo.FileName;
            foreach (var process in Process.GetProcessesByName(currentProcess.ProcessName).Where(process => process.Id != currentProcess.Id).Where(process => process.StartInfo.FileName == fileName))
            {
                SetForegroundWindow(process.MainWindowHandle);
                return true;
            }
            return false;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (HasPriorInstance()) return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainMdi());
        }
    }
}
