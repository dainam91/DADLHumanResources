using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class PayrollOrgdept
    {
        public int RecId { get; set; }
        public string DeptName { get; set; }
        public int? ParentId { get; set; }
        public string FieldName { get; set; }
        public int? SortIndex { get; set; }
    }
}
