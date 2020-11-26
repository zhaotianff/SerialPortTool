using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortLib
{
    /// <summary>
    /// 一种串口通信格式
    /// </summary>
    public interface ISerialPortProtocol
    {
        /// <summary>
        /// 开始
        /// </summary>
        string STX { get; set; }

        /// <summary>
        /// 命令号
        /// </summary>
        string cmd { get; set; }

        /// <summary>
        /// 分隔符
        /// </summary>
        string split { get; set; }

        /// <summary>
        /// 数据段，用 split 分隔
        /// </summary>
        List<string> data { get; set; }

        /// <summary>
        /// 检验
        /// </summary>
        string checksum { get; set; }

        /// <summary>
        /// 结束
        /// </summary>
        string ETX { get; set; }
    }
}
