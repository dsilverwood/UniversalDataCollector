namespace UniversalDataCollector
{
    partial class frmGeneralConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneralConfiguration));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBoard = new System.Windows.Forms.Label();
            this.cmbBoxBoard = new System.Windows.Forms.ComboBox();
            this.dataSetConfiguration = new System.Data.DataSet();
            this.dataTableConfiguration = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.lblLocalComputerIP = new System.Windows.Forms.Label();
            this.txtBoxLocalIP = new System.Windows.Forms.TextBox();
            this.lblRaspberryIP = new System.Windows.Forms.Label();
            this.txtBoxRaspberryIP = new System.Windows.Forms.TextBox();
            this.lblRaspberryWorkingFolder = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.lblRaspberryPiUser = new System.Windows.Forms.Label();
            this.txtBoxRaspberryUser = new System.Windows.Forms.TextBox();
            this.txtBoxRaspberryFolder = new System.Windows.Forms.TextBox();
            this.pctBoxHelpComputerIP = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblRasberyPassword = new System.Windows.Forms.Label();
            this.btnTestRaspberryIP = new System.Windows.Forms.Button();
            this.pctBoxHelpRaspberryIP = new System.Windows.Forms.PictureBox();
            this.pctBoxHelpRaspberryUser = new System.Windows.Forms.PictureBox();
            this.btnDetectBoard = new System.Windows.Forms.Button();
            this.pctBoxHelpPort = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpComputerIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpRaspberryIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpRaspberryUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.94737F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.05263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel1.Controls.Add(this.lblBoard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxBoard, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLocalComputerIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxLocalIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRaspberryIP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRaspberryIP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRaspberryWorkingFolder, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPort, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPort, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRaspberryPiUser, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRaspberryUser, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRaspberryFolder, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pctBoxHelpComputerIP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPassword, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRasberyPassword, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTestRaspberryIP, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pctBoxHelpRaspberryIP, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pctBoxHelpRaspberryUser, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDetectBoard, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pctBoxHelpPort, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBoard
            // 
            this.lblBoard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBoard.AutoSize = true;
            this.lblBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard.Location = new System.Drawing.Point(4, 89);
            this.lblBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(82, 26);
            this.lblBoard.TabIndex = 0;
            this.lblBoard.Text = "Board:";
            // 
            // cmbBoxBoard
            // 
            this.cmbBoxBoard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxBoard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.Board", true));
            this.cmbBoxBoard.DisplayMember = "dataTableConfiguration.Board";
            this.cmbBoxBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxBoard.FormattingEnabled = true;
            this.cmbBoxBoard.Location = new System.Drawing.Point(194, 85);
            this.cmbBoxBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxBoard.Name = "cmbBoxBoard";
            this.cmbBoxBoard.Size = new System.Drawing.Size(232, 34);
            this.cmbBoxBoard.TabIndex = 2;
            this.cmbBoxBoard.ValueMember = "dataTableConfiguration.Board";
            // 
            // dataSetConfiguration
            // 
            this.dataSetConfiguration.DataSetName = "NewDataSet";
            this.dataSetConfiguration.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableConfiguration});
            // 
            // dataTableConfiguration
            // 
            this.dataTableConfiguration.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dataTableConfiguration.TableName = "dataTableConfiguration";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Board";
            this.dataColumn1.DefaultValue = "Pi 3B";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "LocalIP";
            this.dataColumn2.DefaultValue = "10.0.0.0";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "RaspberryIP";
            this.dataColumn3.DefaultValue = "10.0.0.0";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "RaspberryWorkingFolder";
            this.dataColumn4.DefaultValue = "/home/pi/Documents/PlainGPIO/bin/Debug/PlainGPIO";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Port";
            this.dataColumn5.DefaultValue = "22";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "RaspberryUser";
            this.dataColumn6.DefaultValue = "pi";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "RaspberryPassword";
            this.dataColumn7.DefaultValue = "raspberry";
            // 
            // lblLocalComputerIP
            // 
            this.lblLocalComputerIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocalComputerIP.AutoSize = true;
            this.lblLocalComputerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalComputerIP.Location = new System.Drawing.Point(4, 5);
            this.lblLocalComputerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalComputerIP.Name = "lblLocalComputerIP";
            this.lblLocalComputerIP.Size = new System.Drawing.Size(169, 52);
            this.lblLocalComputerIP.TabIndex = 1;
            this.lblLocalComputerIP.Text = "This computer IP:";
            // 
            // txtBoxLocalIP
            // 
            this.txtBoxLocalIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxLocalIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.LocalIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxLocalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocalIP.Location = new System.Drawing.Point(194, 15);
            this.txtBoxLocalIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxLocalIP.Name = "txtBoxLocalIP";
            this.txtBoxLocalIP.Size = new System.Drawing.Size(232, 32);
            this.txtBoxLocalIP.TabIndex = 3;
            // 
            // lblRaspberryIP
            // 
            this.lblRaspberryIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRaspberryIP.AutoSize = true;
            this.lblRaspberryIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaspberryIP.Location = new System.Drawing.Point(4, 152);
            this.lblRaspberryIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaspberryIP.Name = "lblRaspberryIP";
            this.lblRaspberryIP.Size = new System.Drawing.Size(157, 52);
            this.lblRaspberryIP.TabIndex = 6;
            this.lblRaspberryIP.Text = "Raspberry Pi IP:";
            // 
            // txtBoxRaspberryIP
            // 
            this.txtBoxRaspberryIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxRaspberryIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.RaspberryIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxRaspberryIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRaspberryIP.Location = new System.Drawing.Point(194, 162);
            this.txtBoxRaspberryIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRaspberryIP.Name = "txtBoxRaspberryIP";
            this.txtBoxRaspberryIP.Size = new System.Drawing.Size(232, 32);
            this.txtBoxRaspberryIP.TabIndex = 7;
            // 
            // lblRaspberryWorkingFolder
            // 
            this.lblRaspberryWorkingFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRaspberryWorkingFolder.AutoSize = true;
            this.lblRaspberryWorkingFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaspberryWorkingFolder.Location = new System.Drawing.Point(4, 355);
            this.lblRaspberryWorkingFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaspberryWorkingFolder.Name = "lblRaspberryWorkingFolder";
            this.lblRaspberryWorkingFolder.Size = new System.Drawing.Size(157, 52);
            this.lblRaspberryWorkingFolder.TabIndex = 8;
            this.lblRaspberryWorkingFolder.Text = "Raspberry Pi Linux folder:";
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(4, 308);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(70, 26);
            this.lblPort.TabIndex = 10;
            this.lblPort.Text = "Port: ";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPort.Location = new System.Drawing.Point(194, 305);
            this.txtBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(232, 32);
            this.txtBoxPort.TabIndex = 11;
            // 
            // lblRaspberryPiUser
            // 
            this.lblRaspberryPiUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRaspberryPiUser.AutoSize = true;
            this.lblRaspberryPiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaspberryPiUser.Location = new System.Drawing.Point(4, 227);
            this.lblRaspberryPiUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaspberryPiUser.Name = "lblRaspberryPiUser";
            this.lblRaspberryPiUser.Size = new System.Drawing.Size(157, 52);
            this.lblRaspberryPiUser.TabIndex = 13;
            this.lblRaspberryPiUser.Text = "Raspberry Pi User:";
            // 
            // txtBoxRaspberryUser
            // 
            this.txtBoxRaspberryUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxRaspberryUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.RaspberryUser", true));
            this.txtBoxRaspberryUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRaspberryUser.Location = new System.Drawing.Point(194, 237);
            this.txtBoxRaspberryUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRaspberryUser.Name = "txtBoxRaspberryUser";
            this.txtBoxRaspberryUser.Size = new System.Drawing.Size(232, 32);
            this.txtBoxRaspberryUser.TabIndex = 14;
            // 
            // txtBoxRaspberryFolder
            // 
            this.txtBoxRaspberryFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxRaspberryFolder, 4);
            this.txtBoxRaspberryFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.RaspberryWorkingFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxRaspberryFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRaspberryFolder.Location = new System.Drawing.Point(194, 365);
            this.txtBoxRaspberryFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRaspberryFolder.Name = "txtBoxRaspberryFolder";
            this.txtBoxRaspberryFolder.Size = new System.Drawing.Size(764, 32);
            this.txtBoxRaspberryFolder.TabIndex = 9;
            // 
            // pctBoxHelpComputerIP
            // 
            this.pctBoxHelpComputerIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pctBoxHelpComputerIP.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxHelpComputerIP.Image")));
            this.pctBoxHelpComputerIP.Location = new System.Drawing.Point(436, 12);
            this.pctBoxHelpComputerIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxHelpComputerIP.Name = "pctBoxHelpComputerIP";
            this.pctBoxHelpComputerIP.Size = new System.Drawing.Size(39, 38);
            this.pctBoxHelpComputerIP.TabIndex = 17;
            this.pctBoxHelpComputerIP.TabStop = false;
            this.pctBoxHelpComputerIP.Click += new System.EventHandler(this.pctBoxHelpComputerIP_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(805, 418);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 69);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(625, 418);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 69);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetConfiguration, "dataTableConfiguration.RaspberryPassword", true));
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(805, 237);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(148, 32);
            this.txtBoxPassword.TabIndex = 16;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblRasberyPassword
            // 
            this.lblRasberyPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRasberyPassword.AutoSize = true;
            this.lblRasberyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRasberyPassword.Location = new System.Drawing.Point(625, 240);
            this.lblRasberyPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRasberyPassword.Name = "lblRasberyPassword";
            this.lblRasberyPassword.Size = new System.Drawing.Size(123, 26);
            this.lblRasberyPassword.TabIndex = 15;
            this.lblRasberyPassword.Text = "Password:";
            // 
            // btnTestRaspberryIP
            // 
            this.btnTestRaspberryIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestRaspberryIP.Location = new System.Drawing.Point(625, 146);
            this.btnTestRaspberryIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTestRaspberryIP.Name = "btnTestRaspberryIP";
            this.btnTestRaspberryIP.Size = new System.Drawing.Size(150, 64);
            this.btnTestRaspberryIP.TabIndex = 12;
            this.btnTestRaspberryIP.Text = "Test";
            this.btnTestRaspberryIP.UseVisualStyleBackColor = true;
            this.btnTestRaspberryIP.Click += new System.EventHandler(this.btnTestRaspberryIP_Click);
            // 
            // pctBoxHelpRaspberryIP
            // 
            this.pctBoxHelpRaspberryIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pctBoxHelpRaspberryIP.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxHelpRaspberryIP.Image")));
            this.pctBoxHelpRaspberryIP.Location = new System.Drawing.Point(436, 159);
            this.pctBoxHelpRaspberryIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxHelpRaspberryIP.Name = "pctBoxHelpRaspberryIP";
            this.pctBoxHelpRaspberryIP.Size = new System.Drawing.Size(39, 38);
            this.pctBoxHelpRaspberryIP.TabIndex = 18;
            this.pctBoxHelpRaspberryIP.TabStop = false;
            this.pctBoxHelpRaspberryIP.Click += new System.EventHandler(this.pctBoxHelpRaspberryIP_Click);
            // 
            // pctBoxHelpRaspberryUser
            // 
            this.pctBoxHelpRaspberryUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pctBoxHelpRaspberryUser.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxHelpRaspberryUser.Image")));
            this.pctBoxHelpRaspberryUser.Location = new System.Drawing.Point(436, 234);
            this.pctBoxHelpRaspberryUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxHelpRaspberryUser.Name = "pctBoxHelpRaspberryUser";
            this.pctBoxHelpRaspberryUser.Size = new System.Drawing.Size(39, 38);
            this.pctBoxHelpRaspberryUser.TabIndex = 19;
            this.pctBoxHelpRaspberryUser.TabStop = false;
            this.pctBoxHelpRaspberryUser.Click += new System.EventHandler(this.pctBoxHelpRaspberryUser_Click);
            // 
            // btnDetectBoard
            // 
            this.btnDetectBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectBoard.Location = new System.Drawing.Point(625, 68);
            this.btnDetectBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetectBoard.Name = "btnDetectBoard";
            this.btnDetectBoard.Size = new System.Drawing.Size(150, 68);
            this.btnDetectBoard.TabIndex = 20;
            this.btnDetectBoard.Text = "Detect Board";
            this.btnDetectBoard.UseVisualStyleBackColor = true;
            this.btnDetectBoard.Click += new System.EventHandler(this.btnDetectBoard_Click);
            // 
            // pctBoxHelpPort
            // 
            this.pctBoxHelpPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pctBoxHelpPort.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxHelpPort.Image")));
            this.pctBoxHelpPort.Location = new System.Drawing.Point(436, 302);
            this.pctBoxHelpPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxHelpPort.Name = "pctBoxHelpPort";
            this.pctBoxHelpPort.Size = new System.Drawing.Size(39, 38);
            this.pctBoxHelpPort.TabIndex = 21;
            this.pctBoxHelpPort.TabStop = false;
            this.pctBoxHelpPort.Click += new System.EventHandler(this.pctBoxHelpPort_Click);
            // 
            // frmGeneralConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 528);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGeneralConfiguration";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Configuration. For voice command, simply say \"What is\" followed by the la" +
    "bel name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGeneralConfiguration_FormClosing);
            this.Load += new System.EventHandler(this.frmGeneralConfiguration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpComputerIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpRaspberryIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpRaspberryUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHelpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBoard;
        private System.Windows.Forms.Label lblLocalComputerIP;
        private System.Windows.Forms.ComboBox cmbBoxBoard;
        private System.Windows.Forms.TextBox txtBoxLocalIP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRaspberryIP;
        private System.Windows.Forms.TextBox txtBoxRaspberryIP;
        private System.Windows.Forms.Label lblRaspberryWorkingFolder;
        private System.Windows.Forms.TextBox txtBoxRaspberryFolder;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Data.DataSet dataSetConfiguration;
        private System.Data.DataTable dataTableConfiguration;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.Button btnTestRaspberryIP;
        private System.Windows.Forms.Label lblRaspberryPiUser;
        private System.Windows.Forms.TextBox txtBoxRaspberryUser;
        private System.Windows.Forms.Label lblRasberyPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.PictureBox pctBoxHelpComputerIP;
        private System.Windows.Forms.PictureBox pctBoxHelpRaspberryIP;
        private System.Windows.Forms.PictureBox pctBoxHelpRaspberryUser;
        private System.Windows.Forms.Button btnDetectBoard;
        private System.Windows.Forms.PictureBox pctBoxHelpPort;
    }
}