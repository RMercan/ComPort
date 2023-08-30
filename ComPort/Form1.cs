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
        int dataInLength;
        int[] dataInDec;

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

        #region RX Data Format
        private string RxDataFormat(int[] dataInput)
        {
            string strOut = "";

            if (toolStripComboBox_RxDataFormat.Text == "Hex")
            {
                foreach(int element in dataInput)
                {
                    strOut += Convert.ToString(element, 16) + "\t";
                }
            }else if (toolStripComboBox_RxDataFormat.Text == "Decimal")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element) + "\t";
                }
            }else if (toolStripComboBox_RxDataFormat.Text == "Binary")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 2) + "\t";
                }
            }else if (toolStripComboBox_RxDataFormat.Text == "Char")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToChar(element);
                }
            }

            return strOut;
        }

        #endregion

        #region TX Data Format
        private void TxDataFormat()
        {
            if (toolStripComboBox_TxDataFormat.Text == "Char")
            {
                //send the data in the textbox via serial port
                serialPort1.Write(TxtDataOut.Text);

                //calculate the length of the data sent and then show it
                int DataOutLength = TxtDataOut.TextLength;
                LblDataOutLength.Text = string.Format("{0:00}", DataOutLength);
            }
            else
            {
                //Declare local variable
                string dataOutBuffer;
                int countComma = 0;
                string[] dataPrepareToSend;
                byte[] dataToSend;

                try
                {
                    //Move the data package in the textbox into a variable
                    dataOutBuffer = TxtDataOut.Text;

                    //Count how much comma (,) punctuation in the data package
                    foreach(char c in dataOutBuffer) { if(c==',') { countComma++; } }

                    //Create one-dimensionel array (string data type) with the length based on the countComma
                    dataPrepareToSend = new string[countComma];

                    //Parsing the data in dataOutBuffer and save it into an array dataPrepareToSend based on comma punctuation
                    countComma = 0; //reset value to 0
                    foreach(char c in dataOutBuffer)
                    {
                        if (c != ',')
                        {
                            //Append the data to array of dataPrepareToSend
                            dataPrepareToSend[countComma] += c;
                        }
                        else
                        {
                            //If a comma finds in the package, then increase the countComma variable. countComma is using the determine the index of dataPrepareToSend array
                            countComma++;
                            //Stop foreach process if numbers of countComma equals to the size of dataPrepareToSend
                            if (countComma == dataPrepareToSend.GetLength(0)) { break; }
                        }
                    }

                    //Create one-dimensionel array (byte data type) with the length based on the size of dataPrepareToSend
                    dataToSend = new byte[dataPrepareToSend.Length];

                    if (toolStripComboBox_TxDataFormat.Text == "Hex")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array (dataToSend) 
                        for(int a=0; a<dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 16);
                            //Convert string to an 8-bit unsigned integer with the specified base number
                            //Value 16 mean Hexadecimal
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Binary")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array (dataToSend) 
                        for (int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 2);
                            //Convert string to an 8-bit unsigned integer with the specified base number
                            //Value 2 mean Binary
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array (dataToSend) 
                        for (int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 10);
                            //Convert string to an 8-bit unsigned integer with the specified base number
                            //Value 10 mean Decimal
                        }
                    }

                    //Send a specified number of bytes to the serial port
                    serialPort1.Write(dataToSend, 0, dataToSend.Length);

                    //Calculate the length of data sent and then show it
                    LblDataOutLength.Text = string.Format("{0:00}", dataToSend.Length);
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }

        private void TxSendData()
        {
            if (serialPort1.IsOpen)
            {
                //dataOut = TxtDataOut.Text;
                if (sendWith == "None")
                {
                    //serialPort1.Write(dataOut);
                    TxDataFormat();
                }
                else if (sendWith == @"Both (\r\n)")
                {
                    //serialPort1.Write(dataOut + "\r\n");
                    TxDataFormat();
                    serialPort1.Write("\r\n");
                }
                else if (sendWith == @"New Line (\n)")
                {
                    //serialPort1.Write(dataOut + "\n");
                    TxDataFormat();
                    serialPort1.Write("\n");
                }
                else if (sendWith == @"Carriage Return (\r)")
                {
                    //serialPort1.Write(dataOut + "\r");
                    TxDataFormat();
                    serialPort1.Write("\r");
                }
            }
            if (clearAfterSendToolStripMenuItem.Checked)
            {
                if (TxtDataOut.Text != "")
                {
                    TxtDataOut.Text = "";
                }
            }
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
            ChckDTR.Checked = false;
            serialPort1.DtrEnable = false;
            ChckRTS.Checked = false;
            serialPort1.RtsEnable = false;
            BtnSend.Enabled = true;
            sendWith = @"Both (\r\n)";
            toolStripComboBox_RxDataPosition.Text = "Bottom";

            toolStripComboBox_RxShowDataWith.Text = "Add to Old Data";   //başlangıç durumu için (initial condition)
            toolStripComboBox_TxEndLine.Text = @"Both (\r\n)";

            toolStripComboBox_appendOrOverwriteText.Text = "Append Text";
            toolStripComboBox_writeLineOrWriteText.Text = "WriteLine";

            pathFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            pathFile += @"\_My Source File\SerialData.txt";

            saveToTxToolStripMenuItem.Checked = false;
            saveToMySQLDatabaseToolStripMenuItem.Checked = false;

            toolStripComboBox_RxDataFormat.Text = "Char";   //default  value for rx data format
            toolStripComboBox_TxDataFormat.Text = "Char";

            this.toolStripComboBox_TxDataFormat.ComboBox.SelectionChangeCommitted += new System.EventHandler(this.toolStripComboBox_TxDataFormat_SelectionChangeCommitted);

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
            TxSendData();
        }

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //None
            //Both
            //New Line
            //Carriage Return

            if (toolStripComboBox_TxEndLine.Text == "None")
            {
                sendWith = "None";
            }
            else if (toolStripComboBox_TxEndLine.Text == @"Both (\r\n)")
            {
                sendWith = @"Both (\r\n)";
            }
            else if (toolStripComboBox_TxEndLine.Text == @"New Line (\n)")
            {
                sendWith = @"New Line (\n)";
            }
            else if (toolStripComboBox_TxEndLine.Text == @"Carriage Return (\r)")
            {
                sendWith = @"Carriage Return (\r)";
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
            TxSendData();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //dataIn = serialPort1.ReadExisting();

            List<int> dataBuffer = new List<int>();

            while(serialPort1.BytesToRead > 0)
            {
                try
                {
                    dataBuffer.Add(serialPort1.ReadByte());
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            dataInLength = dataBuffer.Count();
            dataInDec = new int[dataInLength];
            dataInDec = dataBuffer.ToArray();

            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            //int dataInLength = dataIn.Length; //serial data input length için, textbox dataIn context length için değil

            dataIn = RxDataFormat(dataInDec);

            LblDataInLength.Text = string.Format("{0:00}", dataInLength);

            if (toolStripComboBox_RxShowDataWith.Text == "Always Update")
            {
                TxtDataIn.Text = dataIn;
            }
            else if (toolStripComboBox_RxShowDataWith.Text == "Add to Old Data")
            {
                if (toolStripComboBox_RxDataPosition.Text == "Top")
                {
                    TxtDataIn.Text = TxtDataIn.Text.Insert(0, dataIn);
                }
                else if (toolStripComboBox_RxDataPosition.Text == "Bottom")
                {
                    TxtDataIn.Text += dataIn;
                }
            }

            SaveDataToTxtFile();
            SaveDataToMySQLDatabase();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
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

            TxtDataIn.Height = panel1.Height - 116;

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
            if (toolStripComboBox_RxDataPosition.Text == "Bottom")
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

        private void CmbComPort_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CmbComPort.Items.Clear();
            CmbComPort.Items.AddRange(ports);
        }

        private void TxtDataOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (toolStripComboBox_TxDataFormat.Text == "Hex")
            {
                //In hex format, the textbox only accepts the 0-9 key and A-F key 
                //The lower case will convert to the upper case, so both can enter on the textbox
                char uppercase = char.ToUpper(c);

                //if it is not the numbers key pressed, not the backspace key pressed, not the delete key pressed, not a comma key pressed, not the A-F key pressed
                if(!char.IsDigit(uppercase) && uppercase!=8 && uppercase!=46 && uppercase!= ',' && !(uppercase>=65 && uppercase <= 70))
                {
                    //cancel the keypress event
                    e.Handled = true;
                }

            }
            else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
            {
                //In decimal format, the textbox only accepts the numbers key, that is 0-9 

                //if it is not the numbers key pressed, not the backspace key pressed, not the delete key pressed, not a comma key pressed
                if (!char.IsDigit(c) && c != 8 && c != 46 && c != ',')
                {
                    //cancel the keypress event
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Binary")
            {
                //In binary format, the textbox only take 1 and 0 key

                //if it is not the one (1) key pressed, not the zero (0) key pressed, not the backspace key pressed, not the delete key pressed, not a comma key pressed
                if (c != 49 && c != 48 && c != 8 && c != 46 && c != ',')
                {
                    //cancel the keypress event
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Char")
            {
                //do nothing
            }
        }

        private void toolStripComboBox_TxDataFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Every time xelected different Tx data format, then delete all contents in the textbox data out 
            TxtDataOut.Clear();

            //Show a message every time I selected different Tx Data Format
            string message = "If you are not using char data format, append the comma (,) after each byte data. OtherWise, the byte data will ignore. \n" +
                "Example: \t255, -> One byte data \n" + "\t255, 128, 140, -> Two or more byte data \n" +
                "\t120, 144, 189 -> The 189 will ignore cause has no comma (,)";
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK);
        }

        #endregion
    }
}
