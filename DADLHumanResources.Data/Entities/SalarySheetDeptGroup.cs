using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SalarySheetDeptGroup
    {
        public int RecId { get; set; }
        public string Deptid { get; set; }
        public string Deptname { get; set; }
        public string DepartmentName { get; set; }
        public string GroupName { get; set; }
    }
}
