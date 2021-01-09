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
        public string Logging => GetRequiredAppSetting("Logging");
        public string LogLevel => GetRequiredAppSetting("LogLevel");
        public string Default => GetRequiredAppSetting("Default");
        public string Microsoft => GetRequiredAppSetting("Microsoft");
        public string Microsoft_Hosting_Lifetime => GetRequiredAppSetting("Microsoft.Hosting.Lifetime");

        private static string GetRequiredAppSetting(string key)
        {
            var value = ConfigurationManager.AppSettings[key];

            if (value == null)
                throw new Exception();

            return value;
        }

    }
}
