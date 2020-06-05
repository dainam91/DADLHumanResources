using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttAnnualleaveSummary
    {
        public int RecId { get; set; }
        public string PeriodCode { get; set; }
        public string EmplId { get; set; }
        public string EmplName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime? JoinDate { get; set; }
        public double? AlpreviousYear { get; set; }
        public double? Alpay { get; set; }
        public double? Almove { get; set; }
        public double? DefaultAl { get; set; }
        public double? TotalAlthisYear { get; set; }
        public double? Jan { get; set; }
        public double? Feb { get; set; }
        public double? Mar { get; set; }
        public double? Apr { get; set; }
        public double? May { get; set; }
        public double? Jun { get; set; }
        public double? Jul { get; set; }
        public double? Aug { get; set; }
        public double? Sep { get; set; }
        public double? Oct { get; set; }
        public double? Nov { get; set; }
        public double? Dec { get; set; }
        public double? AvailableAl { get; set; }
        public string Notes { get; set; }
    }
}
