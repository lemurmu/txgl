using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Config { get; set; }
        public sbyte Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
