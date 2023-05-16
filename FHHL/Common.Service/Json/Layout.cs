using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Service.Models.Json
{
    public partial class Layout
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
    }

    public partial class Footer
    {
        public List<FooterItem> FooterItems { get; set; }
    }

    public partial class FooterItem
    {
        public string Display { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }

    public partial class Header
    {
        public List<HeaderItem> HeaderItems { get; set; }
    }

    public partial class HeaderItem
    {
        public string Display { get; set; }
        public string URL { get; set; }
        public List<HeaderGroup> HeaderGroups { get; set; }
    }

    public partial class HeaderGroup
    {
        public string Display { get; set; }
        public List<HeaderGroupItem> HeaderGroupItems { get; set; }
    }

    public partial class HeaderGroupItem
    {
        public string Display { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    }

    public partial class Layout
    {
        public static Layout FromJson(string json) => JsonConvert.DeserializeObject<Layout>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Layout self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
