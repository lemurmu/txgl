using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace BizUtils.Data
{
    public static class ShortGuid
    {
        // I choose the base 36 because it generates little bit longer than 62.  
        // base36 vs. base62 vs. guid  
        // 25-26 vs. 22-23 vs. 36  
        private static readonly char[] BASE36 = {  
                              '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',  
                              'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',  
                              'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',  
                              'u', 'v', 'w', 'x', 'y', 'z'  
                          };

        private static string ToBase36String(byte[] toConvert, bool bigEndian = false)
        {
            if (bigEndian) Array.Reverse(toConvert); // !BitConverter.IsLittleEndian might be an alternative  
            BigInteger dividend = new BigInteger(toConvert);
            var builder = new StringBuilder();
            while (dividend != 0)
            {
                BigInteger remainder;
                dividend = BigInteger.DivRem(dividend, 36, out remainder);
                builder.Insert(0, BASE36[Math.Abs(((int)remainder))]);
            }
            return builder.ToString();
        }

        public static String NewGuid()
        {
            return ToBase36String(Guid.NewGuid().ToByteArray());
        }

        /// <summary>  
        /// 根据GUID获取16位的唯一字符串  
        /// </summary>  
        /// <param name=\"guid\"></param>  
        /// <returns></returns>  
        public static string GuidTo16String()
        {
            return string.Format("{0:x}", BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0));
        }

        /// <summary>  
        /// 根据GUID获取19位的唯一数字序列  
        /// </summary>  
        /// <returns></returns>  
        public static long GuidTo19Long()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>  
        /// 根据DateTime.Ticks获取16位的唯一字符串 
        /// </summary>  
        /// <returns></returns>  
        public static string TicksTo10String()
        {
            System.Threading.Thread.Sleep(1);
            return string.Format("{0:x}", (DateTime.Now.Ticks - 621355968000000000) / 100000);
        }

        /// <summary>  
        /// 生成22位唯一的数字 并发可用  
        /// </summary>  
        /// <returns></returns>  
        public static string GenerateUniqueID()
        {
            System.Threading.Thread.Sleep(1); //保证yyyyMMddHHmmssffff唯一  
            Random d = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0));
            string strUnique = DateTime.Now.ToString("yyyyMMddHHmmssffff") + d.Next(1000, 9999);
            return strUnique;
        }
    }
}
