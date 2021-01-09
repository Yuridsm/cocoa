using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cocoa.Interfaces;
using System.Configuration;

namespace cocoa.MappingObject
{
    public class AppSettings : IAppSettings
    {
        public string Logging { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
