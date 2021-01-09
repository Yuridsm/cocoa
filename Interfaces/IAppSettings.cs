using cocoa.MappingObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Interfaces
{
    public interface IAppSettings
    {
        public string Logging { get; }
        public LogLevel LogLevel { get; }
    }
}
