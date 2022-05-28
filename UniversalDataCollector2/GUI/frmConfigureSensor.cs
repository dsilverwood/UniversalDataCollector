using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UniversalDataCollector.GUI;

namespace UniversalDataCollector
{
    public partial class frmConfigureSensor : frmBase
    {
        public int currentRow;
        public bool isNew = false;
        public DataRow row = null;

        public frmConfigureSensor()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(IsDataValid())
            {
                dataSetSensor.Tables[0].AcceptChanges();
                row = dataSetSensor.Tables[0].Rows[0];
            }
        }

        private bool IsDataValid()
        {
            bool dataValid = true;

            if(IsDuplicateSensorName(txtBoxSensorName.Text))
            {
                ShowValidationMessage(txtBoxSensorName.Text + " sensor already has been defined. Choose another name.");
                dataValid = false;
            }
            if(txtBoxSensorName.Text.Length < 8 || !txtBoxSensorName.Text.All(char.IsLetterOrDigit) || txtBoxSensorName.Text.Contains(" "))
            {
                ShowValidationMessage("Sensor name must be: at least 8 characters long, contain only letters and numbers and no blank spaces.");
                dataValid = false;
            }
            return dataValid;
        }

        private void ShowValidationMessage(string message)
        {
            frmShowMessage validationMessage = new frmShowMessage();
            validationMessage.Message = message;
            validationMessage.ShowDialog();
            DialogResult = DialogResult.None;
        }

        private bool IsDuplicateSensorName(string newSensorName)
        {
            bool isDuplicateSensor = false;
            //if(dataTableSensor.Rows.Count > 0)
            //{
            //    DataRow rowFound = dataTableSensor.Rows.Find(newSensorName);
            //    if (rowFound != null)
            //    {
            //        isDuplicateSensor = dataTableSensor.Rows.IndexOf(rowFound) != currentRow;
            //    }
            //}

            return isDuplicateSensor;
        }

        private void cmbBoxInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInterfaceTab(cmbBoxInterface.Text);
        }

        private void frmSensor_Load(object sender, EventArgs e)
        {
            if (isNew)
            {
                dataSetSensor.Tables[0].Rows.Add();
            }
            else
            {
                dataSetSensor.Tables[0].ImportRow(row);
            }
            dataSetSensor.Tables[0].AcceptChanges();
            InitializeSpeech();
        }

        private void LoadInterfaceTab(string interf)
        {
            tabCtrlInterface.TabPages.Clear();
            if (interf == "GPIO")
                tabCtrlInterface.TabPages.Add(this.tabGeneralPurpose);
            else if (interf == "UART")
                tabCtrlInterface.TabPages.Add(this.tabUART);
            else if (interf == "SPI")
                tabCtrlInterface.TabPages.Add(this.tabSPI);
            else if (interf == "I2C")
                tabCtrlInterface.TabPages.Add(this.tabI2C);
        }

        private void txtBoxSamples_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxGPIOPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataSetSensor.Tables[0].RejectChanges();
        }

    }
}
