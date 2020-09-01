using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Globalization;

namespace Library.Basic
{
    public class ToolSecurity
    {
        public static string EncodeBase64(string @this)
        {
            return Convert.ToBase64String(Activator.CreateInstance<ASCIIEncoding>().GetBytes(@this));
        }

        public static string DecodeBase64(string @this)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(@this));
        }

        public static string EncryptRSA(string @this, string key)
        {
            var cspp = new CspParameters { KeyContainerName = key };
            var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
            byte[] bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(@this), true);

            return BitConverter.ToString(bytes);
        }

        public static string DecryptRSA(string @this, string key)
        {
            var cspp = new CspParameters { KeyContainerName = key };
            var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
            string[] decryptArray = @this.Split(new[] { "-" }, StringSplitOptions.None);
            byte[] decryptByteArray = Array.ConvertAll(decryptArray, (s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber))));
            byte[] bytes = rsa.Decrypt(decryptByteArray, true);

            return Encoding.UTF8.GetString(bytes);
        }
    }
}
