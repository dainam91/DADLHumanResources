using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttAnnualleaveNotes
    {
        public int RecId { get; set; }
        public int? TransId { get; set; }
        public string ColumnsName { get; set; }
        public string Notes { get; set; }
    }
}
