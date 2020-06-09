using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities 
{
    public partial class AttCheckinout
    {
        public int RecId { get; set; }
        public string EmplId { get; set; }
        public string FullName { get; set; }
        public string DeptId { get; set; }
        public string Position { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string LaterIn { get; set; }
        public string EarlyOut { get; set; }
        public string Shift { get; set; }
        public string WeeklyShift { get; set; }
        public string DayOff { get; set; }
        public string WorkingTime { get; set; }
        public double? WorkingHours { get; set; }
    }
}
