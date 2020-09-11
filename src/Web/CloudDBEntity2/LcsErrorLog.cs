using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsErrorLog
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string File { get; set; }
        public int Time { get; set; }
    }
}
