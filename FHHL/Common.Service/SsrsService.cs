using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public class SsrsService : ISsrsService
    {
        private SsrsSettings _settings;

        public SsrsService(IOptions<SsrsSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task<byte[]> GetPdfAsync(string reportName, IDictionary<string, object> pairs = null)
        {
            return await GetAsync("PDF", reportName, pairs);
        }

        public async Task<byte[]> GetCsvAsync(string reportName, IDictionary<string, object> pairs = null)
        {
            return await GetAsync("CSV", reportName, pairs);
        }

        public async Task<byte[]> GetAsync(string format, string reportName, IDictionary<string, object> pairs)
        {
            var client = new WebClient();
            
            if (!string.IsNullOrWhiteSpace(_settings.UserName))
            {
                client.Credentials = new NetworkCredential(_settings.UserName, _settings.Password, _settings.Domain);
            }
            else
            {
                client.UseDefaultCredentials = true;
            }            

            var reportUrl = new StringBuilder().Append($"{_settings.Server}/Pages/ReportViewer.aspx?%2f{_settings.Folder}%2f{reportName}%2f&rs:Command=Render&rs:Format={format}");
            if(pairs != null)
            {
                foreach(var pair in pairs)
                {
                    reportUrl.Append($"&{Uri.EscapeUriString(pair.Key)}={Uri.EscapeUriString(pair.Value.ToString())}");
                }
            }
            return await client.DownloadDataTaskAsync(reportUrl.ToString());
        }
    }
}
