using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleaveHrpost
    {
        public int RecId { get; set; }
        public int? TransId { get; set; }
        public string RequestId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedName { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EmplId { get; set; }
        public string EmplName { get; set; }
        public string Department { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public double? Total { get; set; }
        public string WorkType { get; set; }
        public bool? ApprovedByHr { get; set; }
        public bool? RejectedByHr { get; set; }
        public int? DiscriplinaryId { get; set; }
        public string FeedBack { get; set; }
        public bool? IsSent { get; set; }
    }
}
