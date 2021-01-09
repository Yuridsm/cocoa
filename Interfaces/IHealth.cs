using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Interfaces
{
    public interface IHealth
    {
        public string RAMMemoryInGB { get; set; }
        public string OperatingSystem { get; set; }
        public int Cores { get; set; }

        public string GetInfo();
    }
}
