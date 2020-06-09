using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttOtreq
    {
        public AttOtreq()
        {
            AttOtrequestitems = new HashSet<AttOtrequestitems>();
        }

        public int RecId { get; set; }
        public string OtrequestNo { get; set; }
        public string RequestBy { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime OtfromDate { get; set; }
        public DateTime OttoDate { get; set; }
        public string DepartmentCode { get; set; }
        public bool? Status { get; set; }
        public string Purpose { get; set; }
        public string Code { get; set; }
        public bool? Approve { get; set; }

        public virtual ICollection<AttOtrequestitems> AttOtrequestitems { get; set; }
    }
}
