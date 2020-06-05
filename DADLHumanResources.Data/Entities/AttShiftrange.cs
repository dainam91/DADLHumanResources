using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttShiftrange
    {
        public string ShiftType { get; set; }
        public string BeforeIn { get; set; }
        public string AfterIn { get; set; }
        public string BeforeOut { get; set; }
        public string AfterOut { get; set; }
    }
}
