using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsComment
    {
        public uint CommentId { get; set; }
        public byte CommentType { get; set; }
        public uint IdValue { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public byte CommentRank { get; set; }
        public uint AddTime { get; set; }
        public string IpAddress { get; set; }
        public byte Status { get; set; }
        public uint ParentId { get; set; }
        public uint UserId { get; set; }
    }
}
