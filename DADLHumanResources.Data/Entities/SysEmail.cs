using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysEmail
    {
        public int RecId { get; set; }
        public string MailId { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPass { get; set; }
        public bool? Active { get; set; }
    }
}
