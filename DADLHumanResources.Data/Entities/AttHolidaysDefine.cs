using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttHolidaysDefine
    {
        public int Recid { get; set; }
        public DateTime Holiday { get; set; }
        public string Description { get; set; }
    }
}
