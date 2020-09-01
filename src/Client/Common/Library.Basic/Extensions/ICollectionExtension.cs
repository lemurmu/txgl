using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class ICollectionExtension
    {
        public static bool AddIf<T>(this ICollection<T> @this, Func<T, bool> predicate, T value)
        {
            if (predicate(value))
            {
                @this.Add(value);
                return true;
            }
            return false;
        }

        public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
        {
            List<T> list = @this.Where(predicate).ToList();
            foreach (T item in list)
            {
                @this.Remove(item);
            }
        }
    }
}
