using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Reflection;
using CommonLibrary;
using UniversalDataCollector.Resources;
using UniversalDataCollector.GUI;

namespace UniversalDataCollector
{
    public partial class frmConfigureSensorList : frmBase
    {
        private DataSet ds = null;

        public frmConfigureSensorList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmConfigureSensor addSensor = new frmConfigureSensor();
            ((DataTable)dataGridViewSensor.DataSource).AcceptChanges();
            addSensor.isNew = true;
     
            DialogResult result = addSensor.ShowDialog();
            if (result == DialogResult.OK)
            {
                ((DataTable)dataGridViewSensor.DataSource).ImportRow(addSensor.row);
                SaveToXML();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GetConfigurationFile()
        {
            return ((string)Settings1.Default["SensorConfigFilename"]);
        }

        private bool SaveToXML()
        {
            bool success = true;
            DataTable dt = (DataTable)dataGridViewSensor.DataSource;

                try
                {
                    dt.WriteXml(GetConfigurationFile(),XmlWriteMode.WriteSchema);
                }
                catch (Exception ex)
                {
                    success = false;
                    ErrorLogging.Add(ex.ToString());
                }
            return (success);
        }

        // Prepare files with one instance of sensor configuration data per file
        // These files will be moved to sensor executable folder under Linux
        // One sensor == one executable to retrieve sensor data == one associated xml configuration file under Linux
        private bool SaveToXMLForExport()
        {
            bool success = true;

            int i = 0;
            EmptyExportFolder();
            
            foreach (DataRow row in ((DataTable)dataGridViewSensor.DataSource).Rows)
            {
                DataTable clonedDataTable = ((DataTable)dataGridViewSensor.DataSource).Clone();
                clonedDataTable.ImportRow(row);
                string sensorName = row.ItemArray[0].ToString();
                string fullPath = Path.Combine((string)Settings1.Default["ExportFolder"], sensorName + ".xml");
                clonedDataTable.WriteXml(fullPath);
                i++;               
            }

            return success;
        }

        private void EmptyExportFolder()
        {
            DirectoryInfo di = new DirectoryInfo((string)Settings1.Default["ExportFolder"]);
            foreach (FileInfo file in di.GetFiles())
                file.Delete();
        }

        private void frmConfigureSensors_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            PrivateLoad();
            InitializeSpeech();
        }

        private void PrivateLoad()
        {
            if (File.Exists(GetConfigurationFile()))
            {
                XmlReader xmlFile = XmlReader.Create(GetConfigurationFile(), new XmlReaderSettings());
                if(ds.Tables.Count > 0)
                    ds.Tables[0].Rows.Clear();
                ds.ReadXml(xmlFile, XmlReadMode.ReadSchema);
                xmlFile.Close();
            }
            dataGridViewSensor.AutoSize = true;
            dataGridViewSensor.DataSource = ds.Tables[0];
            FilterColumns(false);
         //   dataGridViewSensor.RowCount = 10;
        }

        private void FilterColumns(bool isShown)
        {
            dataGridViewSensor.Columns["IO"].Visible = isShown;
            dataGridViewSensor.Columns["GPIO_Pin"].Visible = isShown;
            dataGridViewSensor.Columns["SDA_GPIO_Pin"].Visible = isShown;
            dataGridViewSensor.Columns["SCL_GPIO_Pin"].Visible = isShown;
            dataGridViewSensor.Columns["Tx_GPIO_Pin"].Visible = isShown;
            dataGridViewSensor.Columns["Rx_GPIO_Pin"].Visible = isShown;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewSensor.CurrentRow.Index;
            if (selectedRow > -1 && dataGridViewSensor.CurrentCell != null)
            {
                frmShowConfirmation confirm = new frmShowConfirmation();
                confirm.Message = String.Format(ConfigureSensors.DeleteConfirm, dataGridViewSensor.Rows[selectedRow].Cells[0].Value.ToString());
                confirm.ShowDialog();
                if(confirm.DialogResult == DialogResult.Yes)
                {
                    DataRow row = ds.Tables[0].Rows[selectedRow];
                    row.Delete();
                    dataGridViewSensor.Refresh();
                    DataTable dt = (DataTable)dataGridViewSensor.DataSource;
                    SaveToXML();
                 }
            }
        }
 
        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string upload = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Upload.bat";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = @"cmd.exe";
            startInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            startInfo.Verb = "runas";
            startInfo.Arguments = "/C " + upload;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            process.StartInfo = startInfo;
            try 
            {
                process.Start();
                string err = process.StandardError.ReadToEnd();
                process.WaitForExit(); 
                int exitCode = process.ExitCode;
                process.Close();
                if (exitCode != 0)
                {
                    frmShowMessage errorMessage = new frmShowMessage();
                    errorMessage.Message = ConfigureSensors.UploadErrorMessage + err;
                    errorMessage.Text = "Error";
                    errorMessage.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Add(ex.ToString());
            }
        }

        private void Modify(int currentRow)
        {
            int rowCount = ((DataTable)dataGridViewSensor.DataSource).Rows.Count;
            if (currentRow > -1 && currentRow < rowCount)
            {
                frmConfigureSensor viewSensor = new frmConfigureSensor();
                viewSensor.currentRow = currentRow;
                viewSensor.row = ((DataTable)dataGridViewSensor.DataSource).Rows[currentRow];
                DialogResult result = viewSensor.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ((DataTable)dataGridViewSensor.DataSource).Rows[currentRow].ItemArray = viewSensor.row.ItemArray;
                    SaveToXML();
                }
            }
        }

        private void dataGridViewSensor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modify(e.RowIndex);
        }

        private string GetCurrentSensorName()
        {
            string sensorName = "";
            DataRow row = null;
            int selectedRowIndex = dataGridViewSensor.CurrentCell.RowIndex;
            if(selectedRowIndex > -1)
            {
                row = ds.Tables[0].Rows[selectedRowIndex];
                sensorName = row["SensorName"].ToString();
            }

            return sensorName;
        }

        private void displayDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonitorSensors monitorSensors = new frmMonitorSensors();
            monitorSensors.Initialize(ds);
            monitorSensors.ShowDialog();


            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //string toExecute = Path.GetFullPath(Path.Combine(path, @"..\..\..\")) + "DisplaySensorData\\bin\\Debug\\SensorDataDisplayer.exe";
            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.FileName = toExecute;
            //startInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //startInfo.Verb = "runas";
            ////  startInfo.Arguments = "/C ";
            //startInfo.Arguments = GetCurrentSensorName();
            //startInfo.RedirectStandardError = true;
            //startInfo.UseShellExecute = false;
            //process.StartInfo = startInfo;
            //try
            //{
            //    process.Start();
            //    //string err = process.StandardError.ReadToEnd();
            //    //process.WaitForExit();
            //    //int exitCode = process.ExitCode;
            //    //process.Close();
            //    //if (exitCode != 0)
            //    //{
            //    //    frmShowMessage errorMessage = new frmShowMessage();
            //    //    errorMessage.Message = ConfigureAndMonitor.UploadErrorMessage + err;
            //    //    errorMessage.Text = "Error";
            //    //    errorMessage.ShowDialog();
            //    //}
            //}
            //catch (Exception ex)
            //{
            //    int a = 1;

            //}
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneralConfiguration config = new frmGeneralConfiguration();
            config.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Modify(dataGridViewSensor.CurrentCell.RowIndex);
        }

    }
}
