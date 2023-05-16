using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models.Caregiver
{
    public class CreateViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip must be empty or 5 characters.")]
        public string Zip { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public bool MomClass { get; set; }
        public bool Spanish { get; set; }
        public bool Foster { get; set; }
        public List<int> SelectedRaces { get; set; }
    }
}
