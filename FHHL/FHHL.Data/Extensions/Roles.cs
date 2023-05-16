using System;
using System.Collections.Generic;
using System.Text;

namespace FHHL.Data.Extensions
{
    public class Roles
    {
        private Roles(string value) { Value = value; }

        public string Value { get; private set; }

        public static Roles Admin { get { return new Roles("Identity.Privileged"); } }
        public static Roles Writer { get { return new Roles("Identity.General");  } }
        public static Roles Reader { get { return new Roles("Identity.Restricted"); } }

        public override string ToString()
        {
            return Value;
        }
    }
}
