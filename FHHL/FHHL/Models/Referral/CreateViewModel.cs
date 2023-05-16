using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models.Record
{
    public class CreateViewModel
    {
        [Display(Name = "Assigned To")]
        public int? AssignedTo { get; set; }
        [Display(Name = "Estimated Date of Confinement")]
        public DateTimeOffset? EDC { get; set; }
        [Display(Name = "Referral Date")]
        [Required]
        public int CaregiverId { get; set; }
        public string CaregiverName { get; set; }
        public DateTimeOffset ReferralDate { get; set; } = DateTimeOffset.Now.Date;
        [Display(Name = "First Child")]
        public bool FirstChild { get; set; }
        public bool FtoF { get; set; }
        public bool Spanish { get; set; }
        [Display(Name = "Pregnancy State")]
        public int? Type { get; set; }
        [Display(Name = "Level of Risk")]
        public int? LOR { get; set; }
        public int? Program { get; set; }
        [Display(Name = "Child Name")]
        public string ChildName { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTimeOffset? ChildDateOfBirth { get; set; }
        [Display(Name = "Referral Reason")]

        public string ReferralReason { get; set; }
        [Display(Name = "Date Assigned")]

        public DateTimeOffset? AssignDate { get; set; }
        [Display(Name = "Result")]
        public int? Result { get; set; }
        [Display(Name = "Date")]
        public DateTimeOffset? ResultDate { get; set; }
        public string Notes { get; set; }
        public List<int> SelectedRaces { get; set; }
        public List<int> SelectedReferralSources { get; set; }
    }
}
