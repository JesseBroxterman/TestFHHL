using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public interface IMailgunService
    {
        Task SendEmailAsync(
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
            string vMyVar = null
            );
    }
}
