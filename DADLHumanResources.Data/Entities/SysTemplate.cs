using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SysTemplate
    {
        public int RecId { get; set; }
        public string FileId { get; set; }
        public byte[] FileData { get; set; }
    }
}
