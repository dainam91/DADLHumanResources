using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class ActualWorkingHours
    {
        public long Recid { get; set; }
        public string PayPeriodCode { get; set; }
        public string EmplId { get; set; }
        public double? WorkingHours { get; set; }
    }
}
