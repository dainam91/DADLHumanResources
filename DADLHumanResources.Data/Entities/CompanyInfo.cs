using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class CompanyInfo
    {
        public int RecId { get; set; }
        public string FieldName { get; set; }
        public string ValueEn { get; set; }
        public string ValueVn { get; set; }
    }
}
