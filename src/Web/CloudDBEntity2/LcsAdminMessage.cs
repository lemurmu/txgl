using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAdminMessage
    {
        public ushort MessageId { get; set; }
        public byte SenderId { get; set; }
        public byte ReceiverId { get; set; }
        public uint SentTime { get; set; }
        public uint ReadTime { get; set; }
        public byte Readed { get; set; }
        public byte Deleted { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
