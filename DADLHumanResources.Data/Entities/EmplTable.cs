using System;
using System.Collections.Generic;

namespace DADLHumanResources.Data.Entities
{
    public partial class EmplTable
    {
        public int RecId { get; set; }
        public string EmplId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string DeptId { get; set; }
        public string Level { get; set; }
        public int ForeignLocal { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? Dob { get; set; }
        public string PlaceOfBirth { get; set; }
        public string NativeCountry { get; set; }
        public string NationalRegion { get; set; }
        public string Gender { get; set; }
        public string PassportNo { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string IssuedPlace { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public string Education { get; set; }
        public string PickUpPoint { get; set; }
        public string BankAccNo { get; set; }
        public string AtBank { get; set; }
        public string BankAccNo1 { get; set; }
        public string AtBank1 { get; set; }
        public string WorkingDayWeek { get; set; }
        public int TotalHoursPeriod { get; set; }
        public DateTime? BeginningDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string ContractType { get; set; }
        public double? SalaryOffer { get; set; }
        public double? ContractSalary { get; set; }
        public double? Allowance { get; set; }
        public string Contact { get; set; }
        public string EmergencyContact { get; set; }
        public string Relationship { get; set; }
        public string Tell { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string Pit { get; set; }
        public bool? NettCalculation { get; set; }
        public bool? TradeUnionFee { get; set; }
        public bool? Insurance { get; set; }
        public bool? ReturnMedicalCard { get; set; }
        public int? NumOfDependencies { get; set; }
        public bool? OtherGovDeduction { get; set; }
        public bool? HaveBonus { get; set; }
        public bool? MaternityLeave { get; set; }
        public DateTime? StartMaternityLeave { get; set; }
        public DateTime? EndMaternityLeave { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string Reason { get; set; }
        public bool? Resigned { get; set; }
    }
}
