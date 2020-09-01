using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class IDictionaryExtension
    {

        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(key, value);
                return true;
            }

            return false;
        }

        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
            else
            {
                @this[key] = value;
            }

            return @this[key];
        }

        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey, TValue>(key, value));
            }

            return @this[key];
        }

        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key, TValue defaultValue)
        {
            return source.ContainsKey(key) ? source[key] : defaultValue;
        }

        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key)
        {
            return GetValue(source, key, default(TValue));
        }
    }
}
