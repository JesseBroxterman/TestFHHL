using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models
{
    public class RecordJson
    {
        public int Id { get; set; }
        public List<string> ReferralDates { get; set; }
        public string ReferralDatesSortable { get; set; }
        public string CaregiverName { get; set; }
        public List<string> ChildNames { get; set; }
        public List<int?> AssignedTos { get; set; }
        public List<string> AssignedToLabels { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfBirthSortable { get; set; }
    }
}
