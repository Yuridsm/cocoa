using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cocoa.Interfaces;
using System.Configuration;
using System.Text;

namespace cocoa.MappingObject
{
    public class AppSettings : IAppSettings
    {
        public Logging Logging { get; set; }
        public ConnectionString ConnectionString { get; set; }
    }
}
