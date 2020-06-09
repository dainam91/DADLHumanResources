using DADLHumanResources.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DADLHumanResources.Data.Configurations
{
    public class WorkTypeConfiguration : IEntityTypeConfiguration<WorkType>
    {
        public void Configure(EntityTypeBuilder<WorkType> builder)
        {
            builder.ToTable("WorkType");
            builder.HasKey(x => x.RecId);
            builder.Property(x => x.RecId).HasColumnName("RecId");
            builder.Property(x => x.Daynight).HasColumnName("DAYNIGHT");
            builder.Property(x => x.Days).HasColumnName("DAYS");
            builder.Property(x => x.Description).HasColumnName("DESCRIPTION")
                                                .HasMaxLength(50)
                                                .IsUnicode(false);
            builder.Property(x => x.Normalsundayholiday).HasColumnName("NORMALSUNDAYHOLIDAY");
            builder.Property(x => x.Rate).HasColumnName("RATE");
            builder.Property(x => x.Type).HasColumnName("TYPE");
            builder.Property(x => x.Vtvabsencecode).HasColumnName("VTVABSENCECODE")
                                                   .HasMaxLength(10)
                                                   .IsUnicode(false);
            builder.Property(x => x.Worktypeid).HasColumnName("WORKTYPEID")
                                               .HasMaxLength(20)
                                               .IsUnicode(false);
            builder.HasOne(x => x.AppUser).WithMany(x => x.WorkTypes).HasForeignKey(x => x.UserId);
            

        }
    }
}
