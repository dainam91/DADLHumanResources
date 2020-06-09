using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysEnumTable
    {
        public int RecId { get; set; }
        public string EnumId { get; set; }
        public string ValueType { get; set; }
        public string ValueMember { get; set; }
        public string DisplayMember { get; set; }
        public string DisplayMemberVn { get; set; }
    }
}
