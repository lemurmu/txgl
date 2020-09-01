using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class ArrayExtension
    {
        public static void BlockCopy(this Array src, Int32 srcOffset, Array dst, Int32 dstOffset, Int32 count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }

        public static void ClearAll(this Array @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }
    }
}
