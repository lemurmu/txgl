using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Basic
{
    /// <summary>
    /// 身份证号码
    /// </summary>
    public class ToolICN
    {

        private static readonly string verifyCode = "10X98765432";  //校验位的取值列表。
        private static readonly int[] authorityFactory = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 }; //加权因子。
        private static readonly string[] cities = new string[] { 
            null,   null,    null,   null,     null,   null,    null,  null,    null, null, 
            null,   "北京", "天津", "河北",  "山西","内蒙古",null,  null,    null, null, 
            null,   "辽宁", "吉林", "黑龙江",null,   null,    null,  null,    null, null, 
            null,   "上海", "江苏", "浙江",  "安微", "福建", "江西","山东", null, null, 
            null,   "河南", "湖北", "湖南", "广东", "广西",  "海南",null,    null, null, 
            "重庆", "四川", "贵州", "云南", "西藏", null,    null,   null,    null, null, 
            null,   "陕西", "甘肃", "青海", "宁夏", "新疆",  null,   null,    null, null, 
            null,   "台湾", null,    null,    null,   null,    null,    null,   null, null, 
            null,   "香港", "澳门",  null,     null,   null,   null,   null,   null, null, 
            null,   "国外" 
        };

        /// <summary>
        /// 验证指定身份证号码的有效性。
        /// </summary>
        /// <param name="icn">公民的身份证号码。</param>
        /// <returns>如果给定的身份证号码有效则返回 true， 否则返回 false。</returns>
        public static bool Check(string icn)
        {
            if (string.IsNullOrEmpty(icn))
                return false;

            icn = icn.Trim().ToUpper();

            if (icn.Length != 15 && icn.Length != 18)
                return false;

            //检测身份证号的地区
            if (string.IsNullOrEmpty(GetCityInternal(icn)))
                return false;

            if (icn.Length == 15)
            {
                //检测15位身份证号的内容
                if (Regex.IsMatch(icn, @"\d{15}"))
                {
                    //检测能否取出有效的出生日期
                    if (GetBirthdayFromOldId(icn) == DateTime.MinValue)
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }
            else
            {
                //检测18位身份证号的内容
                if (Regex.IsMatch(icn, @"\d{17}(\d|X)", RegexOptions.IgnoreCase))
                {
                    if (GetBirthdayFromNewId(icn) == DateTime.MinValue)
                        return false;
                    else
                    {
                        //验证身份证号的校验位。
                        char verifyChar = icn[17];
                        return verifyChar == BuildParityChar(icn.Substring(0, 17));
                    }
                }
                else
                    return false;   //内容不匹配
            }
        }

        /// <summary>
        /// 获取身份证号中所描述的性别。
        /// </summary>
        /// <param name="icn">有效的身份证号。</param>
        /// <returns>身份证号所描述的性别。</returns>
        public static int GetGender(string icn)
        {
            if (string.IsNullOrEmpty(icn))
                throw new ArgumentNullException("icn");

            if (!Check(icn))
                throw new Exception("无效的身份证号码：" + icn);

            int val = 0;
            string genderChar;

            //18位身份证号码第17位代表性别，奇数为男，偶数为女。
            //15位身份证号码第15位代表性别，奇数为男，偶数为女。
            if (icn.Length == 18)
                genderChar = icn.Substring(icn.Length - 2, 1);
            else
                genderChar = icn.Substring(icn.Length - 1, 1);

            if (int.TryParse(genderChar, out val))
            {
                if (val % 2 == 0)   //如果是偶数则为女性。
                    return 0;
                else
                    return 1;
            }
            else
                throw new Exception("无效的身份证号码：" + icn);
        }

        /// <summary>
        /// 获取身份证号中所描述的性别。
        /// </summary>
        /// <param name="icn">有效的身份证号。</param>
        /// <returns>身份证号所描述的性别。</returns>
        public static int GetGenderInNotCheck(string icn)
        {
            if (string.IsNullOrEmpty(icn))
                return 0;

            int val = 0;
            string genderChar;

            //18位身份证号码第17位代表性别，奇数为男，偶数为女。
            //15位身份证号码第15位代表性别，奇数为男，偶数为女。
            if (icn.Length == 18)
                genderChar = icn.Substring(icn.Length - 2, 1);
            else
                genderChar = icn.Substring(icn.Length - 1, 1);

            if (int.TryParse(genderChar, out val))
            {
                if (val % 2 == 0)   //如果是偶数则为女性。
                    return 0;
                else
                    return 1;
            }
            return 0;
        }

        /// <summary>
        /// 获取身份证号所描述的省份。
        /// </summary>
        /// <param name="icn">有效的身份证号。</param>
        /// <returns></returns>
        public static string GetProvince(string icn)
        {
            if (string.IsNullOrEmpty(icn))
                throw new ArgumentNullException("icn", "身份证号不能为空。");

            if (!Check(icn))
                return string.Empty;

            icn = icn.Trim();

            return GetCityInternal(icn);
        }

        /// <summary>
        /// 获取身份证号所描述的出生日期。
        /// </summary>
        /// <param name="icn">有效的身份证号。</param>
        /// <returns>身份证号所描述的出生日期。</returns>
        public static DateTime GetBirthday(string icn)
        {
            if (!Check(icn))
                return DateTime.Now;

            icn = icn.Trim().ToUpper();
            if (icn.Length == 15)
                return GetBirthdayFromOldId(icn);
            else
                return GetBirthdayFromNewId(icn);
        }

        /// <summary>
        /// 获取身份证号所描述的出生日期。
        /// </summary>
        /// <param name="icn">有效的身份证号。</param>
        /// <returns>身份证号所描述的出生日期。</returns>
        public static DateTime GetBirthdayInNotCheck(string icn)
        {
            try
            {
                if (string.IsNullOrEmpty(icn) || Regex.Replace(icn, @"[\d]", "").Length > 1)
                    return DateTime.Parse("1752-01-01");
                icn = icn.Trim().ToUpper();
                if (icn.Length != 15 && icn.Length != 18)
                    return DateTime.Parse("1752-01-01");
                if (icn.Length == 15)
                    return GetBirthdayFromOldId(icn);
                else
                    return GetBirthdayFromNewId(icn);
            }
            catch
            {
                return DateTime.Parse("1752-01-01");
            }
        }

        /// <summary>
        /// 提取15位身份证号码出生日期的处理方法
        /// </summary>
        /// <param name="icn"></param>
        /// <returns></returns>
        private static DateTime GetBirthdayFromOldId(string icn)
        {
            DateTime val;
            string year = string.Format("19{0}", icn.Substring(6, 2));
            string month = icn.Substring(8, 2);
            string day = icn.Substring(10, 2);
            string date = string.Format("{0}-{1}-{2}", year, month, day);

            if (!DateTime.TryParse(date, out val))
                val = DateTime.MinValue;

            return val;
        }

        /// <summary>
        /// 提取18位身份证号码出生日期的处理方法
        /// </summary>
        /// <param name="icn"></param>
        /// <returns></returns>
        private static DateTime GetBirthdayFromNewId(string icn)
        {
            DateTime val;
            string year = icn.Substring(6, 4);
            string month = icn.Substring(10, 2);
            string day = icn.Substring(12, 2);
            string date = string.Format("{0}-{1}-{2}", year, month, day);
            if (!DateTime.TryParse(date, out val))
                val = DateTime.MinValue;

            return val;
        }

        /// <summary>
        /// 以给定的身份证号的前17位生成身份证号的校验位。
        /// </summary>
        /// <param name="icnHeader">身份证号的前17位。</param>
        /// <returns>身份证号的校验位。</returns>
        public static char BuildParityChar(string icnHeader)
        {
            if (string.IsNullOrEmpty(icnHeader))
                throw new ArgumentNullException("icnHeader");

            icnHeader = icnHeader.Trim();

            if (icnHeader.Length != 17)
                throw new ArgumentOutOfRangeException("icnHeader", "应为身份证号的前17位。");

            int iS = 0;

            for (int i = 0; i < 17; i++)
                iS += (int)(icnHeader[i] - '0') * authorityFactory[i];

            char chr = verifyCode[iS % 11];
            return chr;
        }

        /// <summary>
        /// 将 15 位的身份证号转换为 18 位。
        /// </summary>
        /// <param name="icn">15 位的有效的身份证号。</param>
        /// <returns>已转换的 passportNo 的副本。</returns>
        public static string Convert15To18(string icn)
        {
            if (string.IsNullOrEmpty(icn))
                throw new ArgumentNullException("icn", "身号不能为空。");

            icn = icn.Trim();

            if (icn.Length != 15)
                throw new ArgumentOutOfRangeException("icn", "只接受传入 15 位的身份证号。");

            if (!Check(icn))
                throw new ArgumentException("身份证号无效。");

            //身份证号中插入“19”。
            string strRet = string.Format("{0}19{1}", icn.Substring(0, 6), icn.Substring(6));

            //加入新身份证号的校验码。
            strRet += BuildParityChar(strRet).ToString();

            return strRet;
        }

        private static string GetCityInternal(string icn)
        {
            int cityNo = 0;
            if (!int.TryParse(icn.Substring(0, 2), out cityNo))
                cityNo = 0;

            return cities[cityNo];
        }
    }
}
