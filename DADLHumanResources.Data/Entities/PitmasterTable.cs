using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class PitmasterTable
    {
        public int Recid { get; set; }
        public string Pitcode { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public string Description { get; set; }
        public string Paycode { get; set; }
        public string Companypaycode { get; set; }
        public int Nodeduction { get; set; }
    }
}
