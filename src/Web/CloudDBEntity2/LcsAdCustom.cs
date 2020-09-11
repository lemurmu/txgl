using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAdCustom
    {
        public uint AdId { get; set; }
        public byte AdType { get; set; }
        public string AdName { get; set; }
        public uint AddTime { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public byte AdStatus { get; set; }
    }
}
