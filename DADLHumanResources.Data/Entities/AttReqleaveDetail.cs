using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleaveDetail
    {
        public int RecId { get; set; }
        public string RequestId { get; set; }
        public string Shift { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public DateTime? DateReturn { get; set; }
        public double? Total { get; set; }
        public string WorkType { get; set; }
        public bool? Emergency { get; set; }
        public string Reason { get; set; }
    }
}
