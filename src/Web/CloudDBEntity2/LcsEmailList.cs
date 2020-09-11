using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsEmailList
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Stat { get; set; }
        public string Hash { get; set; }
    }
}
