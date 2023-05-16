using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public interface ISsrsService
    {
        Task<byte[]> GetPdfAsync(string reportName, IDictionary<string, object> pairs = null);

        Task<byte[]> GetCsvAsync(string reportName, IDictionary<string, object> pairs = null);
    }
}
