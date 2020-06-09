using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class Transferposition
    {
        public long Recid { get; set; }
        public string EmplId { get; set; }
        public string CurrentPosition { get; set; }
        public string CurrentDept { get; set; }
        public DateTime? TransferDate { get; set; }
        public string NewPosition { get; set; }
        public string NewDept { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string ProbationPeriod { get; set; }
        public double? NewSalary { get; set; }
        public string Trainer { get; set; }
        public string Notes { get; set; }
        public int? Year { get; set; }
    }
}
