using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class TempNonFixedPayCode
    {
        public string PayPeriodCode { get; set; }
        public string PeriodType { get; set; }
        public string PayCode { get; set; }
        public string Employee { get; set; }
        public double? AmountCurrency { get; set; }
        public string Currency { get; set; }
    }
}
