using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Service
{
    public class MailgunSettings
    {
        public string BaseUrl { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Domain { get; set; }

        public string From { get; set; }
    }
}
