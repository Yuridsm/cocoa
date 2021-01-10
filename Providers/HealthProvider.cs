using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using cocoa.Controllers;
using cocoa.Interfaces;
using cocoa.MappingObject;
using Microsoft.Extensions.Options;

namespace cocoa.Providers
{
    public static class HealthProvider {
        //private static AppSettings _appSettings { get; }

        public static IDictionary<string, object> GetSettings(this HealthController health)
        {
            var properties = health._appSettings;
            IDictionary<string, object> data = new Dictionary<string, object>();

            if(properties.Logging.Equals(typeof(Logging)))
            {
            }

            if (properties.ConnectionString.Connection.Contains("Password"))
            {
                
                properties.ConnectionString.Connection = BlurConnectionStringPassword(properties.ConnectionString.Connection);

                data.Add("ConnectionString", properties.ConnectionString);
            }
            return data;
        }
        public static string BlurConnectionStringPassword(string planText)
        {
            string planPassword = planText.Split(';')[1].Split('=')[1];
            var newProperty = planText.Replace("Password=" + planPassword, "Password=********");

            return newProperty;
        }
    }
}