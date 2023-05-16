using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Common.Service.Models.Json;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Common.Service
{
    public class LayoutService : ILayoutService
    {
        public LayoutSettings Options { get; set; }

        public Header Header { get; set; }
        public Footer Footer { get; set; }

        public LayoutService(IOptions<LayoutSettings> options)
        {
            Options = options.Value;
            Initialize().Wait();
        }

        private async Task Initialize()
        {
            var path = Options.BasePath;
            var uri = new Uri(path);

            try
            {
                var json = await new WebClient().DownloadStringTaskAsync(uri);

                var layout = Layout.FromJson(json);

                Header = layout.Header;
                Footer = layout.Footer;
            }
            catch(Exception)
            {
                Header = new Header();
                Header.HeaderItems = new List<HeaderItem>();
                Footer = new Footer();
                Footer.FooterItems = new List<FooterItem>();
            }
            
        }
    }
}
