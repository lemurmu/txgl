using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;

namespace Library.Basic
{
    public static class IEnumerableExtension
    {

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this != null && @this.Any();
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            if (source == null || action == null) return;

            if (source is TSource[])
            {
                Array.ForEach(source as TSource[], action);
            }
            else if (source is List<TSource>)
            {
                (source as List<TSource>).ForEach(action);
            }
            else
            {
                foreach (TSource t in source)
                    action(t);
            }
        }

        public static string Join(this IEnumerable source, string separator)
        {
            if (source == null) return String.Empty;

            if (separator == null)
                separator = String.Empty;
            
            StringBuilder sb = new StringBuilder();
            IEnumerator enumerator = source.GetEnumerator();

            object current = null;
            if (enumerator.MoveNext())
                current = enumerator.Current;

            while (current != null)
            {
                sb.Append(current.ToString());
                if (!enumerator.MoveNext())
                    break;

                sb.Append(separator);
                current = enumerator.Current;
            }

            return sb.ToString();
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> @this)
        {
            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var dt = new DataTable();

            foreach (PropertyInfo property in properties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }

            foreach (FieldInfo field in fields)
            {
                dt.Columns.Add(field.Name, field.FieldType);
            }

            foreach (T item in @this)
            {
                DataRow dr = dt.NewRow();

                foreach (PropertyInfo property in properties)
                {
                    dr[property.Name] = property.GetValue(item, null);
                }

                foreach (FieldInfo field in fields)
                {
                    dr[field.Name] = field.GetValue(item);
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
