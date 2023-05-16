using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models.Caregiver
{
    public class DashboardViewModel:EditViewModel
    {
        public List<FHHL.Data.DomainModels.Referral> Referrals { get; set; }
        public List<Assignee> Assignees { get; set; }
        public bool AdultFlag { get; set; }
        public bool DelFlag { get; set; }
    }
}
