using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Library.Basic
{
    public class ToolCompression
    {
        public static byte[] CompressGZip(string str)
        {
            byte[] stringAsBytes = Encoding.Default.GetBytes(str);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return (memoryStream.ToArray());
                }
            }
        }

        public static byte[] CompressGZip(string str, Encoding encoding)
        {
            byte[] stringAsBytes = encoding.GetBytes(str);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return (memoryStream.ToArray());
                }
            }
        }

        public static string DecompressGZip(byte[] bytes)
        {
            const int bufferSize = 1024;
            using (var memoryStream = new MemoryStream(bytes))
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    using (var outStream = new MemoryStream())
                    {
                        var buffer = new byte[bufferSize];
                        int totalBytes = 0;
                        int readBytes;
                        while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outStream.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                        return Encoding.Default.GetString(outStream.GetBuffer(), 0, totalBytes);
                    }
                }
            }
        }

        public static string DecompressGZip(byte[] bytes, Encoding encoding)
        {
            const int bufferSize = 1024;
            using (var memoryStream = new MemoryStream(bytes))
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    using (var outStream = new MemoryStream())
                    {
                        var buffer = new byte[bufferSize];
                        int totalBytes = 0;
                        int readBytes;
                        while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outStream.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                        return encoding.GetString(outStream.GetBuffer(), 0, totalBytes);
                    }
                }
            }
        }

        public static void CreateGZip(FileInfo fileInfo)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(fileInfo.FullName + ".gz"))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void CreateGZip(FileInfo fileInfo, string destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void CreateGZip(FileInfo fileInfo, FileInfo destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void ExtractGZipToDirectory(FileInfo fileInfo)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                string newFileName = Path.GetFileNameWithoutExtension(fileInfo.FullName);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        public static void ExtractGZipToDirectory(FileInfo fileInfo, string destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void ExtractGZipToDirectory(FileInfo fileInfo, FileInfo destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}
