using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class StringBuilderExtension
    {
        public static StringBuilder AppendIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.Append(value);
                }
            }

            return @this;
        }

        public static string Substring(this StringBuilder @this, int startIndex)
        {
            return @this.ToString(startIndex, @this.Length - startIndex);
        }

        public static string Substring(this StringBuilder @this, int startIndex, int length)
        {
            return @this.ToString(startIndex, length);
        }
    }
}
