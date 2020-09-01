using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string source)
        {
            return String.IsNullOrEmpty(source);
        }

        public static bool IsNotNullOrEmpty(this string source)
        {
            return !String.IsNullOrEmpty(source);
        }

        public static bool IsNullOrWhitespace(this string source)
        {
            return String.IsNullOrWhiteSpace(source);
        }

        public static bool IsNotNullOrWhitespace(this string source)
        {
            return !String.IsNullOrWhiteSpace(source);
        }

        public static string IfNullOrEmpty(this string source, string defaultVal)
        {
            return String.IsNullOrEmpty(source) ? defaultVal : source;
        }

        public static string IfNullOrWhitespace(this string source, string defaultVal)
        {
            return String.IsNullOrWhiteSpace(source) ? defaultVal : source;
        }

        public static string ClearWhitespace(this string source)
        {
            if (String.IsNullOrWhiteSpace(source)) return String.Empty;
            return source.Replace(" ", String.Empty);
        }

        public static string Left(this string source, int length)
        {
            if (String.IsNullOrEmpty(source)) return String.Empty;
            return source.Length < length ? source : source.Substring(0, length);
        }

        public static string Rigth(this string source, int length)
        {
            if (String.IsNullOrEmpty(source)) return String.Empty;
            return source.Length < length ? source : source.Substring(source.Length - length);
        }

        public static string TrimToMaxLength(this string source, int maxLength, string suffix = "")
        {
            return ((source == null || source.Length <= maxLength) ? source : String.Concat(source.Substring(0, maxLength), suffix));
        }

        public static T To<T>(this string source)
        {
            return To(source, default(T));
        }

        public static T To<T>(this string source, T defaultValue)
        {
            if (String.IsNullOrWhiteSpace(source))
                return defaultValue;

            T retVal = defaultValue;
            try
            {
                //获取要转换的目标类型
                Type targetType = typeof(T);

                if (targetType == typeof(Guid))  //对 Guid 类型的值进行单独处理
                    retVal = (T)((object)(new Guid(source)));
                else if (targetType.BaseType == typeof(Enum))    //对 Enum 类型的值进行单独处理
                    retVal = (T)Enum.Parse(targetType, source);
                else
                    retVal = (T)Convert.ChangeType(source, targetType);
            }
            catch { }

            return retVal;
        }

        public static string GetBefore(this string value, string x)
        {
            if (value == null || x == null)
                return String.Empty;

            int xPos = value.IndexOf(x);
            return xPos == -1 ? String.Empty : value.Substring(0, xPos);
        }

        public static string GetAfter(this string value, string x)
        {
            if (value == null || x == null)
                return String.Empty;

            int xPos = value.LastIndexOf(x);
            if (xPos == -1)
                return String.Empty;

            int startIndex = xPos + x.Length;
            return startIndex >= value.Length ? String.Empty : value.Substring(startIndex);
        }

        public static string GetBetween(this string value, string x, string y)
        {
            if (value == null || x == null||y==null)
                return String.Empty;

            int xPos = value.IndexOf(x);
            int yPos = value.LastIndexOf(y);

            if (xPos == -1 || yPos == -1)
                return String.Empty;

            int startIndex = xPos + x.Length;
            return startIndex >= yPos ? String.Empty : value.Substring(startIndex, yPos - startIndex);
        }

        public static string FormatWith(this string source, params object[] args)
        {
            return String.Format(source, args);
        }
    }
}
