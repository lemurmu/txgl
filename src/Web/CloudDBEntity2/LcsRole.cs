using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsRole
    {
        public ushort RoleId { get; set; }
        public string RoleName { get; set; }
        public string ActionList { get; set; }
        public string RoleDescribe { get; set; }
    }
}
