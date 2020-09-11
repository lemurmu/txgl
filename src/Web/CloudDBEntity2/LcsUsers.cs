using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsUsers
    {
        public uint UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public byte Sex { get; set; }
        public DateTime Birthday { get; set; }
        public decimal UserMoney { get; set; }
        public decimal FrozenMoney { get; set; }
        public uint PayPoints { get; set; }
        public uint RankPoints { get; set; }
        public uint AddressId { get; set; }
        public uint RegTime { get; set; }
        public uint LastLogin { get; set; }
        public DateTime LastTime { get; set; }
        public string LastIp { get; set; }
        public ushort VisitCount { get; set; }
        public byte UserRank { get; set; }
        public byte IsSpecial { get; set; }
        public string EcSalt { get; set; }
        public string Salt { get; set; }
        public int ParentId { get; set; }
        public byte Flag { get; set; }
        public string Alias { get; set; }
        public string Msn { get; set; }
        public string Qq { get; set; }
        public string OfficePhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public byte IsValidated { get; set; }
        public decimal CreditLine { get; set; }
        public string PasswdQuestion { get; set; }
        public string PasswdAnswer { get; set; }
    }
}
