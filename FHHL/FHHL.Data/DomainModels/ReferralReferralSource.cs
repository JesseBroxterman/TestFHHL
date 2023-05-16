using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels
{
    public class ReferralReferralSource
    {
        public int Id { get; set; }
        public int ReferralId { get; set; }
        public int ReferralSourceId { get; set; }

        public virtual Referral Referral { get; set; }
        public virtual ReferralSource ReferralSource { get; set; }
    }
}
