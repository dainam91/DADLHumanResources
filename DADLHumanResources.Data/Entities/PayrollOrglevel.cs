using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class PayrollOrglevel
    {
        public int RecId { get; set; }
        public string LevelName { get; set; }
        public int? ParentId { get; set; }
        public int? SoftIndex { get; set; }
    }
}
