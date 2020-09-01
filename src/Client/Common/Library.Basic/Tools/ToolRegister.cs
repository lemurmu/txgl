using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Library.Basic
{
    public class ToolRegister
    {
        public static object GetRegistryKeyValue(string name, RegistryKey root, string path)
        {
            RegistryKey key = root.CreateSubKey(path);
            return key.GetValue(name);
        }

        public static void SetRegistryKeyValue(string name, object value, RegistryKey root, string path)
        {
            RegistryKey key = root.CreateSubKey(path);
            key.SetValue(name, value);
        }
    }
}
