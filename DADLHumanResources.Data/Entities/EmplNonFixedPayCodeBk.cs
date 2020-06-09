using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class EmplNonFixedPayCodeBk
    {
        public int RecId { get; set; }
        public string PayPeriodCode { get; set; }
        public string PayPeriodType { get; set; }
        public string PayCode { get; set; }
        public string EmplId { get; set; }
        public double AmountCur { get; set; }
        public string CurrencyCode { get; set; }
        public string Notes { get; set; }
    }
}
