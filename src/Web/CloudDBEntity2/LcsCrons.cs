using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsCrons
    {
        public byte CronId { get; set; }
        public string CronCode { get; set; }
        public string CronName { get; set; }
        public string CronDesc { get; set; }
        public byte CronOrder { get; set; }
        public string CronConfig { get; set; }
        public int Thistime { get; set; }
        public int Nextime { get; set; }
        public sbyte Day { get; set; }
        public string Week { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public bool? Enable { get; set; }
        public bool RunOnce { get; set; }
        public string AllowIp { get; set; }
        public string AlowFiles { get; set; }
    }
}
