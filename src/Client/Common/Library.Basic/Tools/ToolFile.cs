using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Library.Basic
{
    public class ToolFile
    {
        public static string ReplaceExtensionFileName(string fileName, string extension)
        {
            string dir = Path.GetDirectoryName(fileName);
            fileName = Path.GetFileNameWithoutExtension(fileName);
            fileName = string.Format("{0}{1}", fileName, extension);

            return Path.Combine(dir, fileName);
        }

        public static void CreateDirectory(string fileName)
        {
            string path = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
