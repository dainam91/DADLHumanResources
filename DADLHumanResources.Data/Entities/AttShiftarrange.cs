using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttShiftarrange
    {
        public int RecId { get; set; }
        public int? YearPeriod { get; set; }
        public int? WeekNum { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string EmplId { get; set; }
        public string EmplName { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public DateTime? TransDate { get; set; }
        public string Shift { get; set; }
        public string DefaultDayOff { get; set; }
        public string Description { get; set; }
    }
}
