using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysMenus
    {
        public int RecId { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public int? ParentId { get; set; }
        public int? MenuParentId { get; set; }
        public bool? IsNavGroup { get; set; }
        public bool? IsNavBand { get; set; }
        public int? SortIndex { get; set; }
    }
}
