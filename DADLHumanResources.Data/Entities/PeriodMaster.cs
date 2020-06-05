using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class PeriodMaster
    {
        public int? Recid { get; set; }
        public string Payperiodcode { get; set; }
        public string Payperiodtype { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public bool Flag { get; set; }
        public string Num { get; set; }
    }
}
