using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class TempJournal
    {
        public string JournalNumber { get; set; }
        public string WorkType { get; set; }
        public string Employee { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public double? Hours { get; set; }
    }
}
