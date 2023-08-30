
namespace ComPort
{
    partial class FrmMultiplePorts
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar_1stStatusBar = new System.Windows.Forms.ProgressBar();
            this.Btn1stClose = new System.Windows.Forms.Button();
            this.Btn1stOpen = new System.Windows.Forms.Button();
            this.Cmb1stEndLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb1stBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb1stComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn1stButtonSend = new System.Windows.Forms.Button();
            this.richTextBox_1stTextReceiver = new System.Windows.Forms.RichTextBox();
            this.Txt1stTextSend = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar_2ndStatusBar = new System.Windows.Forms.ProgressBar();
            this.Btn2ndClose = new System.Windows.Forms.Button();
            this.Btn2ndOpen = new System.Windows.Forms.Button();
            this.Cmb2ndEndLine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb2ndBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb2ndComPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn2ndButtonSend = new System.Windows.Forms.Button();
            this.richTextBox_2ndTextReceiver = new System.Windows.Forms.RichTextBox();
            this.Txt2ndTextSent = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(782, 603);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar_1stStatusBar);
            this.groupBox1.Controls.Add(this.Btn1stClose);
            this.groupBox1.Controls.Add(this.Btn1stOpen);
            this.groupBox1.Controls.Add(this.Cmb1stEndLine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cmb1stBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cmb1stComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn1stButtonSend);
            this.groupBox1.Controls.Add(this.richTextBox_1stTextReceiver);
            this.groupBox1.Controls.Add(this.Txt1stTextSend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(768, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1st Com Port";
            // 
            // progressBar_1stStatusBar
            // 
            this.progressBar_1stStatusBar.Location = new System.Drawing.Point(664, 248);
            this.progressBar_1stStatusBar.Name = "progressBar_1stStatusBar";
            this.progressBar_1stStatusBar.Size = new System.Drawing.Size(96, 31);
            this.progressBar_1stStatusBar.TabIndex = 11;
            // 
            // Btn1stClose
            // 
            this.Btn1stClose.Location = new System.Drawing.Point(588, 247);
            this.Btn1stClose.Name = "Btn1stClose";
            this.Btn1stClose.Size = new System.Drawing.Size(75, 33);
            this.Btn1stClose.TabIndex = 10;
            this.Btn1stClose.Text = "Close";
            this.Btn1stClose.UseVisualStyleBackColor = true;
            this.Btn1stClose.Click += new System.EventHandler(this.Btn1stClose_Click);
            // 
            // Btn1stOpen
            // 
            this.Btn1stOpen.Location = new System.Drawing.Point(513, 247);
            this.Btn1stOpen.Name = "Btn1stOpen";
            this.Btn1stOpen.Size = new System.Drawing.Size(75, 33);
            this.Btn1stOpen.TabIndex = 9;
            this.Btn1stOpen.Text = "Open";
            this.Btn1stOpen.UseVisualStyleBackColor = true;
            this.Btn1stOpen.Click += new System.EventHandler(this.Btn1stOpen_Click);
            // 
            // Cmb1stEndLine
            // 
            this.Cmb1stEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb1stEndLine.FormattingEnabled = true;
            this.Cmb1stEndLine.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.Cmb1stEndLine.Location = new System.Drawing.Point(400, 249);
            this.Cmb1stEndLine.Name = "Cmb1stEndLine";
            this.Cmb1stEndLine.Size = new System.Drawing.Size(100, 31);
            this.Cmb1stEndLine.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Line:";
            // 
            // Cmb1stBaudRate
            // 
            this.Cmb1stBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb1stBaudRate.FormattingEnabled = true;
            this.Cmb1stBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.Cmb1stBaudRate.Location = new System.Drawing.Point(249, 248);
            this.Cmb1stBaudRate.Name = "Cmb1stBaudRate";
            this.Cmb1stBaudRate.Size = new System.Drawing.Size(77, 31);
            this.Cmb1stBaudRate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate:";
            // 
            // Cmb1stComPort
            // 
            this.Cmb1stComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb1stComPort.FormattingEnabled = true;
            this.Cmb1stComPort.Location = new System.Drawing.Point(85, 247);
            this.Cmb1stComPort.Name = "Cmb1stComPort";
            this.Cmb1stComPort.Size = new System.Drawing.Size(77, 31);
            this.Cmb1stComPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Com Port:";
            // 
            // Btn1stButtonSend
            // 
            this.Btn1stButtonSend.Location = new System.Drawing.Point(674, 30);
            this.Btn1stButtonSend.Name = "Btn1stButtonSend";
            this.Btn1stButtonSend.Size = new System.Drawing.Size(86, 30);
            this.Btn1stButtonSend.TabIndex = 2;
            this.Btn1stButtonSend.Text = "Send";
            this.Btn1stButtonSend.UseVisualStyleBackColor = true;
            this.Btn1stButtonSend.Click += new System.EventHandler(this.Btn1stButtonSend_Click);
            // 
            // richTextBox_1stTextReceiver
            // 
            this.richTextBox_1stTextReceiver.Location = new System.Drawing.Point(16, 67);
            this.richTextBox_1stTextReceiver.Name = "richTextBox_1stTextReceiver";
            this.richTextBox_1stTextReceiver.Size = new System.Drawing.Size(752, 174);
            this.richTextBox_1stTextReceiver.TabIndex = 1;
            this.richTextBox_1stTextReceiver.Text = "";
            this.richTextBox_1stTextReceiver.TextChanged += new System.EventHandler(this.richTextBox_1stTextReceiver_TextChanged);
            // 
            // Txt1stTextSend
            // 
            this.Txt1stTextSend.Location = new System.Drawing.Point(8, 31);
            this.Txt1stTextSend.Name = "Txt1stTextSend";
            this.Txt1stTextSend.Size = new System.Drawing.Size(660, 30);
            this.Txt1stTextSend.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar_2ndStatusBar);
            this.groupBox2.Controls.Add(this.Btn2ndClose);
            this.groupBox2.Controls.Add(this.Btn2ndOpen);
            this.groupBox2.Controls.Add(this.Cmb2ndEndLine);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cmb2ndBaudRate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cmb2ndComPort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Btn2ndButtonSend);
            this.groupBox2.Controls.Add(this.richTextBox_2ndTextReceiver);
            this.groupBox2.Controls.Add(this.Txt2ndTextSent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(768, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2nd Com Port";
            // 
            // progressBar_2ndStatusBar
            // 
            this.progressBar_2ndStatusBar.Location = new System.Drawing.Point(664, 248);
            this.progressBar_2ndStatusBar.Name = "progressBar_2ndStatusBar";
            this.progressBar_2ndStatusBar.Size = new System.Drawing.Size(96, 31);
            this.progressBar_2ndStatusBar.TabIndex = 11;
            // 
            // Btn2ndClose
            // 
            this.Btn2ndClose.Location = new System.Drawing.Point(588, 247);
            this.Btn2ndClose.Name = "Btn2ndClose";
            this.Btn2ndClose.Size = new System.Drawing.Size(75, 33);
            this.Btn2ndClose.TabIndex = 10;
            this.Btn2ndClose.Text = "Close";
            this.Btn2ndClose.UseVisualStyleBackColor = true;
            this.Btn2ndClose.Click += new System.EventHandler(this.Btn2ndClose_Click);
            // 
            // Btn2ndOpen
            // 
            this.Btn2ndOpen.Location = new System.Drawing.Point(513, 247);
            this.Btn2ndOpen.Name = "Btn2ndOpen";
            this.Btn2ndOpen.Size = new System.Drawing.Size(75, 33);
            this.Btn2ndOpen.TabIndex = 9;
            this.Btn2ndOpen.Text = "Open";
            this.Btn2ndOpen.UseVisualStyleBackColor = true;
            this.Btn2ndOpen.Click += new System.EventHandler(this.Btn2ndOpen_Click);
            // 
            // Cmb2ndEndLine
            // 
            this.Cmb2ndEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb2ndEndLine.FormattingEnabled = true;
            this.Cmb2ndEndLine.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.Cmb2ndEndLine.Location = new System.Drawing.Point(400, 249);
            this.Cmb2ndEndLine.Name = "Cmb2ndEndLine";
            this.Cmb2ndEndLine.Size = new System.Drawing.Size(100, 31);
            this.Cmb2ndEndLine.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Line:";
            // 
            // Cmb2ndBaudRate
            // 
            this.Cmb2ndBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb2ndBaudRate.FormattingEnabled = true;
            this.Cmb2ndBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.Cmb2ndBaudRate.Location = new System.Drawing.Point(249, 248);
            this.Cmb2ndBaudRate.Name = "Cmb2ndBaudRate";
            this.Cmb2ndBaudRate.Size = new System.Drawing.Size(77, 31);
            this.Cmb2ndBaudRate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Baud Rate:";
            // 
            // Cmb2ndComPort
            // 
            this.Cmb2ndComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb2ndComPort.FormattingEnabled = true;
            this.Cmb2ndComPort.Location = new System.Drawing.Point(85, 247);
            this.Cmb2ndComPort.Name = "Cmb2ndComPort";
            this.Cmb2ndComPort.Size = new System.Drawing.Size(77, 31);
            this.Cmb2ndComPort.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Com Port:";
            // 
            // Btn2ndButtonSend
            // 
            this.Btn2ndButtonSend.Location = new System.Drawing.Point(674, 30);
            this.Btn2ndButtonSend.Name = "Btn2ndButtonSend";
            this.Btn2ndButtonSend.Size = new System.Drawing.Size(86, 30);
            this.Btn2ndButtonSend.TabIndex = 2;
            this.Btn2ndButtonSend.Text = "Send";
            this.Btn2ndButtonSend.UseVisualStyleBackColor = true;
            this.Btn2ndButtonSend.Click += new System.EventHandler(this.Btn2ndButtonSend_Click);
            // 
            // richTextBox_2ndTextReceiver
            // 
            this.richTextBox_2ndTextReceiver.Location = new System.Drawing.Point(8, 67);
            this.richTextBox_2ndTextReceiver.Name = "richTextBox_2ndTextReceiver";
            this.richTextBox_2ndTextReceiver.Size = new System.Drawing.Size(752, 174);
            this.richTextBox_2ndTextReceiver.TabIndex = 1;
            this.richTextBox_2ndTextReceiver.Text = "";
            this.richTextBox_2ndTextReceiver.TextChanged += new System.EventHandler(this.richTextBox_2ndTextReceiver_TextChanged);
            // 
            // Txt2ndTextSent
            // 
            this.Txt2ndTextSent.Location = new System.Drawing.Point(8, 31);
            this.Txt2ndTextSent.Name = "Txt2ndTextSent";
            this.Txt2ndTextSent.Size = new System.Drawing.Size(660, 30);
            this.Txt2ndTextSent.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // FrmMultiplePorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMultiplePorts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Ports | 2 IN 1 PORTS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMultiplePorts_FormClosing);
            this.Load += new System.EventHandler(this.FrmMultiplePorts_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar_1stStatusBar;
        private System.Windows.Forms.Button Btn1stClose;
        private System.Windows.Forms.Button Btn1stOpen;
        private System.Windows.Forms.ComboBox Cmb1stEndLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb1stBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb1stComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn1stButtonSend;
        private System.Windows.Forms.RichTextBox richTextBox_1stTextReceiver;
        private System.Windows.Forms.TextBox Txt1stTextSend;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar_2ndStatusBar;
        private System.Windows.Forms.Button Btn2ndClose;
        private System.Windows.Forms.Button Btn2ndOpen;
        private System.Windows.Forms.ComboBox Cmb2ndEndLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb2ndBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb2ndComPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn2ndButtonSend;
        private System.Windows.Forms.RichTextBox richTextBox_2ndTextReceiver;
        private System.Windows.Forms.TextBox Txt2ndTextSent;
        private System.IO.Ports.SerialPort serialPort2;
    }
}