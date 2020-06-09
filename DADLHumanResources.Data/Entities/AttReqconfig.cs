using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class AttReqconfig
    {
        public string WorkTypeNeedNotes { get; set; }
        public int? LimitLeavePerDept { get; set; }
        public int? BeginDayNum { get; set; }
        public int? LimitDayOff { get; set; }
        public string UploadPath { get; set; }
    }
}
