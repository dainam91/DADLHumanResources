using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class InsuranceTable
    {
        public int Recid { get; set; }
        public string Insurancecode { get; set; }
        public string Description { get; set; }
        public string Currencycode { get; set; }
        public string Paycode { get; set; }
        public double Maximumbaseamountcur { get; set; }
        public int Minimumjoindays { get; set; }
        public int Maximumabsenceexceptiondays { get; set; }
        public int Insurancetype { get; set; }
    }
}
