using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities 
{
    public partial class AttDisciplinary
    {
        public long Recid { get; set; }
        public string Emplid { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime? Starteddate { get; set; }
        public DateTime? Violationdate { get; set; }
        public string Violationdetail { get; set; }
        public string Description { get; set; }
        public string Misconduct { get; set; }
        public string Disciplinaryaction { get; set; }
        public string Sanction { get; set; }
        public DateTime? Effectdate { get; set; }
        public string Remarks { get; set; }
    }
}
