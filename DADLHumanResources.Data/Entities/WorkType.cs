﻿using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class WorkType
    {
        public int RecId { get; set; }
        public string Worktypeid { get; set; }
        public string Description { get; set; }
        public double? Rate { get; set; }
        public int? Type { get; set; }
        public int? Normalsundayholiday { get; set; }
        public int? Daynight { get; set; }
        public string Vtvabsencecode { get; set; }
        public int? Days { get; set; }
    }
}
