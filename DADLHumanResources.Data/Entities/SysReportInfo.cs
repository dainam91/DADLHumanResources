using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysReportInfo
    {
        public int RecId { get; set; }
        public string ReportName { get; set; }
        public string FieldName { get; set; }
        public string FieldTitle { get; set; }
        public string FieldType { get; set; }
        public string FieldControlType { get; set; }
        public string FieldFormat { get; set; }
        public int? FieldWidth { get; set; }
        public bool? ReadOnly { get; set; }
        public string HideByUsers { get; set; }
        public string ReadOnlyByUsers { get; set; }
        public bool? FreezeColumn { get; set; }
        public string ExcelColumnName { get; set; }
        public string ExcelFormulas { get; set; }
        public bool? Visible { get; set; }
        public bool? Active { get; set; }
        public int? SortIndex { get; set; }
    }
}
