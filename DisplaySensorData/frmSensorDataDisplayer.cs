using System;
using System.Diagnostics;
using System.IO;
using System.Messaging;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using CommonLibrary;
using System.Speech.Recognition;

namespace SensorDataDisplayer
{
    public partial class frmSensorDataDisplayer : Form
    {
        private MessageQueue inboundDataQueue;
        private string currentSensorName = "";
        private string currentSensorInterface = "";
        private SpeechRecognitionEngine speech = null;

        public frmSensorDataDisplayer()
        {
            InitializeComponent();
        }

        private void LoadGrammar()
        {
            speech.UnloadAllGrammars();

            GrammarBuilder builder = new GrammarBuilder("close window");
            Grammar sensorGrammar = new Grammar(builder);
            sensorGrammar.Name = "CloseWindow";
            speech.LoadGrammar(sensorGrammar);
        }

        private void InitializeSpeech()
        {
            if (speech == null)
            {
                speech = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
                speech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Recognized);
                speech.SetInputToDefaultAudioDevice();
            }
            LoadGrammar();
            speech.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
            if (e.Result.Text.ToLower().Contains("close window"))
            {
                this.Close();
            }
        }

        private void frmSensorDataDisplayer_Load(object sender, EventArgs e)
        {
            if(IsRaspberryReady())
            {
                currentSensorName = Environment.GetCommandLineArgs()[1];
                currentSensorInterface = Environment.GetCommandLineArgs()[2];
                if (!string.IsNullOrEmpty(currentSensorName))
                {
                    this.Text = currentSensorName;
                    StartToMonitorSensor();
                    inboundDataQueue = new MessageQueue(@".\Private$\InboundQueue");
                    inboundDataQueue.Purge();
                    Thread.Sleep(1000);
                    inboundDataQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    StartTimer();
                    // after all processing, delete all the messages
                    inboundDataQueue.Purge();
                }
                else
                {
                    // TODO: Log error !!!!!!
                }
            }
            else
            {
                Environment.Exit(1);
            }
            InitializeSpeech();
        }

        private bool IsRaspberryReady()
        {
            return Program.myRaspberry.Ping();
        }

        private void StartTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshDisplayedData();
        }

        private void RefreshDisplayedData()
        {
            string sensorData = "defaultDebugValue";
            // GetAllMessages() is making a snapshot copy of messages, and will not purge or remove from the queue
            System.Messaging.Message[] messages = inboundDataQueue.GetAllMessages();

            foreach (System.Messaging.Message message in messages)
            {
                sensorData = (string)message.Body;
                string timeString = DateTime.Now.ToString();
                lstViewSensorData.Items.Add(new ListViewItem(timeString + "  " + sensorData));
            }
            if(lstViewSensorData.Items.Count > 0)
                lstViewSensorData.Items[lstViewSensorData.Items.Count - 1].EnsureVisible();
            inboundDataQueue.Purge();
        }

        private void StartToMonitorSensor()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string toExecute = "MonitorSensor.exe";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = toExecute;
            startInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            startInfo.Verb = "runas";
            startInfo.Arguments = currentSensorName + " " + currentSensorInterface;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            try
            {
                bool started = process.Start();
           
                //string err = process.StandardError.ReadToEnd();
                //process.WaitForExit();
                //int exitCode = process.ExitCode;
                //process.Close();
                //if (exitCode != 0)
                //{
                //    frmShowMessage errorMessage = new frmShowMessage();
                //    errorMessage.Message = ConfigureAndMonitor.UploadErrorMessage + err;
                //    errorMessage.Text = "Error";
                //    errorMessage.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                ErrorLogging.Add(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
