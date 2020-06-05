using System;
using DADLHumanResources.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DADLHumanResources.Data.EF
{
    public partial class DADLHRContext : DbContext
    {
        public DADLHRContext()
        {
        }

        public DADLHRContext(DbContextOptions<DADLHRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActualWorkingHours> ActualWorkingHours { get; set; }
        public virtual DbSet<AttAnnualleaveNotes> AttAnnualleaveNotes { get; set; }
        public virtual DbSet<AttAnnualleaveSummary> AttAnnualleaveSummary { get; set; }
        public virtual DbSet<AttAttendancetrans> AttAttendancetrans { get; set; }
        public virtual DbSet<AttCheckinout> AttCheckinout { get; set; }
        public virtual DbSet<AttColorSetting> AttColorSetting { get; set; }
        public virtual DbSet<AttDisciplinary> AttDisciplinary { get; set; }
        public virtual DbSet<AttDisciplinaryaction> AttDisciplinaryaction { get; set; }
        public virtual DbSet<AttHolidaysDefine> AttHolidaysDefine { get; set; }
        public virtual DbSet<AttJournalTrans> AttJournalTrans { get; set; }
        public virtual DbSet<AttOtcalculator> AttOtcalculator { get; set; }
        public virtual DbSet<AttOtreq> AttOtreq { get; set; }
        public virtual DbSet<AttOtrequestitems> AttOtrequestitems { get; set; }
        public virtual DbSet<AttPeriod> AttPeriod { get; set; }
        public virtual DbSet<AttReqconfig> AttReqconfig { get; set; }
        public virtual DbSet<AttReqfiles> AttReqfiles { get; set; }
        public virtual DbSet<AttReqleave> AttReqleave { get; set; }
        public virtual DbSet<AttReqleaveCalctime> AttReqleaveCalctime { get; set; }
        public virtual DbSet<AttReqleaveDetail> AttReqleaveDetail { get; set; }
        public virtual DbSet<AttReqleaveExtcode> AttReqleaveExtcode { get; set; }
        public virtual DbSet<AttReqleaveHrpost> AttReqleaveHrpost { get; set; }
        public virtual DbSet<AttReqleaveProcesslog> AttReqleaveProcesslog { get; set; }
        public virtual DbSet<AttReqleaveUsers> AttReqleaveUsers { get; set; }
        public virtual DbSet<AttShift> AttShift { get; set; }
        public virtual DbSet<AttShiftDept> AttShiftDept { get; set; }
        public virtual DbSet<AttShiftarrange> AttShiftarrange { get; set; }
        public virtual DbSet<AttShiftarrangeDetail> AttShiftarrangeDetail { get; set; }
        public virtual DbSet<AttShiftrange> AttShiftrange { get; set; }
        public virtual DbSet<AttSuplocation> AttSuplocation { get; set; }
        public virtual DbSet<CompanyInfo> CompanyInfo { get; set; }
        public virtual DbSet<ContractHistory> ContractHistory { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<EmailGroup> EmailGroup { get; set; }
        public virtual DbSet<EmailList> EmailList { get; set; }
        public virtual DbSet<EmplFixedPayCode> EmplFixedPayCode { get; set; }
        public virtual DbSet<EmplImages> EmplImages { get; set; }
        public virtual DbSet<EmplNonFixedPayCode> EmplNonFixedPayCode { get; set; }
        public virtual DbSet<EmplNonFixedPayCodeBk> EmplNonFixedPayCodeBk { get; set; }
        public virtual DbSet<EmplTable> EmplTable { get; set; }
        public virtual DbSet<InsuranceLine> InsuranceLine { get; set; }
        public virtual DbSet<InsuranceTable> InsuranceTable { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<PayCodeTable> PayCodeTable { get; set; }
        public virtual DbSet<PayrollOrgdept> PayrollOrgdept { get; set; }
        public virtual DbSet<PayrollOrglevel> PayrollOrglevel { get; set; }
        public virtual DbSet<PeriodMaster> PeriodMaster { get; set; }
        public virtual DbSet<PitmasterLine> PitmasterLine { get; set; }
        public virtual DbSet<PitmasterTable> PitmasterTable { get; set; }
        public virtual DbSet<SalarySheet> SalarySheet { get; set; }
        public virtual DbSet<SalarySheetDeptGroup> SalarySheetDeptGroup { get; set; }
        public virtual DbSet<SalarySumGroup> SalarySumGroup { get; set; }
        public virtual DbSet<SysEmail> SysEmail { get; set; }
        public virtual DbSet<SysEnumTable> SysEnumTable { get; set; }
        public virtual DbSet<SysGroupTable> SysGroupTable { get; set; }
        public virtual DbSet<SysMenuAccess> SysMenuAccess { get; set; }
        public virtual DbSet<SysMenus> SysMenus { get; set; }
        public virtual DbSet<SysReportInfo> SysReportInfo { get; set; }
        public virtual DbSet<SysTableControlInfo> SysTableControlInfo { get; set; }
        public virtual DbSet<SysTableInfo> SysTableInfo { get; set; }
        public virtual DbSet<SysTemplate> SysTemplate { get; set; }
        public virtual DbSet<SysUserGroup> SysUserGroup { get; set; }
        public virtual DbSet<SysUserTable> SysUserTable { get; set; }
        public virtual DbSet<TempJournal> TempJournal { get; set; }
        public virtual DbSet<TempNonFixedPayCode> TempNonFixedPayCode { get; set; }
        public virtual DbSet<Transferposition> Transferposition { get; set; }
        public virtual DbSet<WorkType> WorkType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=NAV2012\\SQLTEST;Initial Catalog=DADLHR;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActualWorkingHours>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Recid).HasColumnName("RECID");
            });

            modelBuilder.Entity<AttAnnualleaveNotes>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_ANNUALLEAVE_NOTES");

                entity.ToTable("ATT_ANNUALLEAVE_NOTES");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.ColumnsName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.TransId).HasColumnName("TransID");
            });

            modelBuilder.Entity<AttAnnualleaveSummary>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_ANNUALLEAVE_SUMMARY");

                entity.ToTable("ATT_ANNUALLEAVE_SUMMARY");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Almove).HasColumnName("ALMove");

                entity.Property(e => e.Alpay).HasColumnName("ALPay");

                entity.Property(e => e.AlpreviousYear).HasColumnName("ALPreviousYear");

                entity.Property(e => e.AvailableAl).HasColumnName("AvailableAL");

                entity.Property(e => e.DefaultAl).HasColumnName("DefaultAL");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplName).HasMaxLength(100);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PeriodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.TotalAlthisYear).HasColumnName("TotalALThisYear");
            });

            modelBuilder.Entity<AttAttendancetrans>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_ATTENDANCETRANS");

                entity.ToTable("ATT_ATTENDANCETRANS");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckIn).HasColumnType("datetime");

                entity.Property(e => e.CheckOut).HasColumnType("datetime");

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.EmplCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmplPosition).HasMaxLength(100);

                entity.Property(e => e.ExtraOtfrom)
                    .HasColumnName("ExtraOTFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtraOtto)
                    .HasColumnName("ExtraOTTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.Otfrom)
                    .HasColumnName("OTFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otto)
                    .HasColumnName("OTTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.Period).HasMaxLength(10);

                entity.Property(e => e.Shift).HasMaxLength(6);

                entity.Property(e => e.WeeklyShift)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType).HasMaxLength(10);
            });

            modelBuilder.Entity<AttCheckinout>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ATT_CHECKINOUT");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckIn).HasColumnType("datetime");

                entity.Property(e => e.CheckOut).HasColumnType("datetime");

                entity.Property(e => e.DayOff)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.LaterIn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasMaxLength(200);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeeklyShift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttColorSetting>(entity =>
            {
                entity.HasKey(e => e.ColorDefine);

                entity.ToTable("ATT_ColorSetting");

                entity.Property(e => e.ColorDefine)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttDisciplinary>(entity =>
            {
                entity.HasKey(e => e.Recid)
                    .HasName("PK_DADL_DISCIPLINARY");

                entity.ToTable("ATT_DISCIPLINARY");

                entity.Property(e => e.Recid)
                    .HasColumnName("RECID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Department)
                    .HasColumnName("DEPARTMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.Disciplinaryaction)
                    .HasColumnName("DISCIPLINARYACTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Effectdate)
                    .HasColumnName("EFFECTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Emplid)
                    .HasColumnName("EMPLID")
                    .HasMaxLength(10);

                entity.Property(e => e.Misconduct)
                    .HasColumnName("MISCONDUCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.Sanction)
                    .HasColumnName("SANCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Starteddate)
                    .HasColumnName("STARTEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Violationdate)
                    .HasColumnName("VIOLATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Violationdetail)
                    .HasColumnName("VIOLATIONDETAIL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AttDisciplinaryaction>(entity =>
            {
                entity.HasKey(e => e.Recid)
                    .HasName("PK_DADL_DISCIPLINARYACTION");

                entity.ToTable("ATT_DISCIPLINARYACTION");

                entity.Property(e => e.Recid)
                    .HasColumnName("RECID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Disciplinaryaction)
                    .HasColumnName("DISCIPLINARYACTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AttHolidaysDefine>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("ATT_HolidaysDefine");

                entity.Property(e => e.Recid)
                    .HasColumnName("RECID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Holiday).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttJournalTrans>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.Property(e => e.Recid)
                    .HasColumnName("RECID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Confirmed).HasColumnName("CONFIRMED");

                entity.Property(e => e.Emplid)
                    .IsRequired()
                    .HasColumnName("EMPLID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasColumnName("HOURS")
                    .HasColumnType("numeric(28, 2)");

                entity.Property(e => e.Journalnum)
                    .IsRequired()
                    .HasColumnName("JOURNALNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnName("REMARKS")
                    .HasMaxLength(250);

                entity.Property(e => e.Transdate)
                    .HasColumnName("TRANSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Worktypeid)
                    .IsRequired()
                    .HasColumnName("WORKTYPEID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttOtcalculator>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ATT_OTCALCULATOR");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromTime)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ho1).HasColumnName("HO1");

                entity.Property(e => e.Ho2).HasColumnName("HO2");

                entity.Property(e => e.Ho3).HasColumnName("HO3");

                entity.Property(e => e.Ndo).HasColumnName("NDO");

                entity.Property(e => e.Nno).HasColumnName("NNO");

                entity.Property(e => e.OtrequestNo)
                    .HasColumnName("OTRequestNo")
                    .HasMaxLength(20);

                entity.Property(e => e.Sdo1).HasColumnName("SDO1");

                entity.Property(e => e.Sdo2).HasColumnName("SDO2");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToTime)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Transdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttOtreq>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ATT_OTREQ");

                entity.HasIndex(e => e.OtrequestNo)
                    .HasName("UQ_ATT_OTREQ")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtfromDate)
                    .HasColumnName("OTFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtrequestNo)
                    .IsRequired()
                    .HasColumnName("OTRequestNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OttoDate)
                    .HasColumnName("OTToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Purpose).HasMaxLength(255);

                entity.Property(e => e.RequestBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttOtrequestitems>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ATT_OTREQUESTITEMS");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OtrequestNo)
                    .IsRequired()
                    .HasColumnName("OTRequestNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.OtrequestNoNavigation)
                    .WithMany(p => p.AttOtrequestitems)
                    .HasPrincipalKey(p => p.OtrequestNo)
                    .HasForeignKey(d => d.OtrequestNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATT_OTREQ_ATT_OTREQUESTITEMS");
            });

            modelBuilder.Entity<AttPeriod>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ATT_PERIOD");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodName).HasMaxLength(10);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttReqconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATT_REQCONFIG");

                entity.Property(e => e.UploadPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeNeedNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttReqfiles>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_REQFILES");

                entity.ToTable("ATT_REQFILES");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttReqleave>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_RequestForLeave");

                entity.ToTable("ATT_REQLEAVE");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .IsRequired()
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pcname)
                    .HasColumnName("PCName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("RequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedName).HasMaxLength(100);

                entity.Property(e => e.UpdatedUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<AttReqleaveCalctime>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_RequestForLeave_TimeLog");

                entity.ToTable("ATT_REQLEAVE_CALCTIME");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.ApprovedByHr).HasColumnName("ApprovedByHR");

                entity.Property(e => e.DiscriplinaryId).HasColumnName("DiscriplinaryID");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HrfeedBack)
                    .HasColumnName("HRFeedBack")
                    .HasMaxLength(255);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.RejectedByHr).HasColumnName("RejectedByHR");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttReqleaveDetail>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_RequestForLeaveDetail");

                entity.ToTable("ATT_REQLEAVE_DETAIL");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateReturn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToTime).HasColumnType("datetime");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttReqleaveExtcode>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_REQTRAININGCODE");

                entity.ToTable("ATT_REQLEAVE_EXTCODE");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplName).HasMaxLength(255);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OwnerID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttReqleaveHrpost>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_REQLEAVE_HRPOST");

                entity.ToTable("ATT_REQLEAVE_HRPOST");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedByHr).HasColumnName("ApprovedByHR");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedName).HasMaxLength(100);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscriplinaryId).HasColumnName("DiscriplinaryID");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplName).HasMaxLength(100);

                entity.Property(e => e.FeedBack).HasMaxLength(255);

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.RejectedByHr).HasColumnName("RejectedByHR");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.ToTime).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttReqleaveProcesslog>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ATT_REQLEAVE_PROCESSLOG");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttReqleaveUsers>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_RequestForLeaveUser");

                entity.ToTable("ATT_REQLEAVE_USERS");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Depts)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DomainUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplName).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATT_SHIFT");

                entity.Property(e => e.ShiftType)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.TimeIn).HasMaxLength(5);

                entity.Property(e => e.TimeOut).HasMaxLength(5);
            });

            modelBuilder.Entity<AttShiftDept>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("ATT_ShiftDept");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.SortId).HasColumnName("SortID");
            });

            modelBuilder.Entity<AttShiftarrange>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_SHIFTARRANGE");

                entity.ToTable("ATT_SHIFTARRANGE");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.DefaultDayOff)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplName).HasMaxLength(100);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttShiftarrangeDetail>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_SHIFTARRANGE_DETAIL");

                entity.ToTable("ATT_SHIFTARRANGE_DETAIL");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttShiftrange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATT_SHIFTRANGE");

                entity.Property(e => e.AfterIn).HasMaxLength(5);

                entity.Property(e => e.AfterOut).HasMaxLength(5);

                entity.Property(e => e.BeforeIn).HasMaxLength(5);

                entity.Property(e => e.BeforeOut)
                    .HasColumnName("BeforeOUt")
                    .HasMaxLength(5);

                entity.Property(e => e.ShiftType)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttSuplocation>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DADL_SUPLOCATION");

                entity.ToTable("ATT_SUPLOCATION");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupId)
                    .HasColumnName("SupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyInfo>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FieldName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValueEn).HasMaxLength(250);

                entity.Property(e => e.ValueVn).HasMaxLength(250);
            });

            modelBuilder.Entity<ContractHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BeginContract).HasColumnType("datetime");

                entity.Property(e => e.EmplId)
                    .IsRequired()
                    .HasColumnName("EmplID")
                    .HasMaxLength(10);

                entity.Property(e => e.ExpireContract).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.TimeSpanId).HasColumnName("TimeSpanID");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName).HasMaxLength(255);
            });

            modelBuilder.Entity<EmailGroup>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmailContent).HasMaxLength(4000);

                entity.Property(e => e.EmailTitle).HasMaxLength(250);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailList>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailGroupId)
                    .HasColumnName("EmailGroupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmplFixedPayCode>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.PayCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmplImages>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<EmplNonFixedPayCode>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .IsRequired()
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PayCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmplNonFixedPayCodeBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmplNonFixedPayCode_bk");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmplId)
                    .IsRequired()
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PayCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EmplTable>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Allowance).HasDefaultValueSql("((0))");

                entity.Property(e => e.AtBank).HasMaxLength(100);

                entity.Property(e => e.AtBank1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccNo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeginningDate).HasColumnType("datetime");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Education).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact).HasMaxLength(100);

                entity.Property(e => e.EmplId)
                    .IsRequired()
                    .HasColumnName("EmplID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndMaternityLeave).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.HaveBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Insurance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedPlace).HasMaxLength(100);

                entity.Property(e => e.Level).HasMaxLength(100);

                entity.Property(e => e.MaternityLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.NationalRegion).HasMaxLength(50);

                entity.Property(e => e.NativeCountry).HasMaxLength(50);

                entity.Property(e => e.NettCalculation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.NumOfDependencies).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherGovDeduction).HasDefaultValueSql("((0))");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress).HasMaxLength(255);

                entity.Property(e => e.PickUpPoint).HasMaxLength(100);

                entity.Property(e => e.Pit)
                    .HasColumnName("PIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.Relationship).HasMaxLength(100);

                entity.Property(e => e.ResignationDate).HasColumnType("datetime");

                entity.Property(e => e.Resigned).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnMedicalCard).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalaryOffer).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartMaternityLeave).HasColumnType("datetime");

                entity.Property(e => e.StartedDate).HasColumnType("datetime");

                entity.Property(e => e.Tell)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemporaryAddress).HasMaxLength(255);

                entity.Property(e => e.TotalHoursPeriod).HasDefaultValueSql("((208))");

                entity.Property(e => e.TradeUnionFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkingDayWeek)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceLine>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Basicsalaryallowance).HasColumnName("BASICSALARYALLOWANCE");

                entity.Property(e => e.Hrminsurancepayedby).HasColumnName("HRMINSURANCEPAYEDBY");

                entity.Property(e => e.Insurancecode)
                    .IsRequired()
                    .HasColumnName("INSURANCECODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Percent).HasColumnName("PERCENT_");
            });

            modelBuilder.Entity<InsuranceTable>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Currencycode)
                    .IsRequired()
                    .HasColumnName("CURRENCYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Insurancecode)
                    .IsRequired()
                    .HasColumnName("INSURANCECODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Insurancetype).HasColumnName("INSURANCETYPE");

                entity.Property(e => e.Maximumabsenceexceptiondays).HasColumnName("MAXIMUMABSENCEEXCEPTIONDAYS");

                entity.Property(e => e.Maximumbaseamountcur).HasColumnName("MAXIMUMBASEAMOUNTCUR");

                entity.Property(e => e.Minimumjoindays).HasColumnName("MINIMUMJOINDAYS");

                entity.Property(e => e.Paycode)
                    .IsRequired()
                    .HasColumnName("PAYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PayCodeTable>(entity =>
            {
                entity.HasKey(e => e.Recid)
                    .HasName("PK_PayCode");

                entity.HasIndex(e => e.Paycode)
                    .HasName("NonClustered_PAYCODE")
                    .IsUnique();

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Attendancedays)
                    .HasColumnName("ATTENDANCEDAYS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Fixedorattendancebase).HasColumnName("FIXEDORATTENDANCEBASE");

                entity.Property(e => e.Ifsintegration).HasColumnName("IFSINTEGRATION");

                entity.Property(e => e.Includeincost).HasColumnName("INCLUDEINCOST");

                entity.Property(e => e.Ledgeraccount)
                    .HasColumnName("LEDGERACCOUNT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nettcalculation).HasColumnName("NETTCALCULATION");

                entity.Property(e => e.Noncashallowance).HasColumnName("NONCASHALLOWANCE");

                entity.Property(e => e.Nontaxable).HasColumnName("NONTAXABLE");

                entity.Property(e => e.Nontaxablepercent)
                    .HasColumnName("NONTAXABLEPERCENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Offsetledgeraccount)
                    .HasColumnName("OFFSETLEDGERACCOUNT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Paycode)
                    .IsRequired()
                    .HasColumnName("PAYCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Paycodeunit).HasColumnName("PAYCODEUNIT");

                entity.Property(e => e.Paytype).HasColumnName("PAYTYPE");

                entity.Property(e => e.Taxablepercent)
                    .HasColumnName("TAXABLEPERCENT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollOrgdept>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_PAYROLL_ORGCHART");

                entity.ToTable("PAYROLL_ORGDEPT");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<PayrollOrglevel>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("PAYROLL_ORGLEVEL");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelName).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<PeriodMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Fromdate)
                    .HasColumnName("FROMDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasColumnName("NUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payperiodcode)
                    .IsRequired()
                    .HasColumnName("PAYPERIODCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payperiodtype)
                    .IsRequired()
                    .HasColumnName("PAYPERIODTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Todate)
                    .HasColumnName("TODATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PitmasterLine>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("PITMasterLine");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Lowboundary)
                    .HasColumnName("LOWBOUNDARY")
                    .HasColumnType("numeric(28, 12)");

                entity.Property(e => e.Pitcode)
                    .IsRequired()
                    .HasColumnName("PITCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Taxdeduction)
                    .HasColumnName("TAXDEDUCTION")
                    .HasColumnType("numeric(28, 12)");

                entity.Property(e => e.Taxrate)
                    .HasColumnName("TAXRATE")
                    .HasColumnType("numeric(28, 12)");

                entity.Property(e => e.Upboundary)
                    .HasColumnName("UPBOUNDARY")
                    .HasColumnType("numeric(28, 12)");
            });

            modelBuilder.Entity<PitmasterTable>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("PITMasterTable");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Companypaycode)
                    .IsRequired()
                    .HasColumnName("COMPANYPAYCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Fromdate)
                    .HasColumnName("FROMDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nodeduction).HasColumnName("NODEDUCTION");

                entity.Property(e => e.Paycode)
                    .IsRequired()
                    .HasColumnName("PAYCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcode)
                    .IsRequired()
                    .HasColumnName("PITCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Todate)
                    .HasColumnName("TODATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SalarySheet>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bhtn).HasColumnName("BHTN");

                entity.Property(e => e.BhtnComp).HasColumnName("BHTN_COMP");

                entity.Property(e => e.Bhxh).HasColumnName("BHXH");

                entity.Property(e => e.BhxhComp).HasColumnName("BHXH_COMP");

                entity.Property(e => e.Bhyt).HasColumnName("BHYT");

                entity.Property(e => e.BhytComp).HasColumnName("BHYT_COMP");

                entity.Property(e => e.Department)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeptFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmplLevel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName).HasMaxLength(200);

                entity.Property(e => e.HdoNoTax400).HasColumnName("HDO_NoTax400");

                entity.Property(e => e.HdodNoTax200).HasColumnName("HDOD_NoTax200");

                entity.Property(e => e.HdodTax100).HasColumnName("HDOD_Tax100");

                entity.Property(e => e.HdonNoTax250).HasColumnName("HDON_NoTax250");

                entity.Property(e => e.HdonTax100).HasColumnName("HDON_Tax100");

                entity.Property(e => e.NdoNoTax50).HasColumnName("NDO_NoTax50");

                entity.Property(e => e.NdoTax100).HasColumnName("NDO_Tax100");

                entity.Property(e => e.NnoNoTax100).HasColumnName("NNO_NoTax100");

                entity.Property(e => e.NnoTax100).HasColumnName("NNO_Tax100");

                entity.Property(e => e.PayPeriodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasMaxLength(200);

                entity.Property(e => e.SdodNoTax100).HasColumnName("SDOD_NoTax100");

                entity.Property(e => e.SdodTax100).HasColumnName("SDOD_Tax100");

                entity.Property(e => e.SdonNoTax170).HasColumnName("SDON_NoTax170");

                entity.Property(e => e.SdonTax100).HasColumnName("SDON_Tax100");

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubLevel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TradeUnionFeeComp).HasColumnName("TradeUnionFee_COMP");

                entity.Property(e => e.WorkStartingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalarySheetDeptGroup>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Deptid)
                    .HasColumnName("DEPTID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deptname)
                    .HasColumnName("DEPTNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalarySumGroup>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysEmail>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_EMAIL");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPass)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailId)
                    .HasColumnName("MailID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysEnumTable>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_EnumTable");

                entity.ToTable("SYS_EnumTable");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.DisplayMember)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayMemberVn)
                    .HasColumnName("DisplayMemberVN")
                    .HasMaxLength(100);

                entity.Property(e => e.EnumId)
                    .HasColumnName("EnumID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValueMember)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysGroupTable>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_GroupTable");

                entity.ToTable("SYS_GroupTable");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName).HasMaxLength(100);
            });

            modelBuilder.Entity<SysMenuAccess>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_MenuAccess");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.AccessInfo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysMenus>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_Menus");

                entity.HasIndex(e => e.MenuId)
                    .HasName("NonClustered_MenuID")
                    .IsUnique();

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.MenuParentId).HasColumnName("MenuParentID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<SysReportInfo>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_ReportInfo");

                entity.HasIndex(e => new { e.ReportName, e.FieldName })
                    .HasName("uq_ReportName_FieldName")
                    .IsUnique();

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExcelColumnName)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ExcelFormulas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldControlType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FieldFormat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldTitle).HasMaxLength(50);

                entity.Property(e => e.FieldType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FieldWidth).HasDefaultValueSql("((100))");

                entity.Property(e => e.FreezeColumn).HasDefaultValueSql("((0))");

                entity.Property(e => e.HideByUsers)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReadOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReadOnlyByUsers)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Visible).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysTableControlInfo>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_TableControlInfo");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GroupTitle).HasMaxLength(50);

                entity.Property(e => e.TabName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysTableInfo>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_TableInfo");

                entity.HasIndex(e => new { e.TableName, e.FieldName })
                    .HasName("uq_TableName_FieldName")
                    .IsUnique();

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.FieldControlType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('textbox')");

                entity.Property(e => e.FieldFormat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldTitle).HasMaxLength(50);

                entity.Property(e => e.FieldType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FieldWidth).HasDefaultValueSql("((100))");

                entity.Property(e => e.FreezeColumn).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupControl)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HideByUsers)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReadOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReadOnlyByUsers)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TabName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Visible).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysTemplate>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SYS_TEMPLATE");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysUserGroup>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_UserGroup");

                entity.ToTable("SYS_UserGroup");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName).HasMaxLength(100);
            });

            modelBuilder.Entity<SysUserTable>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_UserTable");

                entity.ToTable("SYS_UserTable");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.DomainUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TempJournal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Journal");

                entity.Property(e => e.AttendanceDate)
                    .HasColumnName("Attendance date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Employee).HasMaxLength(255);

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("Journal number")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkType)
                    .HasColumnName("Work type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TempNonFixedPayCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_NonFixedPayCode");

                entity.Property(e => e.AmountCurrency).HasColumnName("Amount currency");

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.Employee).HasMaxLength(255);

                entity.Property(e => e.PayCode)
                    .HasColumnName("Pay Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PayPeriodCode)
                    .HasColumnName("Pay Period Code")
                    .HasMaxLength(255);

                entity.Property(e => e.PeriodType)
                    .HasColumnName("Period Type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Transferposition>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("TRANSFERPOSITION");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.CurrentDept).HasMaxLength(50);

                entity.Property(e => e.CurrentPosition).HasMaxLength(50);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasMaxLength(5);

                entity.Property(e => e.NewDept).HasMaxLength(50);

                entity.Property(e => e.NewPosition).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.ProbationPeriod).HasMaxLength(200);

                entity.Property(e => e.Trainer).HasMaxLength(100);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkType>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Daynight).HasColumnName("DAYNIGHT");

                entity.Property(e => e.Days).HasColumnName("DAYS");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Normalsundayholiday).HasColumnName("NORMALSUNDAYHOLIDAY");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Vtvabsencecode)
                    .HasColumnName("VTVABSENCECODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Worktypeid)
                    .HasColumnName("WORKTYPEID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
