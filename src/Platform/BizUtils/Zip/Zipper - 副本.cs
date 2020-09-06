using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BizUtils.Zip
{
    public static class Zipper
    {
        /// <summary>
        /// 将多个流进行zip压缩，返回压缩后的流
        /// </summary>
        /// <param name="streams">key：文件名；value：文件名对应的要压缩的流</param>
        /// <returns>压缩后的流</returns>
        public static Stream PackageManyZip(Dictionary<string, Stream> streams)
        {
            //byte[] buffer = new byte[6500];
            MemoryStream returnStream = new MemoryStream();
            //var zipMs = new MemoryStream();
            using (ZipOutputStream zipStream = new ZipOutputStream(returnStream))
            {
                zipStream.SetLevel(0);
                foreach (var kv in streams)
                {
                    string fileName = kv.Key;
                    using (var streamInput = kv.Value)
                    {
                        //zipStream.PutNextEntry(new ZipEntry(fileName));
                        //while (true)
                        //{
                        //    var readCount = streamInput.Read(buffer, 0, buffer.Length);
                        //    if (readCount > 0)
                        //    {
                        //        zipStream.Write(buffer, 0, readCount);
                        //    }
                        //    else
                        //    {
                        //        break;
                        //    }
                        //}
                        //zipStream.Flush();
                        byte[] buffer = new byte[4 * 1024];
                        zipStream.PutNextEntry(new ZipEntry(fileName));

                        int sourceBytes;
                        do
                        {
                            sourceBytes = streamInput.Read(buffer, 0, buffer.Length);
                            zipStream.Write(buffer, 0, sourceBytes);
                        } while (sourceBytes > 0);
                    }
                }
                zipStream.Finish();
                //zipMs.Position = 0;
                //zipMs.CopyTo(returnStream, 5600);
            }
            //returnStream.Position = 0;
            return returnStream;
        }

        /// <summary>
        /// 将多个流进行zip压缩，返回压缩后的流
        /// </summary>
        /// <param name="streams">key：文件名；value：文件名对应的要压缩的流</param>
        /// <returns>void</returns>
        public static void PackageManyZip(Dictionary<string, string> streams, Stream returnStream)
        {
            //byte[] buffer = new byte[6500];
            //var zipMs = new MemoryStream();
            using (ZipOutputStream zipStream = new ZipOutputStream(returnStream))
            {
                zipStream.SetLevel(0);
                foreach (var kv in streams)
                {
                    string fileName = kv.Key;
                    {
                        //zipStream.PutNextEntry(new ZipEntry(fileName));
                        //while (true)
                        //{
                        //    var readCount = streamInput.Read(buffer, 0, buffer.Length);
                        //    if (readCount > 0)
                        //    {
                        //        zipStream.Write(buffer, 0, readCount);
                        //    }
                        //    else
                        //    {
                        //        break;
                        //    }
                        //}
                        //zipStream.Flush();
                        byte[] buffer = new byte[4 * 1024];
                        zipStream.PutNextEntry(new ZipEntry(fileName));
                        using (Stream streamInput = File.OpenRead(kv.Value))
                        {
                            int sourceBytes;
                            do
                            {
                                sourceBytes = streamInput.Read(buffer, 0, buffer.Length);
                                zipStream.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }
                }
                zipStream.Finish();
                //zipMs.Position = 0;
                //zipMs.CopyTo(returnStream, 5600);
            }
            //returnStream.Position = 0;
        }

        /// <summary>
        /// 将多个流进行zip压缩，压缩前调整图片文件宽高比
        /// </summary>
        /// <param name="streams">key：文件名；value：文件名对应的要压缩的流</param>
        /// <returns>void</returns>
        public static void PackageManyZip_WithImageResize(Dictionary<string, string> streams, Stream returnStream)
        {
            using (ZipOutputStream zipStream = new ZipOutputStream(returnStream))
            {
                zipStream.SetLevel(0);
                foreach (var kv in streams)
                {
                    string fileName = kv.Key;
                    {
                        byte[] buffer = new byte[10 * 1024];
                        zipStream.PutNextEntry(new ZipEntry(fileName));

                        string duan_chang = fileName.Split(',')[2];//AA01，1张，40x60cm，写真
                        int duan = int.Parse(duan_chang.Substring(0, duan_chang.IndexOf('x')));
                        int chang = int.Parse(duan_chang.Substring(duan_chang.IndexOf('x') + 1));
                        using (Stream originStream = File.OpenRead(kv.Value))
                        {
                            using (Image origin = Image.FromStream(originStream))
                            {
                                float kuan_inch = 100;
                                float gao_inch = 100;
                                if (origin.Size.Width > origin.Size.Height)
                                {
                                    gao_inch = duan * 10 / 25.4f;
                                    kuan_inch = chang * 10 / 25.4f;
                                }
                                else
                                {
                                    gao_inch = chang * 10 / 25.4f;
                                    kuan_inch = duan * 10 / 25.4f;
                                }

                                using (Bitmap newBit = new Bitmap(origin))
                                using (MemoryStream streamInput = new MemoryStream())
                                {

                                    float xDpi = origin.Size.Width / kuan_inch;
                                    float yDpi = origin.Size.Height / gao_inch;
                                    newBit.SetResolution(xDpi, yDpi);
                                    newBit.Save(streamInput, origin.RawFormat);
                                    streamInput.Flush();
                                    streamInput.Seek(0, SeekOrigin.Begin);
                                    int sourceBytes;
                                    do
                                    {
                                        sourceBytes = streamInput.Read(buffer, 0, buffer.Length);
                                        zipStream.Write(buffer, 0, sourceBytes);
                                    } while (sourceBytes > 0);
                                }
                            }
                        }
                    }
                }
                zipStream.Finish();
            }
        }

    }
}
