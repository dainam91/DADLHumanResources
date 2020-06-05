using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class EmplImages
    {
        public int RecId { get; set; }
        public string EmplId { get; set; }
        public byte[] Picture { get; set; }
    }
}
