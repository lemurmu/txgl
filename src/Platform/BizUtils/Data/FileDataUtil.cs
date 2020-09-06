using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BizUtils.Data
{
    public class FileDataUtil
    {
        static object idUniqueLock = new object();
        public static string GenFileIdInternal()
        {
            long id = 0;
            lock (idUniqueLock)
            {
                id = (DateTime.Now.Ticks - 621355968000000000) / 10000;
            }
            return id.ToString();
        }

        public static string GenFileIdPath(long id)
        {
            string path = string.Empty;
            DateTime date = new DateTime(id * 10000 + 621355968000000000).Date;
            path = date.ToString("yyyyMM");
            return path;
        }

        private static List<string> latestFileNames = new List<string>();
        private static object locker = new object();
        public static string GenFileNameInternal(string filecate)
        {
            string fileName = null;

            string fileNamePre = string.Concat(filecate, "_", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            lock (locker)
            {
                for (int seed = 0; seed < 1000000; seed++)
                {
                    fileName = string.Concat(fileNamePre, "_", seed.ToString("000000"));
                    if (!latestFileNames.Contains(fileName))
                        break;
                }

                latestFileNames.Add(fileName);
                if (latestFileNames.Count > 1000000)
                {
                    latestFileNames.RemoveRange(0, 1000000 / 100);
                }
            }
            return fileName;
        }

        public static string GenFilePathInternal(string rootDir, string filename)
        {
            int idx = filename.IndexOf('_');
            if (idx <= 0)
                return null;

            string cate = filename.Substring(0, idx);
            string other = filename.Substring(idx + 1);
            int idx2 = other.IndexOf('_');
            if (idx2 <= 0)
                return null;

            string date = other.Substring(0, idx2);
            string filepath = Path.Combine(rootDir, cate, date, filename);

            try
            {
                Directory.CreateDirectory(Path.Combine(rootDir, cate, date));
            }
            catch { }

            return filepath;
        }

        public static string JudgeFileType(string filename)
        {
            int idx = filename.LastIndexOf('.');
            string ext = string.Empty;
            if (idx > 0)
                ext = filename.Substring(idx + 1).ToLower();
            switch (ext)
            {
                case "":
                default:
                    return "application";
                case "jpg":
                case "jpeg":
                case "png":
                case "gif":
                    return "image";
                case "dbf":
                    return "application";
            }
        }
    }
}
