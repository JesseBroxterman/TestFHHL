using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Common.Service
{
    public interface ITwilioService
    {
        Task<MessageResource> SendSmsAsync(string to, string message, string from = null, string callbackUrl = null);
    }
}
