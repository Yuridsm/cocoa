using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Common;
using cocoa.Interfaces;
using cocoa.MappingObject;

namespace cocoa.Providers
{
    public class HealthProvider { 

        public static IAppSettings _appsettings = new AppSettings();

        public static IDictionary<string, object> GetSettings()
        {
            var data = new Dictionary<string, object>();

            var properties = _appsettings.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == "ConnectionString")
                {
                    data.Add(property.Name, BlurConnectionStringPassword(property.GetValue(_appsettings).ToString()));
                    continue;
                }
                if (property.Name == "FixPassword")
                {
                    var password = property.GetValue(_appsettings).ToString();
                    data.Add(property.Name, password.Replace(password, "********"));
                    continue;
                }

                data.Add(property.Name, property.GetValue(_appsettings));
            }

            return data;
        }

        public static string BlurConnectionStringPassword(string connStr)
        {
            var builder = new DbConnectionStringBuilder
            {
                ConnectionString = connStr
            };

            builder["Password"] = "********";
            return builder.ConnectionString;
        }
    }
}