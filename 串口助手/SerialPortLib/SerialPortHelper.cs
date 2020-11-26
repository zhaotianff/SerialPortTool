using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Text;


namespace SerialPortLib
{
    public class SerialPortHelper
    {
        private SerialPort sp = new SerialPort();
        string globalData = "";

        public bool OpenSerialPort(string portName, string strBaudRate, string strDataBit, int stopBitIndex, int parityIndex, SerialDataReceivedEventHandler handler = null)
        {
            try
            {
                if (sp.IsOpen)
                    sp.Close();

                sp.PortName = portName;
                sp.BaudRate = Convert.ToInt32(strBaudRate);
                sp.DataBits = Convert.ToInt32(strDataBit);
                sp.StopBits = (StopBits)stopBitIndex;
                sp.Parity = (Parity)parityIndex;
                sp.RtsEnable = true;
                sp.ReadTimeout = 500;

                sp.Open();

                if (sp.IsOpen)
                {
                    if (handler != null)
                    {
                        sp.DataReceived += handler;
                    }

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"OpenSerialPort->串口{portName}打开失败-{ex.Message}");
                return false;
            }
        }

        public bool CloseSerialPort()
        {
            try
            {
                if (sp.IsOpen == true)
                {
                    sp.Close();
                }

                return true;
            }
            catch
            {
                Trace.WriteLine($"CloseSerialPort->串口{sp.PortName}关闭失败");
                return false;
            }
        }

        public bool SendFile(string filePath, Encoding encoding = null)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath, Encoding.Default))
                {
                    var str = sr.ReadToEnd();

                    if (encoding == null)
                        encoding = Encoding.Default;

                    var buffer = encoding.GetBytes(str);
                    sp.Write(buffer, 0, buffer.Length);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine($"SendFile->发送文件失败,{ex.Message}");
                return false;
            }
        }

        public bool SendNormalString(string data)
        {
            try
            {
                sp.Encoding = Encoding.ASCII;
                sp.Write(data);
                return true;
            }
            catch(Exception ex)
            {
                Trace.WriteLine($"发送普通串口数据{data}失败,{ex.Message}");
                return false;
            }
        }

        public bool SendHexString(string data)
        {           
            data = GetASCIIString(data);
            return SendHexASCIIString(data);
        }

        private bool SendHexASCIIString(string data)
        {
            try
            {
                var buffer = ASCIIStringToHexByteArray(data);
                sp.Write(buffer, 0, buffer.Length);
                return true;
            }
            catch
            {
                Trace.WriteLine($"发送十六进制串口数据{data}失败");
                return false;
            }
        }

        public bool SendProtocolData(ISerialPortProtocol protocol, params string[] datas)
        {
            try
            {
                var sendData = GetProtocolData(protocol.cmd, protocol.STX, protocol.split, protocol.ETX, protocol.checksum, datas);
                sp.Write(sendData,0,sendData.Length);
                return true;
            }
            catch(Exception ex)
            {
                Trace.WriteLine($"SendCombinedCommand->发送串口数据失败,{ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// ASCII字符转换成十六进制字节数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private byte[] ASCIIStringToHexByteArray(string str)
        {
            try
            {
                str = str.Replace(" ", "");

                byte[] buffer = new byte[str.Length / 2];

                for (int i = 0; i < str.Length; i += 2)
                {
                    buffer[i / 2] = Convert.ToByte(str.Substring(i, 2), 16);
                }

                return buffer;
            }
            catch
            {
                return new byte[] { };
            }
        }

        private string HexByteArrayToString(byte[] data)
        {
            try
            {
                StringBuilder sb = new StringBuilder(data.Length * 3);
                foreach (byte b in data)
                    sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
                return sb.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"转换串口接收到的数据失败,{ex.Message}");
                return "";
            }
        }

        public byte[] GetProtocolData(string cmd, string STX, string split, string ETX, string checksum,params string[] datas)
        {
            var data = $"{STX}{cmd}{split}{datas.ToLongString(split)}{split}{checksum}{ETX}";
            data = GetASCIIString(data);
            return ASCIIStringToHexByteArray(data);
        }

        public ISerialPortProtocol ResolveCommand(string str)
        {
            //<STX><cmd><,><Data><,><checksum><ETX>
            var STX = "";
            var cmd = "";
            var data = new List<string>();
            var split = "";
            var checksum = "";
            var ETX = "";

            try
            {
                STX = str.Substring(0, 2);
                cmd = HexStringToChar(str.Substring(2, 4));
                split = str.Substring(6, 2);


                //暂时16进制 ASCII
                //除去命令 分隔符 校验 和 终止
                //如果数据段有多个，可以再进行截取

                //STX 2 cmd 4 split 2
                var leftLength = 8;
                //split 2 checksum 2 end 2
                var rightLength = 6;
                var exceptDataLength = leftLength + rightLength;

                if (str.Length - exceptDataLength > 0)
                {
                    var rawDataStr = str.Substring(8, str.Length - exceptDataLength);

                    if (rawDataStr.Length % 2 != 0)
                    {
                        Trace.WriteLine("ResolveCommand->解析串口数据段错误，数据段长度不为偶数");
                    }
                    else
                    {
                        rawDataStr = rawDataStr.Replace(split, ";");
                        var rawDataStrArray = rawDataStr.Split(';');

                        foreach (var item in rawDataStrArray)
                        {
                            data.Add(HexStringToChar(item));
                        }
                    }
                }

                checksum = str.Substring(str.Length - 4, 2);
                ETX = str.Substring(str.Length - 2, 2);
            }
            catch
            {
                Trace.WriteLine("ResolveCommand->解析串口消息失败");
            }

            return new CommonProtocol() { cmd = cmd, checksum = checksum, data = data, ETX = ETX, split = split, STX = STX };
        }

        /// <summary>
        /// 转换成ASCII字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        private string GetASCIIString(string str, string format = "X2")
        {
            var asciiStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                var asciiCode = (int)str[i];
                asciiStr += asciiCode.ToString(format);
            }

            return asciiStr;
        }

        private string HexStringToChar(string data)
        {
            var value = "";
            //这里暂时没找到更好的办法
            for (int i = 0; i < data.Length; i += 2)
            {
                var decNum = Convert.ToInt32(data.Substring(i, 2), 16);
                var numStr = ((char)decNum).ToString();
                value += numStr;
            }

            return value;
        }

        public ISerialPortProtocol GetReceiveProtocolData()
        {
            var buffer = new byte[sp.BytesToRead];
            sp.Read(buffer, 0, sp.BytesToRead);
            var data = "";
            data = HexByteArrayToString(buffer);
            return ResolveCommand(data);
        }

        /// <summary>
        /// 接收原始数据
        /// </summary>
        /// <returns></returns>
        public string GetRawReceiveData()
        {
            try
            {
                var buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, sp.BytesToRead);
                var data = "";
                if (buffer.Length > 0)
                    data = Encoding.ASCII.GetString(buffer);
                return data;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("接收串口消息错误," + ex.Message);
                return "";
            }
        }

        /// <summary>
        /// 接收十六进制数据
        /// </summary>
        /// <returns></returns>
        public string GetHexReceiveData()
        {
            try
            {
                var buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, sp.BytesToRead);
                var data = "";
                if (buffer.Length > 0)
                    data = HexByteArrayToString(buffer);
                return data;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("接收串口消息错误," + ex.Message);
                return "";
            }
        }
    }
}
