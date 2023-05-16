using FHHL.Data.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Assignee>().HasData(
                new Assignee { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Teresa" },
                new Assignee { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Bonnie" },
                new Assignee { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Missy" },
                new Assignee { Id = 4, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Marla" },
                new Assignee { Id = 5, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Ariona" },
                new Assignee { Id = 6, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Outreach Letter" },
                new Assignee { Id = 7, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Felica" },
                new Assignee { Id = 8, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Jene" },
                new Assignee { Id = 9, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Abby" },
                new Assignee { Id = 10, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Tandem" },
                new Assignee { Id = 11, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Renee" },
                new Assignee { Id = 12, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Emma" },
                new Assignee { Id = 13, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Marsue" });

            builder.Entity<PregnancyState>().HasData(
                new PregnancyState { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Prebirth" },
                new PregnancyState { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Birth" },
                new PregnancyState { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Toddler" },
                new PregnancyState { Id = 4, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Infant" },
                new PregnancyState { Id = 5, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Postpartum" }
                );

            builder.Entity<Program>().HasData(
                new Program { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "HSHV"},
                new Program { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "NBHV" },
                new Program { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "NFP" },
                new Program { Id = 4, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "PHN" },
                new Program { Id = 5, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "PART C" },
                new Program { Id = 6, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "FS" },
                new Program { Id = 7, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Outreach" }
                );

            builder.Entity<Race>().HasData(
                new Race { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "White"},
                new Race { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Black" },
                new Race { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Black/White" },
                new Race { Id = 4, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "American Indian" },
                new Race { Id = 5, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Asian" },
                new Race { Id = 6, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Non-Hispanic" },
                new Race { Id = 7, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Unknown" },
                new Race { Id = 8, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Other" }
                );

            builder.Entity<ReferralSource>().HasData(
                new ReferralSource { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "PG Testing"},
                new ReferralSource { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "M & I" },
                new ReferralSource { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Hopsital" },
                new ReferralSource { Id = 4, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "WIC" },
                new ReferralSource { Id = 5, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Successful Connections" },
                new ReferralSource { Id = 6, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "TARC" },
                new ReferralSource { Id = 7, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Washburn" },
                new ReferralSource { Id = 8, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Other" },
                new ReferralSource { Id = 9, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Lincoln Center" }
                );

            builder.Entity<RiskLevel>().HasData(
                new RiskLevel { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "High"},
                new RiskLevel { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Medium" },
                new RiskLevel { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Low" }
                );

            builder.Entity<VisitResult>().HasData(
                new VisitResult { Id = 1, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Home Visit" },
                new VisitResult { Id = 2, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Declined" },
                new VisitResult { Id = 3, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "No Response" },
                new VisitResult { Id = 4, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Failed" },
                new VisitResult { Id = 5, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Miscarried" },
                new VisitResult { Id = 6, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Moved" },
                new VisitResult { Id = 7, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Lost" },
                new VisitResult { Id = 8, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Deferred" },
                new VisitResult { Id = 9, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Enrolled" },
                new VisitResult { Id = 10, ActiveFlag = true, AddDateTimeOffset = DateTimeOffset.Now, AddUser = "Seed", DelFlag = false, Label = "Other" }
                );
        }
    }
}
