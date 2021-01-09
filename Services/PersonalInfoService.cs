using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cocoa.Interfaces;

namespace cocoa.Services
{
    public class PersonalInfoService : IPersonalInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string description { get; set; }
    }
}
