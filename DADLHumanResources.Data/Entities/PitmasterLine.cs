using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class PitmasterLine
    {
        public int Recid { get; set; }
        public string Pitcode { get; set; }
        public decimal Lowboundary { get; set; }
        public decimal Upboundary { get; set; }
        public decimal Taxrate { get; set; }
        public decimal Taxdeduction { get; set; }
    }
}
