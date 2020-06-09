using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysUserTable
    {
        public int RecId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string DomainUser { get; set; }
        public string Password { get; set; }
        public string GroupId { get; set; }
        public bool? Active { get; set; }
    }
}
