using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsDevice
    {
        public int UserId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string PlatformType { get; set; }
        public sbyte Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
