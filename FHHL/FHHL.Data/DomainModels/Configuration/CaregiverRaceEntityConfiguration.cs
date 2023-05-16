using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels.Configuration
{
    class CaregiverRaceEntityConfiguration : IEntityTypeConfiguration<CaregiverRace>
    {
        public void Configure(EntityTypeBuilder<CaregiverRace> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnType("integer")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.CaregiverId)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(p => p.RaceId)
                .HasColumnType("integer")
                .IsRequired();

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Caregiver).WithMany(p => p.CaregiverRaces);

            builder.HasOne(p => p.Race);

        }

    }
}
