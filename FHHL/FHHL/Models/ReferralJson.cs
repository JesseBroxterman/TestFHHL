using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models
{
    public class ReferralJson
    {
        public int Id { get; set; }
        public string ReferralDate { get; set; }
        public string ReferralDateSortable { get; set; }
        public string CaregiverName { get; set; }
        public string ChildName { get; set; }
        public string AssignedTo { get; set; }
        public string Program { get; set; }
        public string Result { get; set; }
        public List<int> ReferralSourceIds { get; set; }
        public List<string> ReferralSourceLabels { get; set; }
    }
}
