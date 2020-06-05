using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleaveUsers
    {
        public int RecId { get; set; }
        public string EmplId { get; set; }
        public string EmplName { get; set; }
        public string DomainUser { get; set; }
        public string Depts { get; set; }
        public string Password { get; set; }
        public bool? IsFull { get; set; }
        public bool? IsFullShift { get; set; }
        public bool? IsInputDayBefore { get; set; }
        public bool? IsExtCode { get; set; }
    }
}
