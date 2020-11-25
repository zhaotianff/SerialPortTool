using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortLib;

namespace 串口助手
{
    public partial class Form1 : Form
    {
        private SerialPortHelper serialPort = new SerialPortHelper();

        private string data = "";
        private string receiveMessage = "";

        public Form1()
        {
            InitializeComponent();

            InitData();
        }

        private void InitData()
        {           
            var baudList = LoadBaudList();
            cbxBaudRateList.Items.AddRange(baudList);
            cbxBaudRateList.SelectedIndex = 7;

            var dataBitList = LoadDataBitList();
            cbxDataBitList.Items.AddRange(dataBitList);
            cbxDataBitList.SelectedIndex = 3;

            var stopBitList = LoadStopBitList();
            cbxStopBitList.Items.AddRange(stopBitList);
            cbxStopBitList.SelectedIndex = 1;

            var checkBitList = LoadCheckBitList();
            cbxCheckBitList.Items.AddRange(checkBitList);
            cbxCheckBitList.SelectedIndex = 0;

            var portList = LoadPortList();
            cbxSerialPortList.Items.AddRange(portList);
            cbxSerialPortList.SelectedIndex = 0;

            EnableSerialProtConfigUI(false);
        }

        private string[] LoadPortList()
        {
            return SerialPort.GetPortNames();
        }

        private string[] LoadBaudList()
        {
            return new string[] { "110" ,"300","1200","2400","4800","9600","19200","38400","57600","115200","230400","460800","921600"};
        }

        private string[] LoadDataBitList()
        {
            return new string[] { "5","6","7","8"};          
        }

        private string[] LoadStopBitList()
        {
            return new string[] { "None", "One", "Two", "OnePointFive" };
        }

        private string[] LoadCheckBitList()
        {
            return new string[] { "None", "Odd", "Even" , "Mark", "Space" };
        }

        private void ShowStatusText(string str)
        {
            this.BeginInvoke(new Action(()=> { toolStripStatusLabel1.Text = str; }));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(btnOpen.Text.Trim() == "打开")
            {
                var portName = cbxSerialPortList.Text;
                var baudRate = cbxBaudRateList.Text;
                var dataBit = cbxDataBitList.Text;
                var stopBit = cbxStopBitList.SelectedIndex;
                var parity = cbxCheckBitList.SelectedIndex;

                if (serialPort.OpenSerialPort(portName, baudRate, dataBit, stopBit, parity, ReceiveData) == true)
                {
                    ShowStatusText($"{portName}打开成功");
                    EnableSerialProtConfigUI(true);
                    EnableConfigUI(false);
                    EnablePanel(0);
                    btnOpen.Text = "关闭";
                }
                else
                {
                    ShowStatusText($"{portName}打开失败");
                    EnableSerialProtConfigUI(false);
                }
            }
            else
            {
                if(serialPort.CloseSerialPort() == true)
                {
                    EnableConfigUI(true);
                    btnOpen.Text = "打开";
                    ShowStatusText($"{this.cbxSerialPortList.Text.Trim()}关闭成功");
                }
                else
                {
                    ShowStatusText($"{this.cbxSerialPortList.Text.Trim()}关闭失败");
                }
            }
        }

        private void EnableSerialProtConfigUI(bool isEnable)
        {
            this.groupBox2.Enabled = isEnable;
            this.groupBox3.Enabled = isEnable;
            this.groupBox4.Enabled = isEnable;
            this.groupBox5.Enabled = isEnable;
        }

        private void EnableConfigUI(bool isEnable)
        {
          
            this.groupBox3.Enabled = isEnable;
            this.cbxBaudRateList.Enabled = isEnable;
            this.cbxCheckBitList.Enabled = isEnable;
            this.cbxDataBitList.Enabled = isEnable;
            this.cbxStopBitList.Enabled = isEnable;
            this.cbxSerialPortList.Enabled = isEnable;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(this.radioSendData.Checked)
            {
                var data = this.rtboxSendData.Text.Trim();
                var isHex = radioSendHEX.Checked ? true : false;
                var result = false;

                if (radioSendData.Checked)
                {
                    if (string.IsNullOrEmpty(this.rtboxSendData.Text.Trim()))
                    {
                        ShowStatusText("请输入要发送的数据");
                        return;
                    }

                    if (radioSendASCII.Checked)
                        result = serialPort.SendNormalString(data);
                    else
                        result = serialPort.SendHexString(data);
                }

                ShowStatusText($"{DateTime.Now.ToString()} 发送{(result == true ? "成功":"失败")} ");
            }
            else
            {
                if(!System.IO.File.Exists(this.tboxFile.Text.Trim()))
                {
                    ShowStatusText("文件不存在");
                    return;
                }

                var result = serialPort.SendFile(this.tboxFile.Text.Trim());
            }
        }


        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "浏览文件";

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                this.tboxFile.Text = openDialog.FileName;
            }
        }

        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            
        }
 

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort.CloseSerialPort();
            }
            catch
            {

            }
        }

        private void ClearReceiveData()
        {
            this.rtboxReceive.Clear();
        }

        private void btnClearReceive_Click(object sender, EventArgs e)
        {
            ClearReceiveData();
        }


        private void radioSendData_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radioSendData.Checked)
            {
                EnablePanel(0);
            }
        }

        private void EnablePanel(int index)
        {
            bool isPanel1Enable = false;
            bool isPanel3Enable = false;

            switch(index)
            {
                case 0:
                    isPanel1Enable = true;
                    break;
                case 2:
                    isPanel3Enable = true;
                    break;
            }

            this.panel1.Enabled = isPanel1Enable;
            this.panel3.Enabled = isPanel3Enable;
        }

        private void radioSendFile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSendFile.Checked)
            {
                EnablePanel(2);
            }
        }
    }
}
