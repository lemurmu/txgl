using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsFeedback
    {
        public uint MsgId { get; set; }
        public uint ParentId { get; set; }
        public uint UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string MsgTitle { get; set; }
        public byte MsgType { get; set; }
        public byte MsgStatus { get; set; }
        public string MsgContent { get; set; }
        public uint MsgTime { get; set; }
        public string MessageImg { get; set; }
        public uint OrderId { get; set; }
        public byte MsgArea { get; set; }
    }
}
