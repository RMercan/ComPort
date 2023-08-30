
namespace ComPort
{
    partial class Form1
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
            this.CmbComPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChckRTS = new System.Windows.Forms.CheckBox();
            this.ChckDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbParityBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbDataBits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtDataIn = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.LblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.LblDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_writeLineOrWriteText = new System.Windows.Forms.ToolStripComboBox();
            this.saveToMySQLDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eXİTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAfterSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLİneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_TxEndLine = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_TxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxShowDataWith = new System.Windows.Forms.ToolStripComboBox();
            this.dataPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxDataPosition = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.multiplePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.in1PortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbComPort
            // 
            this.CmbComPort.FormattingEnabled = true;
            this.CmbComPort.Location = new System.Drawing.Point(122, 38);
            this.CmbComPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbComPort.Name = "CmbComPort";
            this.CmbComPort.Size = new System.Drawing.Size(158, 33);
            this.CmbComPort.TabIndex = 0;
            this.CmbComPort.DropDown += new System.EventHandler(this.CmbComPort_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChckRTS);
            this.groupBox1.Controls.Add(this.ChckDTR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CmbParityBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbStopBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbDataBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbComPort);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(290, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            // 
            // ChckRTS
            // 
            this.ChckRTS.AutoSize = true;
            this.ChckRTS.Location = new System.Drawing.Point(149, 266);
            this.ChckRTS.Name = "ChckRTS";
            this.ChckRTS.Size = new System.Drawing.Size(140, 29);
            this.ChckRTS.TabIndex = 10;
            this.ChckRTS.Text = "RTS Enable";
            this.ChckRTS.UseVisualStyleBackColor = true;
            this.ChckRTS.CheckedChanged += new System.EventHandler(this.ChckRTS_CheckedChanged);
            // 
            // ChckDTR
            // 
            this.ChckDTR.AutoSize = true;
            this.ChckDTR.Location = new System.Drawing.Point(12, 266);
            this.ChckDTR.Name = "ChckDTR";
            this.ChckDTR.Size = new System.Drawing.Size(140, 29);
            this.ChckDTR.TabIndex = 6;
            this.ChckDTR.Text = "DTR Enable";
            this.ChckDTR.UseVisualStyleBackColor = true;
            this.ChckDTR.CheckedChanged += new System.EventHandler(this.ChckDTR_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits:";
            // 
            // CmbParityBits
            // 
            this.CmbParityBits.FormattingEnabled = true;
            this.CmbParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CmbParityBits.Location = new System.Drawing.Point(122, 210);
            this.CmbParityBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbParityBits.Name = "CmbParityBits";
            this.CmbParityBits.Size = new System.Drawing.Size(158, 33);
            this.CmbParityBits.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits:";
            // 
            // CmbStopBits
            // 
            this.CmbStopBits.FormattingEnabled = true;
            this.CmbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CmbStopBits.Location = new System.Drawing.Point(122, 167);
            this.CmbStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbStopBits.Name = "CmbStopBits";
            this.CmbStopBits.Size = new System.Drawing.Size(158, 33);
            this.CmbStopBits.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Bits:";
            // 
            // CmbDataBits
            // 
            this.CmbDataBits.FormattingEnabled = true;
            this.CmbDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CmbDataBits.Location = new System.Drawing.Point(122, 124);
            this.CmbDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDataBits.Name = "CmbDataBits";
            this.CmbDataBits.Size = new System.Drawing.Size(158, 33);
            this.CmbDataBits.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // CmbBaudRate
            // 
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.CmbBaudRate.Location = new System.Drawing.Point(122, 81);
            this.CmbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(158, 33);
            this.CmbBaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com Port:";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0, 0, 6, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 37);
            this.progressBar1.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSend.Location = new System.Drawing.Point(411, 0);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(88, 30);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtDataOut
            // 
            this.TxtDataOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDataOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDataOut.Location = new System.Drawing.Point(0, 0);
            this.TxtDataOut.Multiline = true;
            this.TxtDataOut.Name = "TxtDataOut";
            this.TxtDataOut.Size = new System.Drawing.Size(411, 30);
            this.TxtDataOut.TabIndex = 5;
            this.TxtDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDataOut_KeyDown);
            this.TxtDataOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDataOut_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.TxtDataIn);
            this.groupBox4.Location = new System.Drawing.Point(301, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 314);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MONITOR";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtDataOut);
            this.panel3.Controls.Add(this.BtnSend);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 30);
            this.panel3.TabIndex = 9;
            // 
            // TxtDataIn
            // 
            this.TxtDataIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtDataIn.Location = new System.Drawing.Point(3, 62);
            this.TxtDataIn.Multiline = true;
            this.TxtDataIn.Name = "TxtDataIn";
            this.TxtDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDataIn.Size = new System.Drawing.Size(499, 249);
            this.TxtDataIn.TabIndex = 5;
            this.TxtDataIn.WordWrap = false;
            this.TxtDataIn.TextChanged += new System.EventHandler(this.TxtDataIn_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.LblDataOutLength);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(297, -11);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(246, 49);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // LblDataOutLength
            // 
            this.LblDataOutLength.AutoSize = true;
            this.LblDataOutLength.Location = new System.Drawing.Point(189, 18);
            this.LblDataOutLength.Name = "LblDataOutLength";
            this.LblDataOutLength.Size = new System.Drawing.Size(34, 25);
            this.LblDataOutLength.TabIndex = 1;
            this.LblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data OUT Length:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.LblDataInLength);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Location = new System.Drawing.Point(556, -11);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(246, 49);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            // 
            // LblDataInLength
            // 
            this.LblDataInLength.AutoSize = true;
            this.LblDataInLength.Location = new System.Drawing.Point(189, 19);
            this.LblDataInLength.Name = "LblDataInLength";
            this.LblDataInLength.Size = new System.Drawing.Size(34, 25);
            this.LblDataInLength.TabIndex = 1;
            this.LblDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data IN Length:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.comControlToolStripMenuItem,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.multiplePortToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 29);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTxToolStripMenuItem,
            this.saveToMySQLDatabaseToolStripMenuItem,
            this.toolStripSeparator2,
            this.eXİTToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToTxToolStripMenuItem
            // 
            this.saveToTxToolStripMenuItem.Checked = true;
            this.saveToTxToolStripMenuItem.CheckOnClick = true;
            this.saveToTxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToTxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwriteText,
            this.toolStripComboBox_writeLineOrWriteText});
            this.saveToTxToolStripMenuItem.Name = "saveToTxToolStripMenuItem";
            this.saveToTxToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.saveToTxToolStripMenuItem.Text = "Save to Txt File";
            // 
            // toolStripComboBox_appendOrOverwriteText
            // 
            this.toolStripComboBox_appendOrOverwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwriteText.Items.AddRange(new object[] {
            "Append Text",
            "Overwrite Text"});
            this.toolStripComboBox_appendOrOverwriteText.Name = "toolStripComboBox_appendOrOverwriteText";
            this.toolStripComboBox_appendOrOverwriteText.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox_appendOrOverwriteText.DropDownClosed += new System.EventHandler(this.toolStripComboBox_appendOrOverwriteText_DropDownClosed);
            // 
            // toolStripComboBox_writeLineOrWriteText
            // 
            this.toolStripComboBox_writeLineOrWriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_writeLineOrWriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_writeLineOrWriteText.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.toolStripComboBox_writeLineOrWriteText.Name = "toolStripComboBox_writeLineOrWriteText";
            this.toolStripComboBox_writeLineOrWriteText.Size = new System.Drawing.Size(121, 28);
            // 
            // saveToMySQLDatabaseToolStripMenuItem
            // 
            this.saveToMySQLDatabaseToolStripMenuItem.Checked = true;
            this.saveToMySQLDatabaseToolStripMenuItem.CheckOnClick = true;
            this.saveToMySQLDatabaseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToMySQLDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem});
            this.saveToMySQLDatabaseToolStripMenuItem.Name = "saveToMySQLDatabaseToolStripMenuItem";
            this.saveToMySQLDatabaseToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.saveToMySQLDatabaseToolStripMenuItem.Text = "Save To MySQL Database";
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.showDataToolStripMenuItem.Text = "Show Data";
            this.showDataToolStripMenuItem.Click += new System.EventHandler(this.showDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(281, 6);
            // 
            // eXİTToolStripMenuItem
            // 
            this.eXİTToolStripMenuItem.Name = "eXİTToolStripMenuItem";
            this.eXİTToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.eXİTToolStripMenuItem.Text = "Exit";
            this.eXİTToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // comControlToolStripMenuItem
            // 
            this.comControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.comControlToolStripMenuItem.Name = "comControlToolStripMenuItem";
            this.comControlToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.comControlToolStripMenuItem.Text = "COM Control";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAfterSendToolStripMenuItem,
            this.endLİneToolStripMenuItem,
            this.dataFormatToolStripMenuItem1});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            // 
            // clearAfterSendToolStripMenuItem
            // 
            this.clearAfterSendToolStripMenuItem.Checked = true;
            this.clearAfterSendToolStripMenuItem.CheckOnClick = true;
            this.clearAfterSendToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearAfterSendToolStripMenuItem.Name = "clearAfterSendToolStripMenuItem";
            this.clearAfterSendToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearAfterSendToolStripMenuItem.Text = "Clear After Send";
            // 
            // endLİneToolStripMenuItem
            // 
            this.endLİneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_TxEndLine});
            this.endLİneToolStripMenuItem.Name = "endLİneToolStripMenuItem";
            this.endLİneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.endLİneToolStripMenuItem.Text = "End Line";
            // 
            // toolStripComboBox_TxEndLine
            // 
            this.toolStripComboBox_TxEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_TxEndLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_TxEndLine.Items.AddRange(new object[] {
            "None",
            "Both (\\r\\n)",
            "New Line (\\n)",
            "Carriage Return (\\r)"});
            this.toolStripComboBox_TxEndLine.Name = "toolStripComboBox_TxEndLine";
            this.toolStripComboBox_TxEndLine.Size = new System.Drawing.Size(130, 28);
            this.toolStripComboBox_TxEndLine.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // dataFormatToolStripMenuItem1
            // 
            this.dataFormatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_TxDataFormat});
            this.dataFormatToolStripMenuItem1.Name = "dataFormatToolStripMenuItem1";
            this.dataFormatToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dataFormatToolStripMenuItem1.Text = "Data Format";
            // 
            // toolStripComboBox_TxDataFormat
            // 
            this.toolStripComboBox_TxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_TxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_TxDataFormat.Items.AddRange(new object[] {
            "Hex",
            "Decimal",
            "Binary",
            "Char"});
            this.toolStripComboBox_TxDataFormat.Name = "toolStripComboBox_TxDataFormat";
            this.toolStripComboBox_TxDataFormat.Size = new System.Drawing.Size(121, 28);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.showDataWithToolStripMenuItem,
            this.dataPositionToolStripMenuItem,
            this.dataFormatToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // showDataWithToolStripMenuItem
            // 
            this.showDataWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxShowDataWith});
            this.showDataWithToolStripMenuItem.Name = "showDataWithToolStripMenuItem";
            this.showDataWithToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showDataWithToolStripMenuItem.Text = "Show Data With";
            // 
            // toolStripComboBox_RxShowDataWith
            // 
            this.toolStripComboBox_RxShowDataWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxShowDataWith.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxShowDataWith.Items.AddRange(new object[] {
            "Always Update",
            "Add To Old Data"});
            this.toolStripComboBox_RxShowDataWith.Name = "toolStripComboBox_RxShowDataWith";
            this.toolStripComboBox_RxShowDataWith.Size = new System.Drawing.Size(121, 28);
            // 
            // dataPositionToolStripMenuItem
            // 
            this.dataPositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxDataPosition});
            this.dataPositionToolStripMenuItem.Name = "dataPositionToolStripMenuItem";
            this.dataPositionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPositionToolStripMenuItem.Text = "Data Position";
            // 
            // toolStripComboBox_RxDataPosition
            // 
            this.toolStripComboBox_RxDataPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxDataPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxDataPosition.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
            this.toolStripComboBox_RxDataPosition.Name = "toolStripComboBox_RxDataPosition";
            this.toolStripComboBox_RxDataPosition.Size = new System.Drawing.Size(121, 28);
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxDataFormat});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // toolStripComboBox_RxDataFormat
            // 
            this.toolStripComboBox_RxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxDataFormat.Items.AddRange(new object[] {
            "Hex",
            "Decimal",
            "Binary",
            "Char"});
            this.toolStripComboBox_RxDataFormat.Name = "toolStripComboBox_RxDataFormat";
            this.toolStripComboBox_RxDataFormat.Size = new System.Drawing.Size(121, 28);
            // 
            // multiplePortToolStripMenuItem
            // 
            this.multiplePortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.in1PortsToolStripMenuItem});
            this.multiplePortToolStripMenuItem.Name = "multiplePortToolStripMenuItem";
            this.multiplePortToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.multiplePortToolStripMenuItem.Text = "Multiple Port";
            // 
            // in1PortsToolStripMenuItem
            // 
            this.in1PortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.in1PortsToolStripMenuItem.Name = "in1PortsToolStripMenuItem";
            this.in1PortsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.in1PortsToolStripMenuItem.Text = "2 in 1 Ports";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.MaximumSize = new System.Drawing.Size(1389, 685);
            this.panel1.MinimumSize = new System.Drawing.Size(806, 365);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel1.Size = new System.Drawing.Size(807, 365);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 37);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(807, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(825, 439);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIY-My Serial Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbComPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbParityBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbDataBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox ChckRTS;
        private System.Windows.Forms.CheckBox ChckDTR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label LblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label LblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDataIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXİTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAfterSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLİneToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_TxEndLine;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxShowDataWith;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxDataPosition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem saveToTxToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwriteText;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_writeLineOrWriteText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToMySQLDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplePortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem in1PortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxDataFormat;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_TxDataFormat;
    }
}

