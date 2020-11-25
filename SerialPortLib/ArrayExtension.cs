using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortLib
{
    public static class ArrayExtension
    {
        public static string ToLongString(this string[] list,string split)
        {
            if (list.Length == 0)
                return "";

            var data = "";
            foreach (var item in list)
            {
                data += item + split;
            }

            return data.Substring(0, data.Length - 1);
        }
    }
}
