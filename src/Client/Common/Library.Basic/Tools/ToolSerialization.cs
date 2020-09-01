using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace Library.Basic
{
    public class ToolSerialization
    {
        public static void SerializeBinary(string fileName, object obj)
        {
            FileStream stream = File.Create(fileName);

            BinaryFormatter binFmt = new BinaryFormatter();
            binFmt.Serialize(stream, obj);
            stream.Close();
        }

        public static object DeserializeBinary(string fileName, Type type)
        {
            FileStream stream = File.OpenRead(fileName);

            BinaryFormatter binFmt = new BinaryFormatter();
            object obj = binFmt.Deserialize(stream);
            stream.Close();

            return obj;
        }

        public static void SerializeXml(string fileName, object obj)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                writer = new StreamWriter(fileName, false, Encoding.UTF8);
                serializer.Serialize(writer, obj);
                writer.Close();
            }
            catch (Exception ex)
            {
                if (writer != null)
                    writer.Close();

                throw ex;
            }
        }

        public static object DeserializeXml(string fileName, Type type)
        {
            StreamReader reader = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(type);
                reader = new StreamReader(fileName);
                object obj = serializer.Deserialize(reader);
                reader.Close();

                return obj;
            }
            catch (Exception ex)
            {
                if (reader != null)
                    reader.Close();

                throw ex;
            }
        }

        public static string SerializeJson<T>(T obj)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, obj);
                return Encoding.Default.GetString(memoryStream.ToArray());
            }
        }

        public static string SerializeJson<T>(T obj, Encoding encoding)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, obj);
                return encoding.GetString(memoryStream.ToArray());
            }
        }

        public static T DeserializeJson<T>(string str)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var stream = new MemoryStream(Encoding.Default.GetBytes(str)))
            {
                return (T)serializer.ReadObject(stream);
            }
        }

        public static T DeserializeJson<T>(string str, Encoding encoding)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var stream = new MemoryStream(encoding.GetBytes(str)))
            {
                return (T)serializer.ReadObject(stream);
            }
        }

        public static string SerializeJavaScript<T>(T obj)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        public static T DeserializeJavaScript<T>(string str)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(str);
        }
    }
}
