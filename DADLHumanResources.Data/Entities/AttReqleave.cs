using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleave
    {
        public int RecId { get; set; }
        public string RequestId { get; set; }
        public string EmplId { get; set; }
        public string EmplName { get; set; }
        public string Department { get; set; }
        public string ProdLocation { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Pcname { get; set; }
        public bool? Approved { get; set; }
        public bool? Rejected { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UpdatedUser { get; set; }
        public string UpdatedName { get; set; }
    }
}
