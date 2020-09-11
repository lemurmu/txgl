using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsCallbackStatus
    {
        public ulong Id { get; set; }
        public string MsgId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string TypeId { get; set; }
        public int? DateTime { get; set; }
        public string Data { get; set; }
        public string Disabled { get; set; }
        public sbyte? Times { get; set; }
        public string Method { get; set; }
        public string HttpType { get; set; }
    }
}
