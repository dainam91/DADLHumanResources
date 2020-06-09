using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class InsuranceLine
    {
        public int Recid { get; set; }
        public string Insurancecode { get; set; }
        public int Basicsalaryallowance { get; set; }
        public int Hrminsurancepayedby { get; set; }
        public double Percent { get; set; }
    }
}
