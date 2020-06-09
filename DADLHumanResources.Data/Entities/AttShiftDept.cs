using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttShiftDept
    {
        public int Recid { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public int? SortId { get; set; }
    }
}
