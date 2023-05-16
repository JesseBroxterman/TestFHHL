﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels.Configuration
{
    public class RaceEntityConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.Property(p => p.Id)
                 .HasColumnType("integer")
                 .IsRequired()
                 .ValueGeneratedOnAdd();

            builder.Property(p => p.Label)
                .HasColumnType("nvarchar(256)")
                .IsRequired();

            builder.Property(p => p.AddUser)
                .HasColumnType("nvarchar(256)")
                .IsRequired();

            builder.Property(p => p.AddDateTimeOffset)
                .HasColumnType("datetimeoffset(7)")
                .IsRequired();

            builder.Property(p => p.ChgUser)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.ChgDateTimeOffset)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.DelUser)
                .HasColumnType("nvarchar(256)");

            builder.Property(p => p.DelDateTimeOffset)
                .HasColumnType("datetimeoffset(7)");

            builder.Property(p => p.DelFlag)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(p => p.ActiveFlag)
                .HasColumnType("bit")
                .IsRequired();

            builder.HasKey(p => p.Id);
        }
    }
}
