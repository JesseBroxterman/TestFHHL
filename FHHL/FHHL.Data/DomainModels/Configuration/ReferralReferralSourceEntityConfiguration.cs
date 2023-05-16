using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels.Configuration
{
    class ReferralReferralSourceEntityConfiguration : IEntityTypeConfiguration<ReferralReferralSource>
    {
        public void Configure(EntityTypeBuilder<ReferralReferralSource> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnType("integer")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ReferralId)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(p => p.ReferralSourceId)
                .HasColumnType("integer")
                .IsRequired();

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Referral).WithMany(p => p.ReferralReferralSources);

            builder.HasOne(p => p.ReferralSource);

        }

    }
}
