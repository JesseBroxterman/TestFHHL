using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FHHL.Data.DomainModels
{
    public class Caregiver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Zip { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public bool MomClass { get; set; }
        public bool Spanish { get; set; }
        public bool Foster { get; set; }
        public string AddUser { get; set; }
        public DateTimeOffset? AddDateTimeOffset { get; set; }
        public string ChgUser { get; set; }
        public DateTimeOffset? ChgDateTimeOffset { get; set; }
        public string DelUser { get; set; }
        public DateTimeOffset? DelDateTimeOffset { get; set; }
        public bool DelFlag { get; set; }

        public virtual ICollection<CaregiverRace> CaregiverRaces { get; set; }
        public virtual ICollection<Referral> Referrals { get; set; }
    }
}
