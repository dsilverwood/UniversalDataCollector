using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Windows.Forms;
using CommonLibrary;
using System.Collections.Generic;
using UniversalDataCollector.Resources;
using UniversalDataCollector.GUI;
using System.Speech.Recognition;

namespace UniversalDataCollector
{
    public partial class frmGeneralConfiguration : frmBase
    {
        public frmGeneralConfiguration()
        {
            InitializeComponent();
        }

        private void frmGeneralConfiguration_Load(object sender, EventArgs e)
        {            
            cmbBoxBoard.DataSource = new BindingSource(Program.myRaspberry.GetAllBoards(), null);
            cmbBoxBoard.DisplayMember = "Value";
            cmbBoxBoard.ValueMember = "Key";

            if (File.Exists((string)Settings1.Default["GeneralConfigFilename"]))
            {
                XmlReader xmlFile = XmlReader.Create((string)Settings1.Default["GeneralConfigFilename"], new XmlReaderSettings());
                dataSetConfiguration.ReadXml(xmlFile, XmlReadMode.ReadSchema);
                xmlFile.Close();
            }
            else
            {
                DataRow row = dataSetConfiguration.Tables[0].Rows.Add();
            }

            AssignDefaultValues();

            dataSetConfiguration.Tables[0].AcceptChanges();

            InitializeSpeech();
        }

        // Assign default values to unpopulated fields
        private void AssignDefaultValues()
        {
            object[] items = dataSetConfiguration.Tables[0].Rows[0].ItemArray;
            for (int i = 0; i < items.Length; i++)
            {
                object item = items[i];
                if (item == DBNull.Value)
                    items[i] = dataSetConfiguration.Tables[0].Columns[i].DefaultValue;
            }
            dataSetConfiguration.Tables[0].Rows[0].ItemArray = items;
        }
  
        private void ReAssignValue(string newValue)
        {
            object[] items = dataSetConfiguration.Tables[0].Rows[0].ItemArray;
            items[0] = newValue;
            dataSetConfiguration.Tables[0].Rows[0].ItemArray = items;
        }

        override protected void LoadGrammar(Form form)
        {
            base.LoadGrammar(this);
            Choices helpChoices = new Choices();
            helpChoices.Add(lblLocalComputerIP.Text);
            helpChoices.Add(lblPort.Text);
            helpChoices.Add(lblRaspberryIP.Text);
            helpChoices.Add(lblRaspberryPiUser.Text);
            helpChoices.Add(lblPort.Text);

            speech.LoadGrammar(GetChoicesGrammar("what is", helpChoices));
        }

        override protected void Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            base.Recognized(sender, e);
            if (e.Result.Text.ToLower().Contains("what is"))
            {
                string command = e.Result.Text.ToLower().Trim();
                string helpName = (command.Remove(command.IndexOf("what is"), "what is".Length)).Trim();
                if (helpName.Contains(lblLocalComputerIP.Text.ToLower().Trim().Replace(":", "")))
                    pctBoxHelpComputerIP_Click(this, null);
                else if (helpName.Contains(lblRaspberryIP.Text.ToLower().Trim().Replace(":", "")))
                    pctBoxHelpRaspberryIP_Click(this, null);
                else if (helpName.Contains(lblRaspberryPiUser.Text.ToLower().Trim().Replace(":", "")))
                    pctBoxHelpRaspberryUser_Click(this, null);
                else if (helpName.Contains(lblPort.Text.ToLower().Trim().Replace(":", "")))
                    pctBoxHelpPort_Click(this, null);
            }
        }

        private string GetLocalIP()
        {
            string localIP = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                // TODO: Improve this !!! to get local ip for sure....
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        //private string GetLocalIP2()
        //{
        //    string localIP = "";
        //    try
        //    { // get host IP addresses
        //        IPAddress[] hostIPs = Dns.GetHostAddresses(host);
        //        // get local IP addresses
        //        IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

        //        // test if any host IP equals to any local IP or to localhost
        //        foreach (IPAddress hostIP in hostIPs)
        //        {
        //            // is localhost
        //            if (IPAddress.IsLoopback(hostIP))
        //                localIP = hostIP.ToString();
        //        }
        //    }
        //    catch { }
        //    return localIP;
        //}

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveToXML();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataSetConfiguration.Tables[0].RejectChanges();
            Close();
        }

        private bool SaveToXML()
        {
            bool success = true;

            try
            {
                dataSetConfiguration.Tables[0].AcceptChanges();
                dataSetConfiguration.Tables[0].WriteXml((string)Settings1.Default["GeneralConfigFilename"], XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                success = false;
                ErrorLogging.Add(ex.ToString());
            }
            return (success);
        }

        private void btnTestRaspberryIP_Click(object sender, EventArgs e)
        {
            // TODO: Here, when successfully connected, it would be nice to show the Raspberry model number
            Cursor.Current = Cursors.WaitCursor;
            frmShowMessage messageToUser = new frmShowMessage();
            if (!Network.Ping(txtBoxRaspberryIP.Text))
            {
                Cursor.Current = Cursors.Default;
                messageToUser.Message = String.Join(
                                 "",
                                 "Could not establish a connection with the Raspberry Pi.",
                                 "Make sure the Raspberry Pi is powered up and connected to the internet.",
                                 "If you have Wifi, type the command (under Raspbian):",
                                 "ifconfig wlan0, to get the address of the Pi.");
            }
            else
            {
                Cursor.Current = Cursors.Default;
                messageToUser.Message = "Success! Connection was established with the Raspberry Pi.";
            }
            messageToUser.ShowDialog();
        }

        private void btnDetectBoard_Click(object sender, EventArgs e)
        {
            string output = "";
            Cursor.Current = Cursors.WaitCursor;
            if(Network.Ping(txtBoxRaspberryIP.Text))
                output = Program.myRaspberry.ExecuteBashCommand("pinout", ".xyz");
            Cursor.Current = Cursors.Default;
            frmShowMessage detectResult = new frmShowMessage();
            detectResult.Message = String.Join(
                                 "",
                                 "Could not establish a connection with the Raspberry Pi.",
                                 "Make sure the Raspberry Pi is powered up and connected to the internet.",
                                 "If you have Wifi, type the command (under Raspbian):",
                                 "ifconfig wlan0, to get the address of the Pi.");
            if (!string.IsNullOrEmpty(output))
            {
                Dictionary<int, string> boards = Program.myRaspberry.GetAllBoards();
                var sortedBoards = from entry in boards orderby entry.Key ascending select entry;
                foreach (KeyValuePair<int, string> entry in sortedBoards)
                {
                    string searchString = entry.Value.Replace("Pi ", "");
                    if (output.Contains(searchString))
                    {
                        cmbBoxBoard.SelectedIndex = entry.Key;
                        detectResult.Message = "The Raspberry " + entry.Value + " has been successfully detected.";
                        ReAssignValue(entry.Value);
                        break;
                    }
                }
            }

            detectResult.ShowDialog();
        }

        private void pctBoxHelpComputerIP_Click(object sender, EventArgs e)
        {
            ShowHelp(GeneralConfiguration.HomeIPHelp);
        }

        private void pctBoxHelpRaspberryIP_Click(object sender, EventArgs e)
        {
            ShowHelp(GeneralConfiguration.RaspberryIPHelp);
        }

        private void pctBoxHelpRaspberryUser_Click(object sender, EventArgs e)
        {
            ShowHelp(GeneralConfiguration.RaspberryUserHelp);
        }

        private void pctBoxHelpPort_Click(object sender, EventArgs e)
        {
            ShowHelp(GeneralConfiguration.RaspberryPortHelp);
        }

        private void ShowHelp(string helpResource)
        {
            GUI.frmHelp help = new GUI.frmHelp();
            help.Message = helpResource;
            help.ShowDialog();
        }

        private void frmGeneralConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
           // FinalizeSpeech();
        }
    }
}
