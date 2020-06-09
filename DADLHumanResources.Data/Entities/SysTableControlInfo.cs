using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysTableControlInfo
    {
        public int RecId { get; set; }
        public string TableName { get; set; }
        public string TabName { get; set; }
        public string GroupName { get; set; }
        public string GroupTitle { get; set; }
    }
}
