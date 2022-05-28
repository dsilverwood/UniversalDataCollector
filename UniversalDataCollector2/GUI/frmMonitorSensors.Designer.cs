namespace UniversalDataCollector
{
    partial class frmMonitorSensors
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
            this.components = new System.ComponentModel.Container();
            this.timerRefreshReadings = new System.Windows.Forms.Timer(this.components);
            this.grpBoxMonitorSensors = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMonitorSensors = new System.Windows.Forms.DataGridView();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configureSensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxMonitorSensors.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitorSensors)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRefreshReadings
            // 
            this.timerRefreshReadings.Enabled = true;
            this.timerRefreshReadings.Interval = 2000;
            this.timerRefreshReadings.Tick += new System.EventHandler(this.timerRefreshReadings_Tick);
            // 
            // grpBoxMonitorSensors
            // 
            this.grpBoxMonitorSensors.Controls.Add(this.tableLayoutPanel1);
            this.grpBoxMonitorSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMonitorSensors.Location = new System.Drawing.Point(18, 63);
            this.grpBoxMonitorSensors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxMonitorSensors.Name = "grpBoxMonitorSensors";
            this.grpBoxMonitorSensors.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxMonitorSensors.Size = new System.Drawing.Size(1152, 386);
            this.grpBoxMonitorSensors.TabIndex = 2;
            this.grpBoxMonitorSensors.TabStop = false;
            this.grpBoxMonitorSensors.Text = "Monitor Sensors";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMonitorSensors, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.87387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.12613F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1094, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewMonitorSensors
            // 
            this.dataGridViewMonitorSensors.AllowUserToAddRows = false;
            this.dataGridViewMonitorSensors.AllowUserToDeleteRows = false;
            this.dataGridViewMonitorSensors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMonitorSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonitorSensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorName,
            this.State,
            this.Command,
            this.Details});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewMonitorSensors, 5);
            this.dataGridViewMonitorSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMonitorSensors.EnableHeadersVisualStyles = false;
            this.dataGridViewMonitorSensors.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewMonitorSensors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMonitorSensors.Name = "dataGridViewMonitorSensors";
            this.dataGridViewMonitorSensors.RowHeadersWidth = 62;
            this.dataGridViewMonitorSensors.Size = new System.Drawing.Size(1086, 242);
            this.dataGridViewMonitorSensors.TabIndex = 0;
            this.dataGridViewMonitorSensors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonitorSensors_CellContentClick);
            // 
            // SensorName
            // 
            this.SensorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SensorName.HeaderText = "Sensor Name";
            this.SensorName.MinimumWidth = 8;
            this.SensorName.Name = "SensorName";
            this.SensorName.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 8;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 150;
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.MinimumWidth = 8;
            this.Command.Name = "Command";
            this.Command.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Command.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Command.Width = 150;
            // 
            // Details
            // 
            this.Details.HeaderText = "Value";
            this.Details.MinimumWidth = 8;
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.Width = 200;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(932, 257);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 77);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureSensorsToolStripMenuItem,
            this.generalConfigurationToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configureSensorsToolStripMenuItem
            // 
            this.configureSensorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.configureSensorsToolStripMenuItem.Name = "configureSensorsToolStripMenuItem";
            this.configureSensorsToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.configureSensorsToolStripMenuItem.Text = "Configure Sensors";
            this.configureSensorsToolStripMenuItem.Click += new System.EventHandler(this.configureSensorsToolStripMenuItem_Click);
            // 
            // generalConfigurationToolStripMenuItem
            // 
            this.generalConfigurationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.generalConfigurationToolStripMenuItem.Name = "generalConfigurationToolStripMenuItem";
            this.generalConfigurationToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.generalConfigurationToolStripMenuItem.Text = "General Configuration";
            this.generalConfigurationToolStripMenuItem.Click += new System.EventHandler(this.generalConfigurationToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // frmMonitorSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 468);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxMonitorSensors);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMonitorSensors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Sensors";
            this.Load += new System.EventHandler(this.frmMonitorSensors_Load);
            this.grpBoxMonitorSensors.ResumeLayout(false);
            this.grpBoxMonitorSensors.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitorSensors)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewMonitorSensors;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configureSensorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxMonitorSensors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.Timer timerRefreshReadings;
    }
}