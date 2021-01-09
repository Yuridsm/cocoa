using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cocoa.Interfaces;
using cocoa.Providers;

namespace cocoa.Services
{
    public class PersonalInfoService : IPersonalInfo
    {
        private PersonalProvider _provider;
        public string firstName { get;set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string description { get; set; }

        public string GetInfoService()
        {
            _provider = new PersonalProvider(this);
            _provider.SetInfo();
            return _provider.GetInfoProvider();
        }
    }
}
