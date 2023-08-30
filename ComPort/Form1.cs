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
using System.IO;
using MySql.Data.MySqlClient;

namespace ComPort
{
    public partial class Form1 : Form

    {

        string dataOut;
        string sendWith;
        string dataIn;

        StreamWriter objStreamWriter;
        //string pathFile= @"C:\Users\RM\source\repos\ComPort\ComPort\_My Source File\SerialData.txt";
        string pathFile;

        bool state_AppendText = true;

        MySqlConnection myConnection;
        MySqlCommand myCommand; 

        #region My Own Method
        private void SaveDataToTxtFile()
        {
            if (saveToTxToolStripMenuItem.Checked)
            {
                try
                {
                    objStreamWriter = new StreamWriter(pathFile, state_AppendText);
                    if (toolStripComboBox_writeLineOrWriteText.Text == "WriteLine")
                    {
                        objStreamWriter.WriteLine(dataIn);
                    }
                    else if (toolStripComboBox_writeLineOrWriteText.Text == "Write") ;
                    {
                        objStreamWriter.Write(dataIn + " ");
                    }
                    objStreamWriter.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void SaveDataToMySQLDatabase()
        {
            if (saveToMySQLDatabaseToolStripMenuItem.Checked)
            {
                try
                {
                    myConnection = new MySqlConnection("server=localHost; username=root; password=123456; port=3306; database=comportdb");
                    myConnection.Open();

                    myCommand = new MySqlCommand(string.Format("INSERT INTO ´table01` VALUES (´{0}`)", dataIn), myConnection);
                    myCommand.ExecuteNonQuery();

                    myConnection.Close();

                    RefreshDataGridViewForm2();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }

        #region Custom EventHandler
        public delegate void UpdateDelegate(object sender, UpdateDataEventArgs args);

        public event UpdateDelegate UpdateDataEventHandler;

        public class UpdateDataEventArgs : EventArgs
        {

        }
        protected void RefreshDataGridViewForm2()
        {
            UpdateDataEventArgs args = new UpdateDataEventArgs();
            UpdateDataEventHandler.Invoke(this, args);
        }
        #endregion
        #endregion

        #region GUI Method
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CmbComPort.Items.AddRange(ports);

            ChckDTR.Checked = false;
            serialPort1.DtrEnable = false;
            ChckRTS.Checked = false;
            serialPort1.RtsEnable = false;
            BtnSend.Enabled = true;
            sendWith = "Both";
            toolStripComboBox3.Text = "Top";

            toolStripComboBox1.Text = "Add to Old Data";   //başlangıç durumu için (initial condition)
            toolStripComboBox2.Text = "Both";

            toolStripComboBox_appendOrOverwriteText.Text = "Append Text";
            toolStripComboBox_writeLineOrWriteText.Text = "WriteLine";

            pathFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            pathFile += @"\_My Source File\SerialData.txt";

            saveToTxToolStripMenuItem.Checked = false;
            saveToMySQLDatabaseToolStripMenuItem.Checked = false;

            //Console.WriteLine("------ Below is the result -------");
            //Console.WriteLine(pathFile);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CmbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(CmbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(CmbDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CmbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CmbParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = TxtDataOut.Text;
                if (sendWith == "None")
                {
                    serialPort1.Write(dataOut);
                }
                else if (sendWith == "Both")
                {
                    serialPort1.Write(dataOut + "\r\n");
                }
                else if (sendWith == "New Line")
                {
                    serialPort1.Write(dataOut + "\n");
                }
                else if (sendWith == "Carriage Return")
                {
                    serialPort1.Write(dataOut + "\r");
                }
            }
        }
        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //None
            //Both
            //New Line
            //Carriage Return

            if (toolStripComboBox2.Text == "None")
            {
                sendWith = "None";
            }
            else if (toolStripComboBox2.Text == "Both")
            {
                sendWith = "Both";
            }
            else if (toolStripComboBox2.Text == "New Line")
            {
                sendWith = "New Line";
            }
            else if (toolStripComboBox2.Text == "Carriage Return")
            {
                sendWith = "Carriage Return";
            }
        }


        private void ChckDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckDTR.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void ChckRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckRTS.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                serialPort1.RtsEnable = false;
        }

        private void TxtDataOut_TextChanged(object sender, EventArgs e)
        {
            int DataOutLength = TxtDataOut.TextLength;
            LblDataOutLength.Text = string.Format("{0:00}", DataOutLength);
        }


        private void TxtDataOut_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //enter a basıldığında

        private void doSomething()
        {
            if (serialPort1.IsOpen)
            {
                dataOut = TxtDataOut.Text;
                if (sendWith == "None")
                {
                    serialPort1.Write(dataOut);
                }
                else if (sendWith == "Both")
                {
                    serialPort1.Write(dataOut + "\r\n");
                }
                else if (sendWith == "New Line")
                {
                    serialPort1.Write(dataOut + "\n");
                }
                else if (sendWith == "Carriage Return")
                {
                    serialPort1.Write(dataOut + "\r");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            int dataInLength = dataIn.Length; //serial data input length için, textbox dataIn context length için değil
            LblDataInLength.Text = string.Format("{0:00}", dataInLength);

            if (toolStripComboBox1.Text == "Always Update")
            {
                TxtDataIn.Text = dataIn;
            }
            else if (toolStripComboBox1.Text == "Add to Old Data")
            {
                if (toolStripComboBox3.Text == "Top")
                {
                    TxtDataIn.Text = TxtDataIn.Text.Insert(0, dataIn);
                }
                else if (toolStripComboBox3.Text == "Bottom")
                {
                    TxtDataIn.Text += dataIn;
                }
            }

            SaveDataToTxtFile();
            SaveDataToMySQLDatabase();
        }


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtDataOut.Text != "")
            {
                TxtDataOut.Text = "";
            }
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (TxtDataIn.Text != "")
            {
                TxtDataIn.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Rabia Mercan", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox4.Width = panel1.Width - 302;
            groupBox4.Height = panel1.Height - 51;

            TxtDataIn.Height = panel1.Height - 124;

        }

        private void toolStripComboBox_appendOrOverwriteText_DropDownClosed(object sender, EventArgs e)
        {
            if (toolStripComboBox_appendOrOverwriteText.Text == "Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMultiplePorts ObjFrmMultiple = new FrmMultiplePorts(this);
            ObjFrmMultiple.Show();
            this.Hide();
        }
        private void TxtDataIn_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox3.Text == "Bottom")
            {
                TxtDataIn.SelectionStart = TxtDataIn.Text.Length;
                TxtDataIn.ScrollToCaret();
            }
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2(this);
            objForm2.Show();
        }
        #endregion

    }
}
