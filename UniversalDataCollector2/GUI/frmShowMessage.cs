using System;
using System.Speech.Recognition;

namespace UniversalDataCollector.GUI
{
    public partial class frmShowMessage : frmBase
    {
        public string Message;

        public frmShowMessage()
        {
            InitializeComponent();
        }

        private void frmShowConfirmation_Load(object sender, EventArgs e)
        {
            InitializeSpeech();
            lblMessage.Text = Message;

        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }
    }
}
