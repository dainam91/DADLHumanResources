using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleaveCalctime
    {
        public int RecId { get; set; }
        public int? LineId { get; set; }
        public string RequestId { get; set; }
        public string EmplId { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? TotalHours { get; set; }
        public string WorkType { get; set; }
        public bool? ApprovedByHr { get; set; }
        public bool? RejectedByHr { get; set; }
        public int? DiscriplinaryId { get; set; }
        public string HrfeedBack { get; set; }
    }
}
