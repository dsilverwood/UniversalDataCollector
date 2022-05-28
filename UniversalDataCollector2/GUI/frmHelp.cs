using System;

namespace UniversalDataCollector.GUI
{
    public partial class frmHelp : frmBase
    {
        public string Message;

        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            lblHelpContent.Text = Message;
            InitializeSpeech();
        }

    }
}
