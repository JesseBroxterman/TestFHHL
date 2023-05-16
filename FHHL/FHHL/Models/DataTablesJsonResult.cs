using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Models
{
    public class DataTablesJsonResult<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public T[] data { get; set; }

        public string searchCriteria { get; set; }
    }
}
