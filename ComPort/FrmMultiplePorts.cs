using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComPort
{

    public partial class FrmMultiplePorts : Form
    {
        Form1 objForm1;
        string _1stDataIn;
        string _2ndDataIn;
        public FrmMultiplePorts(Form1 obj)
        {
            InitializeComponent();
            objForm1= obj;
        }

        private void FrmMultiplePorts_Load(object sender, EventArgs e)
        {
            Btn1stOpen.Enabled = true;
            Btn1stClose.Enabled = false;
            Btn1stButtonSend.Enabled = false;
            Cmb1stBaudRate.Text = "9600"; //Default Value
            Cmb1stEndLine.Text = "WriteLine"; //Default Value
            string[] portList = SerialPort.GetPortNames();
            Cmb1stComPort.Items.AddRange(portList);

            Btn2ndOpen.Enabled = true;
            Btn2ndClose.Enabled = false;
            Btn2ndButtonSend.Enabled = false;
            Cmb2ndBaudRate.Text = "9600";
            Cmb2ndEndLine.Text = "WriteLine";
            Cmb2ndComPort.Items.AddRange(portList);
        }
        private void FrmMultiplePorts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    Btn1stOpen.Enabled = true;
                    Btn1stClose.Enabled = false;
                    Btn1stButtonSend.Enabled = false;
                    progressBar_1stStatusBar.Value = 0;
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
            if (serialPort2.IsOpen)
            {
                try
                {
                    serialPort2.Close();

                    Btn2ndOpen.Enabled = true;
                    Btn2ndClose.Enabled = false;
                    Btn2ndButtonSend.Enabled = false;
                    progressBar_2ndStatusBar.Value = 0;
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
            objForm1.Show();
        }


        #region 1st COM PORT
        private void Btn1stOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = Cmb1stComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(Cmb1stBaudRate.Text);
                serialPort1.Open();

                Btn1stOpen.Enabled = false;
                Btn1stClose.Enabled = true;
                Btn1stButtonSend.Enabled = true;
                progressBar_1stStatusBar.Value = 100;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
        private void Btn1stClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    Btn1stOpen.Enabled = true;
                    Btn1stClose.Enabled = false;
                    Btn1stButtonSend.Enabled = false;
                    progressBar_1stStatusBar.Value = 0;
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }
        private void Btn1stButtonSend_Click(object sender, EventArgs e)
        {
            if (Cmb1stEndLine.Text == "WriteLine")
            {
                serialPort1.WriteLine(Txt1stTextSend.Text);
            }else if (Cmb1stEndLine.Text == "Write")
            {
                serialPort1.Write(Txt1stTextSend.Text);
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _1stDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(_1stShowData));
        }
        private void _1stShowData(object sender, EventArgs e)
        {
            richTextBox_1stTextReceiver.Text += _1stDataIn;
        }
        private void richTextBox_1stTextReceiver_TextChanged(object sender, EventArgs e)
        {
            richTextBox_1stTextReceiver.SelectionStart = richTextBox_1stTextReceiver.Text.Length;
            richTextBox_1stTextReceiver.ScrollToCaret();
        }
        #endregion

        #region 2nd COM PORT
        private void Btn2ndOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.PortName = Cmb2ndComPort.Text;
                serialPort2.BaudRate = Convert.ToInt32(Cmb2ndBaudRate.Text);
                serialPort2.Open();

                Btn2ndOpen.Enabled = false;
                Btn2ndClose.Enabled = true;
                Btn2ndButtonSend.Enabled = true;
                progressBar_2ndStatusBar.Value = 100;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
        private void Btn2ndClose_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                try
                {
                    serialPort2.Close();

                    Btn2ndOpen.Enabled = true;
                    Btn2ndClose.Enabled = false;
                    Btn2ndButtonSend.Enabled = false;
                    progressBar_2ndStatusBar.Value = 0;
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }
        private void Btn2ndButtonSend_Click(object sender, EventArgs e)
        {
            if (Cmb2ndEndLine.Text == "WriteLine")
            {
                serialPort2.WriteLine(Txt2ndTextSent.Text);
            }
            else if (Cmb2ndEndLine.Text == "Write")
            {
                serialPort2.Write(Txt2ndTextSent.Text);
            }
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _2ndDataIn = serialPort2.ReadExisting();
            this.Invoke(new EventHandler(_2ndShowData));
        }
        private void _2ndShowData(object sender, EventArgs e)
        {
            richTextBox_2ndTextReceiver.Text += _2ndDataIn;
        }
        private void richTextBox_2ndTextReceiver_TextChanged(object sender, EventArgs e)
        {

            richTextBox_2ndTextReceiver.SelectionStart = richTextBox_2ndTextReceiver.Text.Length;
            richTextBox_2ndTextReceiver.ScrollToCaret();
        }
        #endregion
    }
}
