using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAd
    {
        public ushort AdId { get; set; }
        public ushort PositionId { get; set; }
        public byte MediaType { get; set; }
        public string AdName { get; set; }
        public string AdLink { get; set; }
        public string AdCode { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string LinkMan { get; set; }
        public string LinkEmail { get; set; }
        public string LinkPhone { get; set; }
        public uint ClickCount { get; set; }
        public byte Enabled { get; set; }
    }
}
