using FHHL.Data.DomainModels;
using FHHL.Data.DomainModels.Configuration;
using FHHL.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.Context
{
    public class FHHLDbContext : DbContext
    {
        public DbSet<Assignee> Assignees { get; set; }
        public DbSet<Caregiver> Caregivers { get; set; }
        public DbSet<CaregiverRace> CaregiverRaces { get; set; }
        public DbSet<PregnancyState> PregnancyStates { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<ReferralRace> ReferralRaces { get; set; }
        public DbSet<ReferralReferralSource> ReferralReferralSources { get; set; }
        public DbSet<ReferralSource> ReferralSources { get; set; }
        public DbSet<RiskLevel> RiskLevels { get; set; }
        public DbSet<VisitResult> VisitResults { get; set; }


        public FHHLDbContext(DbContextOptions<FHHLDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AssigneeEntityConfiguration());
            builder.ApplyConfiguration(new CaregiverEntityConfiguration());
            builder.ApplyConfiguration(new CaregiverRaceEntityConfiguration());
            builder.ApplyConfiguration(new PregnancyStateEntityConfiguration());
            builder.ApplyConfiguration(new ProgramEntityConfiguration());
            builder.ApplyConfiguration(new RaceEntityConfiguration());
            builder.ApplyConfiguration(new ReferralEntityConfiguration());
            builder.ApplyConfiguration(new ReferralRaceEntityConfiguration());
            builder.ApplyConfiguration(new ReferralReferralSourceEntityConfiguration());
            builder.ApplyConfiguration(new ReferralSourceEntityConfiguration());
            builder.ApplyConfiguration(new RiskLevelEntityConfiguration());
            builder.ApplyConfiguration(new VisitResultEntityConfiguration());

            builder.Seed();

            base.OnModelCreating(builder);

            //test 2
        }

    }
}
