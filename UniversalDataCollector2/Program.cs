using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using CommonLibrary;

namespace UniversalDataCollector
{
    static class Program
    {
        public static Raspberry myRaspberry;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            myRaspberry = new Raspberry();
            myRaspberry.Initialize(Settings1.Default.GeneralConfigFilename);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmMonitorSensors());
            }
            catch(Exception ex)
            {
                CleanUp();
                ErrorLogging.Add(ex.ToString());
            }
        }

        static private void CleanUp()
        {
            List<string> processesToKill = new List<string>() { "SensorDataDisplayer", "MonitorSensor" };
            foreach (string toKill in processesToKill)
            {
                Process[] processes = Process.GetProcessesByName(toKill);
                foreach (Process p in processes)
                {
                    p.Kill();
                }
            }
        }

    }
}
