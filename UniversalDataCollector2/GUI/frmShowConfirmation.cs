using System;
using UniversalDataCollector.GUI;

namespace UniversalDataCollector
{
    public partial class frmShowConfirmation : frmBase
    {
        public string Message;

        public frmShowConfirmation()
        {
            InitializeComponent();
        }

        private void frmShowConfirmation_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Message;
            InitializeSpeech();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }


        private void btnYes_Click(object sender, EventArgs e)
        {

        }
    }
}
