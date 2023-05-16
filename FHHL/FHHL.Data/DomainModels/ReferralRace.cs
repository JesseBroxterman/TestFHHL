using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels
{
    public class ReferralRace
    {
        public int Id { get; set; }
        public int ReferralId { get; set; }
        public int RaceId { get; set; }


        public virtual Referral Referral { get; set; }
        public virtual Race Race { get; set; }
    }
}
