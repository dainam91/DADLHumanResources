using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class PayCodeTable
    {
        public int Recid { get; set; }
        public string Paycode { get; set; }
        public string Description { get; set; }
        public int Paytype { get; set; }
        public string Ledgeraccount { get; set; }
        public bool? Nontaxable { get; set; }
        public int? Paycodeunit { get; set; }
        public bool? Noncashallowance { get; set; }
        public int? Fixedorattendancebase { get; set; }
        public bool? Includeincost { get; set; }
        public string Offsetledgeraccount { get; set; }
        public bool? Nettcalculation { get; set; }
        public bool? Ifsintegration { get; set; }
        public int? Attendancedays { get; set; }
        public double? Taxablepercent { get; set; }
        public double? Nontaxablepercent { get; set; }
    }
}
