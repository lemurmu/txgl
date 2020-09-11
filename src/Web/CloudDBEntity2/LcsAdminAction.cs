using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAdminAction
    {
        public byte ActionId { get; set; }
        public byte ParentId { get; set; }
        public string ActionCode { get; set; }
        public string Relevance { get; set; }
    }
}
