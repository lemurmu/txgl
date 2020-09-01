using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace Library.Basic
{
    public static class DataRowExtension
    {
        public static string GetString(this DataRow row, string columnName)
        {
            if (row[columnName] == DBNull.Value)
            {
                return String.Empty;
            }
            return row[columnName].ToString();
        }

        public static T ToEntity<T>(this DataRow @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();

            foreach (PropertyInfo property in properties)
            {
                if (@this.Table.Columns.Contains(property.Name))
                {
                    Type valueType = property.PropertyType;
                    property.SetValue(entity, @this[property.Name].To(valueType), null);
                }
            }

            foreach (FieldInfo field in fields)
            {
                if (@this.Table.Columns.Contains(field.Name))
                {
                    Type valueType = field.FieldType;
                    field.SetValue(entity, @this[field.Name].To(valueType));
                }
            }

            return entity;
        }

        public static IEnumerable<T> ToEntities<T>(this DataTable @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            foreach (DataRow dr in @this.Rows)
            {
                var entity = new T();

                foreach (PropertyInfo property in properties)
                {
                    if (@this.Columns.Contains(property.Name))
                    {
                        Type valueType = property.PropertyType;
                        property.SetValue(entity, dr[property.Name].To(valueType), null);
                    }
                }

                foreach (FieldInfo field in fields)
                {
                    if (@this.Columns.Contains(field.Name))
                    {
                        Type valueType = field.FieldType;
                        field.SetValue(entity, dr[field.Name].To(valueType));
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}
