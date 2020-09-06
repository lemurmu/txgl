using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BizUtils.Rest
{
    [Serializable]
    public class HttpHeadInfo
    {
        private string contentType = HttpContentType.Json;

        public string ContentType
        {
            get { return contentType; }
            set { contentType = value; }
        }

        private HttpStatusCode statusCode = HttpStatusCode.BadRequest;

        public HttpStatusCode StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        //private string statusDescription = "ack";

        //public string StatusDescription
        //{
        //    get { return statusDescription; }
        //    set { statusDescription = value; }
        //}

        public static byte[] ToBytes(HttpHeadInfo info)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            binFormat.Serialize(stream, info);
            byte[] rawBytes = stream.ToArray();
            //DC.DCLogger.LogTrace("rawBytes.Length:{0}", rawBytes.Length);
            byte[] totalLen = BitConverter.GetBytes(rawBytes.Length);
            return totalLen.Concat(rawBytes).ToArray();
        }


        public static HttpHeadInfo FromBytes(byte[] bytes, int index, int count)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            return binFormat.Deserialize(new MemoryStream(bytes, index, count)) as HttpHeadInfo;
        }

    }
}
