using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataDisplayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Raspberry myRaspberry;
        [STAThread]
        static void Main()
        {
            myRaspberry = new Raspberry();
           // myRaspberry.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSensorDataDisplayer());
        }
    }
}
