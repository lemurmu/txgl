using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsPush
    {
        public uint Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public string ObjectId { get; set; }
        public string Link { get; set; }
        public sbyte Platform { get; set; }
        public sbyte? PushType { get; set; }
        public sbyte? MessageType { get; set; }
        public sbyte? IsPush { get; set; }
        public DateTime? PushAt { get; set; }
        public sbyte Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
