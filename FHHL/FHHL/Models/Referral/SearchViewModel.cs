﻿using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models.Referral
{
    public class SearchViewModel
    {
        public DateTimeOffset? ReferralDateStart { get; set; }
        public DateTimeOffset? ReferralDateEnd { get; set; }
        [Display(Name = "Caregiver Name")]
        public string CaregiverName { get; set; }
        [Display(Name = "Child Name")]
        public string ChildName { get; set; }
        [Display(Name = "Assigned To")]
        public int? AssignedTo { get; set; }
        public int? Program { get; set; }
        public int? Result { get; set; }
        [Display(Name = "Referral Source(s)")]
        public List<int> ReferralSourceIds { get; set; }
        public bool DeletedRecords { get; set; }
    }
}
