using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsUserFeed
    {
        public uint FeedId { get; set; }
        public uint UserId { get; set; }
        public uint ValueId { get; set; }
        public uint GoodsId { get; set; }
        public byte FeedType { get; set; }
        public byte IsFeed { get; set; }
    }
}
