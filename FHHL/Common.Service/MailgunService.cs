using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public class MailgunService : IMailgunService
    {
        public MailgunSettings Options { get; set; }

        public MailgunService(IOptions<MailgunSettings> options)
        {
            Options = options.Value;
        }

        public async Task SendEmailAsync(
            string to,
            string cc = null,
            string bcc = null,
            string from = null,
            string subject = null,
            string text = null,
            string html = null,
            Dictionary<string, MemoryStream> attachments = null,
            object inline = null,
            string oTag = null,
            string oCampaign = null,
            string oDkim = null,
            string oDeliverytime = null,
            string oTestmode = null,
            string oTracking = null,
            string oTrackingClicks = null,
            string oTrackingOpens = null,
            string oRequireTis = null,
            string oSkipVerification = null,
            string hXMyHeader = null,
            string vMyVar = null)
        {
            try
            {
                var client = new RestClient
                {
                    BaseUrl = new Uri(Options.BaseUrl),
                    Authenticator = new HttpBasicAuthenticator(Options.Username, Options.Password)
                };

                var request = new RestRequest
                {
                    Resource = "{domain}/messages",
                    Method = Method.POST
                };

                request.AddParameter("domain", Options.Domain, ParameterType.UrlSegment);

                if (!string.IsNullOrWhiteSpace(to))
                    request.AddParameter("to", to);

                if (!string.IsNullOrWhiteSpace(cc))
                    request.AddParameter("cc", cc);

                if (!string.IsNullOrWhiteSpace(bcc))
                    request.AddParameter("bcc", bcc);

                request.AddParameter("from",
                    !string.IsNullOrWhiteSpace(from)
                        ? from
                        : Options.From);

                if (!string.IsNullOrWhiteSpace(subject))
                    request.AddParameter("subject", subject);

                if (!string.IsNullOrWhiteSpace(text))
                    request.AddParameter("text", text);

                if (!string.IsNullOrWhiteSpace(html))
                    request.AddParameter("html", html);

                if (attachments != null)
                {
                    foreach (var a in attachments)
                    {
                        request.AddFile("attachment", a.Value.ToArray(), a.Key);
                    }
                }

                if (inline != null)
                    request.AddParameter("inline", inline);

                if (!string.IsNullOrWhiteSpace(oTag))
                    request.AddParameter("o:tag", oTag);

                if (!string.IsNullOrWhiteSpace(oCampaign))
                    request.AddParameter("o:campaign", oCampaign);

                if (!string.IsNullOrWhiteSpace(oDkim))
                    request.AddParameter("o:dkim", oDkim);

                if (!string.IsNullOrWhiteSpace(oDeliverytime))
                    request.AddParameter("o:deliverytime", oDeliverytime);

                if (!string.IsNullOrWhiteSpace(oTestmode))
                    request.AddParameter("o:testmode", oTestmode);

                if (!string.IsNullOrWhiteSpace(oTracking))
                    request.AddParameter("o:tracking", oTracking);

                if (!string.IsNullOrWhiteSpace(oTrackingClicks))
                    request.AddParameter("o:tracking-clicks", oTrackingClicks);

                if (!string.IsNullOrWhiteSpace(oTrackingOpens))
                    request.AddParameter("o:tracking-opens", oTrackingOpens);

                if (!string.IsNullOrWhiteSpace(oRequireTis))
                    request.AddParameter("o:require-tls", oRequireTis);

                if (!string.IsNullOrWhiteSpace(oSkipVerification))
                    request.AddParameter("o:skip-verification", oSkipVerification);

                if (!string.IsNullOrWhiteSpace(hXMyHeader))
                    request.AddParameter("h:X-My-Header	", hXMyHeader);

                if (!string.IsNullOrWhiteSpace(vMyVar))
                    request.AddParameter("v:my-var", vMyVar);

                await client.PostTaskAsync<object>(request);
            }
            catch(Exception e)
            {
                var ex = new ApplicationException("Error sending email", e);
                ex.Data.Add(nameof(to), to);
                ex.Data.Add(nameof(cc), cc);
                ex.Data.Add(nameof(bcc), bcc);
                ex.Data.Add(nameof(from), from);
                ex.Data.Add(nameof(subject), subject);
                ex.Data.Add(nameof(text), text);
                ex.Data.Add(nameof(html), html);
                ex.Data.Add(nameof(attachments), attachments);
                ex.Data.Add(nameof(inline), inline);
                ex.Data.Add(nameof(oTag), oTag);
                ex.Data.Add(nameof(oCampaign), oCampaign);
                ex.Data.Add(nameof(oDkim), oDkim);
                ex.Data.Add(nameof(oDeliverytime), oDeliverytime);
                ex.Data.Add(nameof(oTestmode), oTestmode);
                ex.Data.Add(nameof(oTracking), oTracking);
                ex.Data.Add(nameof(oTrackingClicks), oTrackingClicks);
                ex.Data.Add(nameof(oTrackingOpens), oTrackingOpens);
                ex.Data.Add(nameof(oRequireTis), oRequireTis);
                ex.Data.Add(nameof(oSkipVerification), oSkipVerification);
                ex.Data.Add(nameof(hXMyHeader), hXMyHeader);
                ex.Data.Add(nameof(vMyVar), vMyVar);
                throw ex;
            }
        }
    }
}
