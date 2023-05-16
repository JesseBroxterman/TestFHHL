using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels.Configuration
{
    public class CaregiverEntityConfiguration : IEntityTypeConfiguration<Caregiver>
    {
        public void Configure(EntityTypeBuilder<Caregiver> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnType("integer")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                .HasColumnType("nvarchar(256)")
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasColumnType("nvarchar(256)")
                .IsRequired();

            builder.Property(p => p.FullName)
                .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");

            builder.Property(p => p.Zip)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.DateOfBirth)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.MomClass)
                .HasColumnType("bit");

            builder.Property(p => p.Spanish)
                .HasColumnType("bit");

            builder.Property(p => p.Foster)
                  .HasColumnType("bit");

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
        }
    }
}
