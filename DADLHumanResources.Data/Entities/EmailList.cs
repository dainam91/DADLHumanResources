using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class EmailList
    {
        public int RecId { get; set; }
        public string EmailGroupId { get; set; }
        public string EmplId { get; set; }
        public string EmailAddress { get; set; }
        public bool? Active { get; set; }
    }
}
