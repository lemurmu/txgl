using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsEmailSendlist
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int TemplateId { get; set; }
        public string EmailContent { get; set; }
        public bool Error { get; set; }
        public sbyte Pri { get; set; }
        public int LastSend { get; set; }
    }
}
