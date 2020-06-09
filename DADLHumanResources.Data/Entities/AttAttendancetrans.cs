using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities 
{
    public partial class AttAttendancetrans
    {
        public long RecId { get; set; }
        public string Period { get; set; }
        public string EmplCode { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }
        public string EmplPosition { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string Shift { get; set; }
        public string WeeklyShift { get; set; }
        public bool? DayOff { get; set; }
        public string WorkType { get; set; }
        public double? OffHour { get; set; }
        public DateTime? Otfrom { get; set; }
        public DateTime? Otto { get; set; }
        public DateTime? ExtraOtfrom { get; set; }
        public DateTime? ExtraOtto { get; set; }
        public double? Total { get; set; }
        public double? Normal150 { get; set; }
        public double? NormalNight180 { get; set; }
        public double? Sun200 { get; set; }
        public double? SunNight230 { get; set; }
        public double? Holiday300 { get; set; }
        public double? HolidayNight330 { get; set; }
        public double? HolidayOver8Hour400 { get; set; }
        public string Notes { get; set; }
    }
}
