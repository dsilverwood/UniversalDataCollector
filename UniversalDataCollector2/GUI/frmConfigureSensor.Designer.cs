namespace UniversalDataCollector
{
    partial class frmConfigureSensor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSensorName = new System.Windows.Forms.Label();
            this.txtBoxSensorName = new System.Windows.Forms.TextBox();
            this.dataSetSensor = new System.Data.DataSet();
            this.dataTableSensor = new System.Data.DataTable();
            this.SensorName = new System.Data.DataColumn();
            this.GPIO_Pin = new System.Data.DataColumn();
            this.Tx_GPIO_Pin = new System.Data.DataColumn();
            this.Rx_GPIO_Pin = new System.Data.DataColumn();
            this.SDA_GPIO_Pin = new System.Data.DataColumn();
            this.SCL_GPIO_Pin = new System.Data.DataColumn();
            this.Interface = new System.Data.DataColumn();
            this.IO = new System.Data.DataColumn();
            this.Sample = new System.Data.DataColumn();
            this.Time = new System.Data.DataColumn();
            this.DefaultState = new System.Data.DataColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxInterface = new System.Windows.Forms.ComboBox();
            this.tabCtrlInterface = new System.Windows.Forms.TabControl();
            this.tabGeneralPurpose = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGPIOPin = new System.Windows.Forms.Label();
            this.txtBoxGPIOPin = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIO = new System.Windows.Forms.Label();
            this.cmbBoxIO = new System.Windows.Forms.ComboBox();
            this.tabUART = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRxPin = new System.Windows.Forms.TextBox();
            this.txtBoxTxPin = new System.Windows.Forms.TextBox();
            this.tabI2C = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxSCLPin = new System.Windows.Forms.TextBox();
            this.txtBoxSDAPin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeviceAddress = new System.Windows.Forms.Label();
            this.txtBoxDeviceAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSPI = new System.Windows.Forms.TabPage();
            this.lblSamples = new System.Windows.Forms.Label();
            this.txtBoxSamples = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbBoxTime = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSensor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabCtrlInterface.SuspendLayout();
            this.tabGeneralPurpose.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabUART.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabI2C.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(18, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 590);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.lblSensorName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSensorName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSamples, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSamples, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxTime, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1101, 571);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblSensorName
            // 
            this.lblSensorName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorName.Location = new System.Drawing.Point(32, 16);
            this.lblSensorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(164, 26);
            this.lblSensorName.TabIndex = 0;
            this.lblSensorName.Text = "Sensor Name:";
            // 
            // txtBoxSensorName
            // 
            this.txtBoxSensorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxSensorName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.SensorName", true));
            this.txtBoxSensorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSensorName.Location = new System.Drawing.Point(204, 13);
            this.txtBoxSensorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSensorName.MaxLength = 20;
            this.txtBoxSensorName.Name = "txtBoxSensorName";
            this.txtBoxSensorName.Size = new System.Drawing.Size(205, 32);
            this.txtBoxSensorName.TabIndex = 5;
            // 
            // dataSetSensor
            // 
            this.dataSetSensor.DataSetName = "NewDataSet";
            this.dataSetSensor.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableSensor});
            // 
            // dataTableSensor
            // 
            this.dataTableSensor.Columns.AddRange(new System.Data.DataColumn[] {
            this.SensorName,
            this.GPIO_Pin,
            this.Tx_GPIO_Pin,
            this.Rx_GPIO_Pin,
            this.SDA_GPIO_Pin,
            this.SCL_GPIO_Pin,
            this.Interface,
            this.IO,
            this.Sample,
            this.Time,
            this.DefaultState});
            this.dataTableSensor.TableName = "dataTableSensor";
            // 
            // SensorName
            // 
            this.SensorName.ColumnName = "SensorName";
            // 
            // GPIO_Pin
            // 
            this.GPIO_Pin.ColumnName = "GPIO_Pin";
            // 
            // Tx_GPIO_Pin
            // 
            this.Tx_GPIO_Pin.ColumnName = "Tx_GPIO_Pin";
            // 
            // Rx_GPIO_Pin
            // 
            this.Rx_GPIO_Pin.ColumnName = "Rx_GPIO_Pin";
            // 
            // SDA_GPIO_Pin
            // 
            this.SDA_GPIO_Pin.ColumnName = "SDA_GPIO_Pin";
            // 
            // SCL_GPIO_Pin
            // 
            this.SCL_GPIO_Pin.ColumnName = "SCL_GPIO_Pin";
            // 
            // Interface
            // 
            this.Interface.ColumnName = "Interface";
            // 
            // IO
            // 
            this.IO.ColumnName = "IO";
            // 
            // Sample
            // 
            this.Sample.ColumnName = "Sample";
            // 
            // Time
            // 
            this.Time.ColumnName = "Time";
            // 
            // DefaultState
            // 
            this.DefaultState.ColumnName = "DefaultState";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(948, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 72);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(676, 494);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 72);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 6);
            this.groupBox1.Controls.Add(this.cmbBoxInterface);
            this.groupBox1.Controls.Add(this.tabCtrlInterface);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 3);
            this.groupBox1.Size = new System.Drawing.Size(1092, 361);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Interface";
            // 
            // cmbBoxInterface
            // 
            this.cmbBoxInterface.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxInterface.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBoxInterface.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.Interface", true));
            this.cmbBoxInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxInterface.FormattingEnabled = true;
            this.cmbBoxInterface.Items.AddRange(new object[] {
            "GPIO",
            "UART",
            "I2C",
            "SPI"});
            this.cmbBoxInterface.Location = new System.Drawing.Point(14, 31);
            this.cmbBoxInterface.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxInterface.Name = "cmbBoxInterface";
            this.cmbBoxInterface.Size = new System.Drawing.Size(235, 34);
            this.cmbBoxInterface.TabIndex = 14;
            this.cmbBoxInterface.SelectedIndexChanged += new System.EventHandler(this.cmbBoxInterface_SelectedIndexChanged);
            // 
            // tabCtrlInterface
            // 
            this.tabCtrlInterface.Controls.Add(this.tabGeneralPurpose);
            this.tabCtrlInterface.Controls.Add(this.tabUART);
            this.tabCtrlInterface.Controls.Add(this.tabI2C);
            this.tabCtrlInterface.Controls.Add(this.tabSPI);
            this.tabCtrlInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlInterface.Location = new System.Drawing.Point(14, 72);
            this.tabCtrlInterface.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCtrlInterface.Name = "tabCtrlInterface";
            this.tabCtrlInterface.SelectedIndex = 0;
            this.tabCtrlInterface.Size = new System.Drawing.Size(1070, 280);
            this.tabCtrlInterface.TabIndex = 20;
            // 
            // tabGeneralPurpose
            // 
            this.tabGeneralPurpose.Controls.Add(this.panel2);
            this.tabGeneralPurpose.Location = new System.Drawing.Point(4, 35);
            this.tabGeneralPurpose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGeneralPurpose.Name = "tabGeneralPurpose";
            this.tabGeneralPurpose.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGeneralPurpose.Size = new System.Drawing.Size(1062, 241);
            this.tabGeneralPurpose.TabIndex = 0;
            this.tabGeneralPurpose.Text = "GPIO";
            this.tabGeneralPurpose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 214);
            this.panel2.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.18829F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.81171F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblGPIOPin, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxGPIOPin, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIO, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbBoxIO, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.1134F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.8866F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 205);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default State:";
            // 
            // lblGPIOPin
            // 
            this.lblGPIOPin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGPIOPin.AutoSize = true;
            this.lblGPIOPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPIOPin.Location = new System.Drawing.Point(72, 76);
            this.lblGPIOPin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPIOPin.Name = "lblGPIOPin";
            this.lblGPIOPin.Size = new System.Drawing.Size(120, 26);
            this.lblGPIOPin.TabIndex = 1;
            this.lblGPIOPin.Text = "GPIO Pin:";
            // 
            // txtBoxGPIOPin
            // 
            this.txtBoxGPIOPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxGPIOPin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.GPIO_Pin", true));
            this.txtBoxGPIOPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGPIOPin.Location = new System.Drawing.Point(200, 73);
            this.txtBoxGPIOPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxGPIOPin.Name = "txtBoxGPIOPin";
            this.txtBoxGPIOPin.Size = new System.Drawing.Size(180, 32);
            this.txtBoxGPIOPin.TabIndex = 16;
            this.txtBoxGPIOPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxGPIOPin_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.DefaultState", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LOW",
            "HIGH"});
            this.comboBox1.Location = new System.Drawing.Point(200, 5);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 34);
            this.comboBox1.TabIndex = 1;
            // 
            // lblIO
            // 
            this.lblIO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIO.AutoSize = true;
            this.lblIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIO.Location = new System.Drawing.Point(141, 154);
            this.lblIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIO.Name = "lblIO";
            this.lblIO.Size = new System.Drawing.Size(51, 26);
            this.lblIO.TabIndex = 13;
            this.lblIO.Text = "I/O:";
            // 
            // cmbBoxIO
            // 
            this.cmbBoxIO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.IO", true));
            this.cmbBoxIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxIO.FormattingEnabled = true;
            this.cmbBoxIO.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.cmbBoxIO.Location = new System.Drawing.Point(200, 150);
            this.cmbBoxIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxIO.Name = "cmbBoxIO";
            this.cmbBoxIO.Size = new System.Drawing.Size(180, 34);
            this.cmbBoxIO.TabIndex = 15;
            // 
            // tabUART
            // 
            this.tabUART.Controls.Add(this.panel3);
            this.tabUART.Location = new System.Drawing.Point(4, 35);
            this.tabUART.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUART.Name = "tabUART";
            this.tabUART.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUART.Size = new System.Drawing.Size(1062, 241);
            this.tabUART.TabIndex = 1;
            this.tabUART.Text = "UART";
            this.tabUART.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(10, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 189);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.3871F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.6129F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBoxRxPin, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBoxTxPin, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(465, 145);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tx GPIO Pin:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rx GPIO Pin:";
            // 
            // txtBoxRxPin
            // 
            this.txtBoxRxPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxRxPin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.Rx_GPIO_Pin", true));
            this.txtBoxRxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRxPin.Location = new System.Drawing.Point(182, 69);
            this.txtBoxRxPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRxPin.Name = "txtBoxRxPin";
            this.txtBoxRxPin.Size = new System.Drawing.Size(180, 32);
            this.txtBoxRxPin.TabIndex = 18;
            this.txtBoxRxPin.Text = "15";
            // 
            // txtBoxTxPin
            // 
            this.txtBoxTxPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxTxPin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.Tx_GPIO_Pin", true));
            this.txtBoxTxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTxPin.Location = new System.Drawing.Point(182, 12);
            this.txtBoxTxPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxTxPin.Name = "txtBoxTxPin";
            this.txtBoxTxPin.Size = new System.Drawing.Size(180, 32);
            this.txtBoxTxPin.TabIndex = 17;
            this.txtBoxTxPin.Text = "14";
            // 
            // tabI2C
            // 
            this.tabI2C.Controls.Add(this.tableLayoutPanel4);
            this.tabI2C.Location = new System.Drawing.Point(4, 35);
            this.tabI2C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabI2C.Name = "tabI2C";
            this.tabI2C.Size = new System.Drawing.Size(1062, 241);
            this.tabI2C.TabIndex = 2;
            this.tabI2C.Text = "I2C";
            this.tabI2C.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.29412F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.70588F));
            this.tableLayoutPanel4.Controls.Add(this.txtBoxSCLPin, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtBoxSDAPin, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblDeviceAddress, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBoxDeviceAddress, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 177);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // txtBoxSCLPin
            // 
            this.txtBoxSCLPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxSCLPin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.SCL_GPIO_Pin", true));
            this.txtBoxSCLPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSCLPin.Location = new System.Drawing.Point(215, 132);
            this.txtBoxSCLPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSCLPin.Name = "txtBoxSCLPin";
            this.txtBoxSCLPin.Size = new System.Drawing.Size(128, 32);
            this.txtBoxSCLPin.TabIndex = 22;
            this.txtBoxSCLPin.Text = "3";
            // 
            // txtBoxSDAPin
            // 
            this.txtBoxSDAPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxSDAPin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.SDA_GPIO_Pin", true));
            this.txtBoxSDAPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSDAPin.Location = new System.Drawing.Point(215, 74);
            this.txtBoxSDAPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSDAPin.Name = "txtBoxSDAPin";
            this.txtBoxSDAPin.Size = new System.Drawing.Size(128, 32);
            this.txtBoxSDAPin.TabIndex = 21;
            this.txtBoxSDAPin.Text = "2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "SDA GPIO Pin:";
            // 
            // lblDeviceAddress
            // 
            this.lblDeviceAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeviceAddress.AutoSize = true;
            this.lblDeviceAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceAddress.Location = new System.Drawing.Point(21, 17);
            this.lblDeviceAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceAddress.Name = "lblDeviceAddress";
            this.lblDeviceAddress.Size = new System.Drawing.Size(186, 26);
            this.lblDeviceAddress.TabIndex = 18;
            this.lblDeviceAddress.Text = "Device Address:";
            // 
            // txtBoxDeviceAddress
            // 
            this.txtBoxDeviceAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxDeviceAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeviceAddress.Location = new System.Drawing.Point(215, 14);
            this.txtBoxDeviceAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDeviceAddress.Name = "txtBoxDeviceAddress";
            this.txtBoxDeviceAddress.Size = new System.Drawing.Size(128, 32);
            this.txtBoxDeviceAddress.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "SCL GPIO Pin:";
            // 
            // tabSPI
            // 
            this.tabSPI.BackColor = System.Drawing.Color.Transparent;
            this.tabSPI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabSPI.Location = new System.Drawing.Point(4, 35);
            this.tabSPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSPI.Name = "tabSPI";
            this.tabSPI.Size = new System.Drawing.Size(1062, 241);
            this.tabSPI.TabIndex = 3;
            this.tabSPI.Text = "SPI";
            this.tabSPI.UseVisualStyleBackColor = true;
            // 
            // lblSamples
            // 
            this.lblSamples.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSamples.AutoSize = true;
            this.lblSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamples.Location = new System.Drawing.Point(84, 75);
            this.lblSamples.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSamples.Name = "lblSamples";
            this.lblSamples.Size = new System.Drawing.Size(112, 26);
            this.lblSamples.TabIndex = 2;
            this.lblSamples.Text = "Samples:";
            // 
            // txtBoxSamples
            // 
            this.txtBoxSamples.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxSamples.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.Sample", true));
            this.txtBoxSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSamples.Location = new System.Drawing.Point(204, 72);
            this.txtBoxSamples.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSamples.MaxLength = 4;
            this.txtBoxSamples.Name = "txtBoxSamples";
            this.txtBoxSamples.Size = new System.Drawing.Size(205, 32);
            this.txtBoxSamples.TabIndex = 7;
            this.txtBoxSamples.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSamples_KeyPress);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(549, 76);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 25);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "per";
            // 
            // cmbBoxTime
            // 
            this.cmbBoxTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetSensor, "dataTableSensor.Time", true));
            this.cmbBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxTime.FormattingEnabled = true;
            this.cmbBoxTime.Items.AddRange(new object[] {
            "second",
            "minute",
            "hour",
            "day"});
            this.cmbBoxTime.Location = new System.Drawing.Point(600, 71);
            this.cmbBoxTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxTime.Name = "cmbBoxTime";
            this.cmbBoxTime.Size = new System.Drawing.Size(205, 34);
            this.cmbBoxTime.TabIndex = 11;
            // 
            // frmConfigureSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 612);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConfigureSensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure a Sensor";
            this.Load += new System.EventHandler(this.frmSensor_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSensor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabCtrlInterface.ResumeLayout(false);
            this.tabGeneralPurpose.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabUART.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabI2C.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSamples;
        private System.Windows.Forms.Label lblGPIOPin;
        private System.Windows.Forms.Label lblSensorName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxSensorName;
        private System.Windows.Forms.TextBox txtBoxSamples;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbBoxTime;
        private System.Windows.Forms.Label lblIO;
        private System.Windows.Forms.ComboBox cmbBoxInterface;
        private System.Windows.Forms.ComboBox cmbBoxIO;
        private System.Windows.Forms.TextBox txtBoxGPIOPin;
        private System.Windows.Forms.TextBox txtBoxDeviceAddress;
        private System.Windows.Forms.Label lblDeviceAddress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TabControl tabCtrlInterface;
        private System.Windows.Forms.TabPage tabGeneralPurpose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabUART;
        private System.Windows.Forms.TabPage tabI2C;
        private System.Windows.Forms.TabPage tabSPI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTxPin;
        private System.Windows.Forms.TextBox txtBoxRxPin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtBoxSCLPin;
        private System.Windows.Forms.TextBox txtBoxSDAPin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.DataSet dataSetSensor;
        private System.Data.DataTable dataTableSensor;
        private System.Data.DataColumn SensorName;
        private System.Data.DataColumn GPIO_Pin;
        private System.Data.DataColumn Tx_GPIO_Pin;
        private System.Data.DataColumn Rx_GPIO_Pin;
        private System.Data.DataColumn SDA_GPIO_Pin;
        private System.Data.DataColumn SCL_GPIO_Pin;
        private System.Data.DataColumn Interface;
        private System.Data.DataColumn IO;
        private System.Data.DataColumn Sample;
        private System.Data.DataColumn Time;
        private System.Data.DataColumn DefaultState;
    }
}