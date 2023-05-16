using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Service.Models.Json;

namespace Common.Service
{
    public interface ILayoutService
    {
        Header Header { get; set; }
        Footer Footer { get; set; }
    }
}
