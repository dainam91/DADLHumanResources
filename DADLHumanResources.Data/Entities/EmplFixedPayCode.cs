using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class EmplFixedPayCode
    {
        public int RecId { get; set; }
        public string PayCode { get; set; }
        public string EmplId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string CurrencyCode { get; set; }
        public double? AmountCur { get; set; }
        public bool? FindNext { get; set; }
    }
}
