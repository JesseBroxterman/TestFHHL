using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels
{
    public class Referral
    {
        public int Id { get; set; }
        public int CaregiverId { get; set; }
        public int? AssignedTo { get; set; }
        public DateTimeOffset? EstimatedDeliveryDate { get; set; }
        public DateTimeOffset ReferralDate { get; set; }
        public bool FirstChild { get; set; }
        public bool FtoF { get; set; }
        public int? Type { get; set; }
        public int? LOR { get; set; }
        public int? Program { get; set; }
        public string ChildName { get; set; }
        public DateTimeOffset? ChildDateOfBirth { get; set; }
        public string ReferralReason { get; set; }

        public DateTimeOffset? AssignDate { get; set; }
        public int? Result { get; set; }
        public DateTimeOffset? ResultDate { get; set; }
        public string Notes { get; set; }
        public string AddUser { get; set; }
        public DateTimeOffset? AddDateTimeOffset { get; set; }
        public string ChgUser { get; set; }
        public DateTimeOffset? ChgDateTimeOffset { get; set; }
        public string DelUser { get; set; }
        public DateTimeOffset? DelDateTimeOffset { get; set; }
        public bool DelFlag { get; set; }

        public virtual Caregiver Caregiver { get; set; }
        public virtual ICollection<ReferralRace> ReferralRaces { get; set; }
        public virtual ICollection<ReferralReferralSource> ReferralReferralSources { get; set; }
    }
}
