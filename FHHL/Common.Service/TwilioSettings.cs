using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Service
{
    public class TwilioSettings
    {
        public string AccountSid { get; set; }

        public string AuthToken { get; set; }

        public string From { get; set; }

        public string CallbackUrl { get; set; }
    }
}
