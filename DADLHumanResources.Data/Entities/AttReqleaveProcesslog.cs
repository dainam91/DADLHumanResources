using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqleaveProcesslog
    {
        public long RecId { get; set; }
        public string RequestId { get; set; }
        public string EmplId { get; set; }
        public string LogType { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
