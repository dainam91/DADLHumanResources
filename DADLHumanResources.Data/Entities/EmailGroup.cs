using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class EmailGroup
    {
        public int RecId { get; set; }
        public string GroupId { get; set; }
        public string EmailTitle { get; set; }
        public string EmailContent { get; set; }
        public bool? Active { get; set; }
    }
}
