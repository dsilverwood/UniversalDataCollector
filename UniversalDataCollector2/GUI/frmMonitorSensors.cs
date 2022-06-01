using System;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Xml;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Speech.Recognition;
using CommonLibrary;
using UniversalDataCollector.Resources;
using UniversalDataCollector.GUI;
using System.Linq;

namespace UniversalDataCollector
{
    public enum SensorState
    {
        Stopped,
        Running,
        InError
    }

    public partial class frmMonitorSensors : frmBase
    {
        private DataSet dsMonitorSensor;

        public frmMonitorSensors()
        {
            InitializeComponent();
        }

        public void Initialize(DataSet ds)
        {
            dsMonitorSensor = ds;
        }

        override protected void LoadGrammar(Form form)
        {
            base.LoadGrammar(this);
            speech.LoadGrammar(GetChoicesGrammar("show data", GetSensorChoices()));
        }

        private Choices GetSensorChoices()
        {
            Choices sensorChoice = new Choices();
            foreach (DataRow row in dsMonitorSensor.Tables[0].Rows)
            {
                string sensorName = (string)row.ItemArray[0];
                sensorChoice.Add(sensorName);              
            }
            return sensorChoice;
        }

        override protected void Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            base.Recognized(sender, e);
            if (e.Result.Text.ToLower().Contains("show data"))
            {
                string command = e.Result.Text.ToLower();
                string sensorName = command.Remove(command.IndexOf("show data"), "show data".Length);
                sensorName.Replace(" ", string.Empty);
                DisplaySensorData(sensorName, GetCurrentSensorInterface());
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanUp();
            this.Close();
        }

        private string GetConfigurationFile()
        {
            return ((string)Settings1.Default["SensorConfigFilename"]);
        }

        private void frmMonitorSensors_Load(object sender, EventArgs e)
        {
            dsMonitorSensor = new DataSet();
            if (File.Exists(GetConfigurationFile()))
            {
                XmlReader xmlFile = XmlReader.Create(GetConfigurationFile(), new XmlReaderSettings());
                if (dsMonitorSensor.Tables.Count > 0)
                    dsMonitorSensor.Tables[0].Rows.Clear();
                dsMonitorSensor.ReadXml(xmlFile, XmlReadMode.ReadSchema);
                xmlFile.Close();
            }

            if (dsMonitorSensor != null)
            {
                dataGridViewMonitorSensors.Rows.Clear();
                foreach (DataRow row in dsMonitorSensor.Tables[0].Rows)
                {
                    dataGridViewMonitorSensors.Rows.Add(row[0], "", "", "");
                }
                foreach (DataGridViewRow row in dataGridViewMonitorSensors.Rows)
                {
                    if (row.Cells[0] != null && row.Cells[0].Value != null && row.Cells[0].Value.ToString().Length > 0)
                    {
                        row.Cells[1].Value = "Stopped";
                        ((DataGridViewButtonCell)row.Cells[2]).Value = "Start";
                        ((DataGridViewTextBoxCell)row.Cells[3]).Value = "No value";
                    }
                }
            }

            InitializeSpeech();
        }

        private SensorState GetSensorState(string sensorName)
        {
            return SensorState.Stopped;
        }

        private void configureSensorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speech.RecognizeAsyncCancel();
            frmConfigureSensorList configSensors = new frmConfigureSensorList();
            configSensors.ShowDialog();
            this.frmMonitorSensors_Load(this, null);
        }

        private void generalConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneralConfiguration generalConfig = new frmGeneralConfiguration();
            generalConfig.ShowDialog();
        }

        private string GetUploadArguments()
        {
            string arguments = "";
            if(Program.myRaspberry.configDetail != null)
                arguments = "-pw " + Program.myRaspberry.configDetail.RaspberryPassword + " -P " + Program.myRaspberry.configDetail.port + " SensorConfiguration.xml " + Program.myRaspberry.configDetail.RaspberryUser + "@" + Program.myRaspberry.configDetail.RaspberryIP + ":" + Program.myRaspberry.configDetail.RaspberryWorkingFolder;
            return arguments;
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.myRaspberry.Ping())
                return;
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = @"C:\Program Files\PuTTY\pscp.exe";
            startInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            startInfo.Verb = "runas";
            startInfo.Arguments = GetUploadArguments();
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            process.StartInfo = startInfo;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                process.Start();
                string err = process.StandardError.ReadToEnd();
                process.WaitForExit();
                int exitCode = process.ExitCode;
                process.Close();
                frmShowMessage showMessage = new frmShowMessage();
                if (exitCode != 0)
                {
                    showMessage.Message = ConfigureSensors.UploadErrorMessage + err;
                    showMessage.Text = "Error";
                }
                else
                {
                    showMessage.Message = "Configuration was uploaded successfully to the Raspberry Pi.";
                }
                Cursor.Current = Cursors.Default;
                showMessage.ShowDialog();

            }
            catch (Exception ex)
            {
                ErrorLogging.Add(ex.ToString());
            }

        }

        private string GetCurrentSensorName()
        {
            string sensorName = "";
            int selectedRow = dataGridViewMonitorSensors.CurrentRow.Index;
            if (selectedRow > -1 && selectedRow < dataGridViewMonitorSensors.Rows.Count)
            {
                sensorName = dataGridViewMonitorSensors.Rows[selectedRow].Cells[0].Value.ToString();
            }
            return sensorName;
        }

        private string GetCurrentSensorInterface()
        {
            string sensorInterface = "";
            int selectedRow = dataGridViewMonitorSensors.CurrentRow.Index;
            if (selectedRow > -1 && selectedRow < dataGridViewMonitorSensors.Rows.Count)
            {
                string sensorName = dataGridViewMonitorSensors.Rows[selectedRow].Cells[0].Value.ToString();
                string query = "SensorName = " + "'" + sensorName + "'";
                DataRow[] rows = dsMonitorSensor.Tables[0].Select(query);
                if (rows.Length > 0)
                    sensorInterface = rows[0].ItemArray[6].ToString();
            }
            return sensorInterface;
        }

        private void CleanUp()
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

        private void DisplaySensorData(string sensorName, string sensorInterface)
        {
            int exitCode;
            CleanUp();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string toExecute = "SensorDataDisplayer.exe";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = toExecute;
            startInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            startInfo.Verb = "runas";
            startInfo.Arguments = sensorName + " " + sensorInterface;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            process.StartInfo = startInfo;
            try
            {
                process.Start();
                process.WaitForExit();
                exitCode = process.ExitCode;
                if (exitCode == 1)
                {
                    frmShowMessage showError = new frmShowMessage();
                    showError.Message = "Could not connect to the Raspberry Pi. Make sure the Raspberry is powered up and is accessible on the network. Go to the General Configuration menu to test the connection.";
                    showError.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Add(ex.ToString());
            }
        }

        private void dataGridViewMonitorSensors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // DisplaySensorData(GetCurrentSensorName(), GetCurrentSensorInterface());
              //  if(Program.myRaspberry.Ping())
                   Program.myRaspberry.StartSensor(GetCurrentSensorName(), GetCurrentSensorInterface());
            }
        }

        private void timerRefreshReadings_Tick(object sender, EventArgs e)
        {
            System.Messaging.Message[] allReadings = Program.myRaspberry.GetAllReadings();
            if(allReadings.Count() > 0)
            {
                foreach(DataRow row in dsMonitorSensor.Tables[0].Rows)
                {
                    string sensorName = row.ItemArray[0].ToString();
                    System.Messaging.Message reading = allReadings.LastOrDefault(x => x.Label == sensorName);
                    if (reading != null)
                        row.ItemArray[3] = (string)reading.Body;
                }                
            }
        }
    }
}
