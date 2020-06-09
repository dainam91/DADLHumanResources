using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttOtrequestitems
    {
        public int RecId { get; set; }
        public string OtrequestNo { get; set; }
        public string EmployeeId { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public double Hour { get; set; }
        public bool? Status { get; set; }
        public string Remark { get; set; }

        public virtual AttOtreq OtrequestNoNavigation { get; set; }
    }
}
