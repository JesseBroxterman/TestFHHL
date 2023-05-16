using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels.Configuration
{
    public class ReferralEntityConfiguration: IEntityTypeConfiguration<Referral>
    {
        public void Configure(EntityTypeBuilder<Referral> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnType("integer")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.CaregiverId)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(p => p.AssignedTo)
                .HasColumnType("integer");       

            builder.Property(p => p.EstimatedDeliveryDate)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.ReferralDate)
                .HasColumnType("datetimeoffset(7)")
                .IsRequired();

            builder.Property(p => p.FirstChild)
                .HasColumnType("bit");

            builder.Property(p => p.FtoF)
                .HasColumnType("bit");

            builder.Property(p => p.Type)
                .HasColumnType("integer");

            builder.Property(p => p.LOR)
                .HasColumnType("integer");

            builder.Property(p => p.Program)
                .HasColumnType("integer");

            builder.Property(p => p.ChildName)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.ChildDateOfBirth)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.ReferralReason)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.AssignDate)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.Result)
                .HasColumnType("integer");

            builder.Property(p => p.ResultDate)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.Notes)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.AddUser)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.AddDateTimeOffset)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.ChgUser)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.ChgDateTimeOffset)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.DelUser)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.DelDateTimeOffset)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.DelFlag)
                .HasColumnType("bit");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Caregiver).WithMany(p => p.Referrals);
        }

    }
}
