namespace DevIncubatorCore
{
    public static class Extractor
    {
        public static double GetDouble(string data)
        {
            return double.TryParse(data, out var outData) ? outData : default;
        }

        public static int GetInt32(string data)
        {
            return int.TryParse(data, out var outData) ? outData : default;
        }

        public static byte GetByte(string data)
        {
            return byte.TryParse(data, out var outData) ? outData : default;
        }

        public static bool GetBool(string data)
        {
            return bool.TryParse(data, out var outData) ? outData : default;
        }

        public static char GetChar(string data)
        {
            return char.TryParse(data, out var outData) ? outData : default;
        }
    }
}