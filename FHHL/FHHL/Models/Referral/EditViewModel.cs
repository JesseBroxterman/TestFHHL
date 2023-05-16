using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models.Record
{
    public class EditViewModel: CreateViewModel
    {
        public int Id { get; set; }
        public bool DelFlag { get; set; }
    }
}
