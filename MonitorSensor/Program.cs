using System.Diagnostics;
using System.Messaging;
using System.Threading;
using CommonLibrary;
using System.Linq;

namespace MonitorSensor
{
    class MonitorSensor
    {
        public bool isAlive = false;

        private string sensor;
        private string sensorInterface;
        private Process currentProcess = null;
        private GeneralConfigurationDetail config = null;

        private Message start;
        private Message stop;
        private Raspberry myRaspberry;

        public void Initialize(string sensorName, string interfac)
        {
            myRaspberry = new Raspberry();
            myRaspberry.Initialize(Settings1.Default.GeneralConfigFilename);
            sensor = sensorName;
            sensorInterface = interfac;
            start = SensorCommands.Start(sensor);
            stop = SensorCommands.Stop(sensor);
            StartRemoteSensor();
        }

        public void RefreshLife()
        {
            Message[] allMessages = myRaspberry.inboundQueue.GetAllMessages();
            isAlive = !allMessages.Contains(stop);
        }


        // Start a process to get readings from the sensor on the Raspberry Pi
        private void StartRemoteSensor()
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "plink.exe";
            startinfo.Arguments = GetSensorProcessArguments();
            currentProcess = new Process();
            currentProcess.StartInfo = startinfo;
            currentProcess.StartInfo.UseShellExecute = false;
            currentProcess.StartInfo.RedirectStandardInput = true;
            currentProcess.StartInfo.RedirectStandardOutput = true;
                     
            bool started = currentProcess.Start();
            string executable = config.RaspberryWorkingFolder + "/ActiveSensors/" + sensor + "_" + sensorInterface;
            currentProcess.StandardInput.WriteLine(executable);
        }

        public string GetSensorProcessArguments()
        {
            return (config.RaspberryUser + '@' + config.RaspberryIP + " -pw " + config.RaspberryPassword);
        }

        public void QueueReading(string message, string sensor)
        {
            myRaspberry.inboundQueue.Send(message, sensor);
        }

        public string GetReading()
        {
            return(currentProcess.StandardOutput.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string reading = "";
            string sensorName = args[0];
            string sensorInterface = args[1];
            bool dataStartDetected = false;

            MonitorSensor monitorSensor = new MonitorSensor();
            monitorSensor.Initialize(sensorName, sensorInterface);
            monitorSensor.isAlive = true;
            while (monitorSensor.isAlive)
            {
                reading = monitorSensor.GetReading();
                if (!string.IsNullOrEmpty(reading))
                {
                    if (dataStartDetected)
                        monitorSensor.QueueReading(reading, sensorName);
                    else
                        dataStartDetected = reading.Contains("start data");
                }
                reading = "";
                monitorSensor.RefreshLife();
                Thread.Sleep(1000);
            }
        }
    }
}
