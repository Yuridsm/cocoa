using cocoa.MappingObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Interfaces
{
    public interface IAppSettings
    {
        public Logging Logging { get; }
        public ConnectionString ConnectionString { get; set; }
    }
}
