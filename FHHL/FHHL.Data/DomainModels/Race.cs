using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.DomainModels
{
    public class Race
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string AddUser { get; set; }
        public DateTimeOffset AddDateTimeOffset { get; set; }
        public string ChgUser { get; set; }
        public DateTimeOffset? ChgDateTimeOffset { get; set; }
        public string DelUser { get; set; }
        public DateTimeOffset? DelDateTimeOffset { get; set; }
        public bool DelFlag { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
