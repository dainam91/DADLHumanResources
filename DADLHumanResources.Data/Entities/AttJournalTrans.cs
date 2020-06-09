using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttJournalTrans
    {
        public int Recid { get; set; }
        public string Journalnum { get; set; }
        public string Worktypeid { get; set; }
        public string Emplid { get; set; }
        public DateTime? Transdate { get; set; }
        public decimal? Hours { get; set; }
        public string Remarks { get; set; }
        public bool Confirmed { get; set; }
    }
}
