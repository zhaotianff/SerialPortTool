using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortLib
{
    public class CommonProtocol : ISerialPortProtocol
    {
        public string STX { get; set; }
        public string cmd { get; set; }
        public string split { get; set; }
        public List<string> data { get; set; }
        public string checksum { get; set; }
        public string ETX { get; set; }
    }
}
