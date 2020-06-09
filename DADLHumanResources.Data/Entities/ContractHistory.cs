using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class ContractHistory
    {
        public long Recid { get; set; }
        public string EmplId { get; set; }
        public int ContractType { get; set; }
        public DateTime? BeginContract { get; set; }
        public DateTime? ExpireContract { get; set; }
        public string Position { get; set; }
        public double? BasicSalary { get; set; }
        public int? TimeSpanId { get; set; }
        public string Notes { get; set; }
    }
}
