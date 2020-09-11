using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAdminUser
    {
        public ushort UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EcSalt { get; set; }
        public int AddTime { get; set; }
        public int LastLogin { get; set; }
        public string LastIp { get; set; }
        public string ActionList { get; set; }
        public string NavList { get; set; }
        public string LangType { get; set; }
        public ushort AgencyId { get; set; }
        public ushort? SuppliersId { get; set; }
        public string Todolist { get; set; }
        public short? RoleId { get; set; }
        public string PassportUid { get; set; }
        public short? YqCreateTime { get; set; }
    }
}
