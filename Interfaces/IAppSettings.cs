using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Interfaces
{
    public interface IAppSettings
    {
        public string Logging { get; }
        public string LogLevel { get; }
        public string Default { get; }
        public string Microsoft { get; }
        public string Microsoft_Hosting_Lifetime { get; }
    }
}
