using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class SalarySheet
    {
        public long RecId { get; set; }
        public string PayPeriodCode { get; set; }
        public string StaffCode { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string DeptFunction { get; set; }
        public string SubFunction { get; set; }
        public string EmplLevel { get; set; }
        public string SubLevel { get; set; }
        public DateTime? WorkStartingDate { get; set; }
        public double? GrossBasicSalary { get; set; }
        public double? OtherAllowances { get; set; }
        public double? FuelAllowances { get; set; }
        public double? TotalGrossSalary { get; set; }
        public double? NormalWorkingDays { get; set; }
        public double? AnnualLeaveHours { get; set; }
        public double? FullPaidLeaveHours { get; set; }
        public double? SickLeaveHours { get; set; }
        public double? UnpaidLeaveHours { get; set; }
        public double? ActualNormalWorkingHours { get; set; }
        public double? AnnualLeaveIncome { get; set; }
        public double? FullPaidLeaveIncome { get; set; }
        public double? SickLeaveDeduction { get; set; }
        public double? UnpaidLeaveDeduction { get; set; }
        public double? NormalWorkingDaysIncome { get; set; }
        public double? NdoTax100 { get; set; }
        public double? NdoNoTax50 { get; set; }
        public double? NnoTax100 { get; set; }
        public double? NnoNoTax100 { get; set; }
        public double? SdodTax100 { get; set; }
        public double? SdodNoTax100 { get; set; }
        public double? SdonTax100 { get; set; }
        public double? SdonNoTax170 { get; set; }
        public double? HdodTax100 { get; set; }
        public double? HdodNoTax200 { get; set; }
        public double? HdonTax100 { get; set; }
        public double? HdonNoTax250 { get; set; }
        public double? HdoNoTax400 { get; set; }
        public double? NightShift { get; set; }
        public double? TrainingBonus { get; set; }
        public double? RetentionBonus { get; set; }
        public double? AdjustmentBeforeTax { get; set; }
        public double? TotalIncome { get; set; }
        public double? Bhxh { get; set; }
        public double? Bhyt { get; set; }
        public double? Bhtn { get; set; }
        public double? TaxableIncome { get; set; }
        public double? NumberOfDependant { get; set; }
        public double? PersonalAndDependantDeduction { get; set; }
        public double? PersonalIncomeTax { get; set; }
        public double? AdjustmentAfterTax { get; set; }
        public double? TradeUnionFee { get; set; }
        public double? NetTakeHome { get; set; }
        public double? BhxhComp { get; set; }
        public double? BhytComp { get; set; }
        public double? BhtnComp { get; set; }
        public double? TradeUnionFeeComp { get; set; }
        public double? TotalCostsToEmployer { get; set; }
    }
}
