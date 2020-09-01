using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class BoolExtension
    {
        public static void IfTrue(this bool @this, Action action)
        {
            if (@this)
            {
                action();
            }
        }

        public static void IfFalse(this bool @this, Action action)
        {
            if (!@this)
            {
                action();
            }
        }

        public static byte ToBinary(this bool @this)
        {
            return Convert.ToByte(@this);
        }

        public static string ToString(this bool @this, string trueValue, string falseValue)
        {
            return @this ? trueValue : falseValue;
        }
    }
}
