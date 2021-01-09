using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Interfaces
{
    public interface IPersonalInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string description { get; set; }
        public string GetInfo();
    }
}
