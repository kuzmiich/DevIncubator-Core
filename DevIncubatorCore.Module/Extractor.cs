using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Module
{
    public static class Extractor
    {
        public static double GetDouble(string data)
        {
            if (double.TryParse(data, out var age))
            {
                return age;
            }
            return default;
        }

        public static int GetInt32(string data)
        {
            if (int.TryParse(data, out var age))
            {
                return age;
            }
            return default;
        }

        public static byte GetByte(string data)
        {
            if (byte.TryParse(data, out var age))
            {
                return age;
            }
            return default;
        }

        public static char GetChar(string data)
        {
            if (char.TryParse(data, out var age))
            {
                return age;
            }
            return default;
        }
    }
}
