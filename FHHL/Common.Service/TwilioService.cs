using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Common.Service
{
    public class TwilioService : ITwilioService
    {
        public TwilioSettings Options { get; set; }

        public TwilioService(IOptions<TwilioSettings> twilioSettings)
        {
            Options = twilioSettings.Value;
            TwilioClient.Init(Options.AccountSid, Options.AuthToken);
        }

        public async Task<MessageResource> SendSmsAsync(string to, string message, string from, string callbackUrl)
        {
            try
            {
                Uri statusCallback = null;

                var url = callbackUrl;
                if(string.IsNullOrWhiteSpace(url))
                    url = Options.CallbackUrl;
                if (!string.IsNullOrWhiteSpace(url))
                    statusCallback = new Uri(url);

                if (string.IsNullOrWhiteSpace(from))
                {
                    from = Options.From;
                }

                if (string.IsNullOrWhiteSpace(to) || string.IsNullOrWhiteSpace(from) || string.IsNullOrWhiteSpace(message))
                    return null;

                return await MessageResource.CreateAsync(
                    new Twilio.Types.PhoneNumber(to),
                    from: new Twilio.Types.PhoneNumber(from),
                    body: message,
                    statusCallback: statusCallback);
            }
            catch(Exception e)
            {
                var ex = new ApplicationException("Error sending text", e);
                ex.Data.Add(nameof(to), to);
                ex.Data.Add(nameof(from), from);
                ex.Data.Add(nameof(message), message);
                ex.Data.Add(nameof(callbackUrl), callbackUrl);
                throw ex;
            }
        }
    }
}
