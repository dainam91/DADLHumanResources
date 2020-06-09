using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysTableInfo
    {
        public int RecId { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string FieldTitle { get; set; }
        public string FieldType { get; set; }
        public string FieldFormat { get; set; }
        public int? FieldWidth { get; set; }
        public bool? ReadOnly { get; set; }
        public string FieldControlType { get; set; }
        public string GroupControl { get; set; }
        public string TabName { get; set; }
        public string HideByUsers { get; set; }
        public string ReadOnlyByUsers { get; set; }
        public bool? FreezeColumn { get; set; }
        public int? SortIndex { get; set; }
        public bool? Visible { get; set; }
        public bool? Active { get; set; }
    }
}
