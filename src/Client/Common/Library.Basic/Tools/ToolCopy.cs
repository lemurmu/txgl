using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;

namespace Library.Basic
{
    public class ToolCopy
    {
        public static object DeepCopy(object obj)
        {
            BinaryFormatter formartter = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            formartter.Serialize(ms, obj);
            ms.Position = 0;
            var newObj = formartter.Deserialize(ms);
            return newObj;
        }

        public static T DeepCopy<T>(T obj)
        {
            return (T)DeepCopy(obj);
        }

        public static T ShallowCopy<T>(T obj)
        {
            MethodInfo method = obj.GetType().GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)method.Invoke(obj, null);
        }
    }
}
