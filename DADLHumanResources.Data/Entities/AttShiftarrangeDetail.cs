using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttShiftarrangeDetail
    {
        public int RecId { get; set; }
        public int? YearPeriod { get; set; }
        public int? WeekNum { get; set; }
        public DateTime? TransDate { get; set; }
        public string EmplId { get; set; }
        public string Shift { get; set; }
    }
}
