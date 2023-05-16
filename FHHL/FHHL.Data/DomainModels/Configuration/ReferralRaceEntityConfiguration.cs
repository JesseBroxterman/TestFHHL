using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels.Configuration
{
    public class ReferralRaceEntityConfiguration : IEntityTypeConfiguration<ReferralRace>
    {
        public void Configure(EntityTypeBuilder<ReferralRace> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnType("integer")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ReferralId)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(p => p.RaceId)
                .HasColumnType("integer")
                .IsRequired();

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Referral).WithMany(p => p.ReferralRaces);

            builder.HasOne(p => p.Race);

        }
    }
}
