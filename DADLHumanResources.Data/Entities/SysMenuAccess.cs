using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysMenuAccess
    {
        public int RecId { get; set; }
        public string GroupId { get; set; }
        public string MenuId { get; set; }
        public string AccessInfo { get; set; }
        public bool? IsAccess { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? IsReadWrite { get; set; }
    }
}
