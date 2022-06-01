using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Messaging;
using System.Net.NetworkInformation;
using System.Reflection;


namespace CommonLibrary
{
    class PinOut
    {
        private string boardName;
        private List<int> I2C_GPIO_Pin = new List<int> { 2, 3 };
        private List<int> SPI_GPIO_Pin = new List<int> { 9, 10, 11 };
        private List<int> UART_GPIO_Pin = new List<int> { 14, 15 };
        private List<int> General_Purpose_GPIO_Pin = new List<int> { 4, 5, 6, 12, 13, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
    }

    public static class SensorCommands
    {
        public static Message Start(string sensor)
        {
            Message start = new Message();
            start.Label = "START";
            start.Body = sensor;
            return start;
        }

        public static Message Stop(string sensor)
        {
            Message stop = new Message();
            stop.Label = "STOP";
            stop.Body = sensor;
            return stop;
        }
    }

    public class GeneralConfigurationDetail
    {
        public string board;
        public string localIP;
        public string RaspberryIP;
        public string RaspberryUser;
        public string RaspberryPassword;
        public string RaspberryWorkingFolder;
        public string port;
    }

    public class SensorState
    {

    }

    public class Raspberry
    {
        public MessageQueue inboundQueue;
        public GeneralConfigurationDetail configDetail;

        public void Initialize(string configFilename)
        {
            InitConfig(configFilename);
            InitQueue();
        }

        private void InitQueue()
        {
            if (!MessageQueue.Exists(@".\Private$\InboundQueue"))
                inboundQueue = MessageQueue.Create(@".\Private$\InboundQueue");
            else
                inboundQueue = new MessageQueue(@".\Private$\InboundQueue");
            inboundQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
        }

        public Dictionary<int, string> GetAllBoards()
        {
            Dictionary<int, string> boards = new Dictionary<int, string>();
            boards.Add(0, "Pi 3B+");
            boards.Add(1, "Pi 3A+");
            boards.Add(2, "Pi 3B");
            boards.Add(3, "Pi 4");
            return (boards);
        }

        public bool Ping()
        {
            bool success = false;
            if (configDetail != null)
                success = Network.Ping(configDetail.RaspberryIP);
            return success;
        }

        private GeneralConfigurationDetail InitConfig(string configFilename)
        {
            DataRow row = null;

            DataSet dataSetConfiguration = new DataSet();

            if (File.Exists(configFilename))
            {
                XmlReader xmlFile = XmlReader.Create(configFilename, new XmlReaderSettings());
                dataSetConfiguration.ReadXml(xmlFile, XmlReadMode.ReadSchema);
                row = dataSetConfiguration.Tables[0].Rows[0];
                configDetail = new GeneralConfigurationDetail
                {
                    board = row.ItemArray[0] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[0].DefaultValue : (string)row.ItemArray[0],
                    localIP = row.ItemArray[1] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[1].DefaultValue : (string)row.ItemArray[1],
                    RaspberryIP = row.ItemArray[2] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[2].DefaultValue : (string)row.ItemArray[2],
                    RaspberryWorkingFolder = row.ItemArray[3] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[3].DefaultValue : (string)row.ItemArray[3],
                    port = row.ItemArray[4] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[4].DefaultValue : (string)row.ItemArray[4],
                    RaspberryUser = row.ItemArray[5] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[5].DefaultValue : (string)row.ItemArray[5],
                    RaspberryPassword = row.ItemArray[6] == DBNull.Value ? (string)dataSetConfiguration.Tables[0].Columns[6].DefaultValue : (string)row.ItemArray[6]
                };

                xmlFile.Close();
            }
            return configDetail;
        }

        public DataSet SensorConfig()
        {
            DataSet dataSetSensors = new DataSet();

            if (File.Exists("SensorConfiguration.xml"))
            {
                XmlReader xmlFile = XmlReader.Create("SensorConfiguration.xml", new XmlReaderSettings());
                dataSetSensors.ReadXml(xmlFile, XmlReadMode.ReadSchema);
                xmlFile.Close();
            }
            return dataSetSensors;
        }

        // Sample Usage:
        //
        // Rename a file
        // Raspberry.ExecuteBashCommand("mv /home/pi/Documents/test2.xml /home/pi/Documents/test3.xml");
        //
        // Create directory
        // Raspberry.ExecuteBashCommand("mkdir /home/pi/Documents/Test");
        //
        // Delete a file
        // Raspberry.ExecuteBashCommand("rm /home/pi/Documents/test3.xml");
        //
        // Check for the existence of a file (file exists when returned value is true)
        // Raspberry.ExecuteBashCommand("[ -f /home/pi/Documents/PlainGPIO/out.txt ]");
        //
        // Check for the existence of a directory (directory exists when returned value is true)
        // Raspberry.ExecuteBashCommand("[ -d /home/pi/Documents/Test4 ]");

        public bool ExecuteBashCommand(string command)
        {
            bool success = true;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "plink.exe",
                Arguments = GetProcessArguments(),
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = Process.Start(startInfo);

            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit");

            process.WaitForExit(2000);
            if (process.ExitCode != 0)
                success = false;
            process.Close();

            return success;
        }

        public string ExecuteBashCommand(string commandFullPath, string lastLineMarker)
        {
            string output = "";
            string processArguments = GetProcessArguments();
            if (!string.IsNullOrEmpty(processArguments))
            {
                ProcessStartInfo startinfo = new ProcessStartInfo();
                startinfo.FileName = "plink.exe";
                startinfo.Arguments = processArguments;
                Process process = new Process();
                process.StartInfo = startinfo;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;

                bool started = process.Start();
                process.StandardInput.WriteLine(commandFullPath);

                process.StandardInput.Flush();
                process.StandardInput.Close();
                while (!output.Contains(lastLineMarker))
                {
                    if (!process.StandardOutput.EndOfStream)
                    {
                        string currentLine = process.StandardOutput.ReadLine();
                        output = output + currentLine;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return output;
        }

        private string GetProcessArguments()
        {
            string processArguments = "";
            if (configDetail != null)
                processArguments = configDetail.RaspberryUser + '@' + configDetail.RaspberryIP + " -pw " + configDetail.RaspberryPassword;

            return (processArguments);
        }

        public bool StartSensor(string sensorName, string sensorInterface)
        {
            bool success = true;
            string toExecute = "MonitorSensor.exe";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = toExecute;
            startInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            startInfo.Verb = "runas";
            startInfo.Arguments = sensorName + " " + sensorInterface;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            try
            {
                success = process.Start();
            }
            catch (Exception ex)
            {
                ErrorLogging.Add(ex.ToString());
                success = false;
            }
            return success;
        }

        public Message[] GetAllReadings()
        {
            Message[] allMessages = inboundQueue.GetAllMessages();
            inboundQueue.Purge();
            return (allMessages);
        }

        public bool IsSensorRunning(string sensorName)
        {
            return true;
        }
    }
}
