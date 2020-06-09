using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqfiles
    {
        public int RecId { get; set; }
        public string RequestId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string FileExt { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    }
}
