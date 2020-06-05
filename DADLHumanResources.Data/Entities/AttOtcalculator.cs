using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttOtcalculator
    {
        public int RecId { get; set; }
        public string OtrequestNo { get; set; }
        public DateTime? Transdate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public double? Hour { get; set; }
        public double? Total { get; set; }
        public string EmployeeId { get; set; }
        public double? Ndo { get; set; }
        public double? Nno { get; set; }
        public double? Sdo1 { get; set; }
        public double? Sdo2 { get; set; }
        public double? Ho1 { get; set; }
        public double? Ho2 { get; set; }
        public double? Ho3 { get; set; }
        public bool? Status { get; set; }
    }
}
