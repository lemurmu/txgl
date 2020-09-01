using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class ByteExtension
    {
        
		private static string[] _byteMap;
		private static int[] _toByteMap;

        static ByteExtension()
		{
			_byteMap = new string[256];
			for (int i = 0; i < 256; i++)
				_byteMap[i] = i.ToString("x2");

			_toByteMap = new int[(int) 'g'];
			for (int i = 0; i < _toByteMap.Length; i++)
				_toByteMap[i] = -1;

			for (char c = '0'; c <= '9'; c++)
			{
				_toByteMap[c] = (byte)(c - '0');
			}
			for (char c = 'a'; c <= 'f'; c++)
			{
				_toByteMap[c] = (byte) (10 + c - 'a');
				var c2 = char.ToUpper(c);
				_toByteMap[c2] = (byte)(10 + c2 - 'A');
			}
		}

        public static string ToHex(this byte source)
        {
            return source.ToString("X2");
        }

        public static string ToBase64(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static byte[] FromBase64(string base64)
        {
            return Convert.FromBase64String(base64);
        }

        public static string ToHex(this byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return "";

            var result = new char[bytes.Length * 2];
            int resultPos = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                var encodedByte = _byteMap[bytes[i]];
                result[resultPos] = encodedByte[0];
                result[resultPos + 1] = encodedByte[1];
                resultPos += 2;
            }
            return new string(result);
        }

        public static byte[] FromHex(string hexEncoded)
        {
            if (string.IsNullOrWhiteSpace(hexEncoded))
                return null;

            hexEncoded = hexEncoded.Trim();

            byte[] result = new byte[hexEncoded.Length / 2];

            int bpos = 0;
            for (int i = 0; i < hexEncoded.Length; i += 2)
            {
                var hc = hexEncoded[i];
                if (hc >= _toByteMap.Length)
                    return null;
                var hb = _toByteMap[(int)hc];
                if (hb == -1)
                    return null;

                int lb = 0;
                if (i + 1 < hexEncoded.Length)
                {
                    var lc = hexEncoded[i + 1];
                    lb = _toByteMap[(int)lc];
                }

                result[bpos++] = (byte)((hb << 4) + lb);
            }

            return result;
        }

        public static byte[] ToUTF8(string str)
        {
            if (str == null)
                return null;
            if (str.Length == 0)
                return new byte[0];

            return UTF8Encoding.UTF8.GetBytes(str);
        }

        public static string FromUTF8(this byte[] bytes)
        {
            if (bytes == null)
                return null;
            if (bytes.Length == 0)
                return "";
            return UTF8Encoding.UTF8.GetString(bytes);
        }

        public static bool IsEqual(this byte[] bytes, byte[] bytes2)
        {
            if (bytes == null || bytes.Length == 0)
            {
                if (bytes2 == null || bytes2.Length == 0)
                    return true;
                return false;
            }
            else if (bytes2 == null || bytes2.Length == 0)
                return false;

            if (bytes.Length != bytes2.Length)
                return false;

            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] != bytes2[i])
                    return false;
            }
            return true;
        }
    }
}
