using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsStats
    {
        public uint AccessTime { get; set; }
        public string IpAddress { get; set; }
        public ushort VisitTimes { get; set; }
        public string Browser { get; set; }
        public string System { get; set; }
        public string Language { get; set; }
        public string Area { get; set; }
        public string RefererDomain { get; set; }
        public string RefererPath { get; set; }
        public string AccessUrl { get; set; }
    }
}
