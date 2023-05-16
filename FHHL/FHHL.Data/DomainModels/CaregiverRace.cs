using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels
{
    public class CaregiverRace
    {
        public int Id { get; set; }
        public int CaregiverId { get; set; }
        public int RaceId { get; set; }

        public virtual Caregiver Caregiver { get; set; }
        public virtual Race Race { get; set; }
    }
}
