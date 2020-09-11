using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsUserAddress
    {
        public uint AddressId { get; set; }
        public string AddressName { get; set; }
        public uint UserId { get; set; }
        public string Consignee { get; set; }
        public string Email { get; set; }
        public short Country { get; set; }
        public short Province { get; set; }
        public short City { get; set; }
        public short District { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string SignBuilding { get; set; }
        public string BestTime { get; set; }
    }
}
