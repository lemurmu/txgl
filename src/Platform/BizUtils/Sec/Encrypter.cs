using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace BizUtils.Sec
{
    public class Encrypter
    {
        static MD5CryptoServiceProvider md5;

        static Encrypter()
        {
            md5 = new MD5CryptoServiceProvider();
        }

        ///   <summary>
        ///   给一个字符串进行MD5加密
        ///   </summary>
        ///   <param   name="strText">待加密字符串</param>
        ///   <returns>加密后的字符串</returns>
        public static string MD5Encrypt(string strText)
        {
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(strText));
            return BitConverter.ToString(result).Replace("-", string.Empty);
        }
    }
}
