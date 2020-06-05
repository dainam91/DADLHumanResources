using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class Departments
    {
        public int RecId { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public bool? Active { get; set; }
    }
}
