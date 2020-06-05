using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleaveExtcode
    {
        public int RecId { get; set; }
        public string OwnerId { get; set; }
        public string EmplId { get; set; }
        public string EmplName { get; set; }
    }
}
