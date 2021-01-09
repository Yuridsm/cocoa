using cocoa.Interfaces;
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace cocoa.Services
{
    public class HealthService : IHealth
    {
        
        public string RAMMemoryInGB { get; set; }
        public string OperatingSystem { get; set; }
        public int Cores { get; set; }

        public string GetInfo()
        {
            var os = RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ||
                 RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                 RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

            StringBuilder builder = new StringBuilder();
            builder.Append(os.ToString());
            builder.Append("RAMMemoryInGB: 8GB");
            builder.Append("OperatingSystem: Windows");
            builder.Append("Cores: 4");

            return builder.ToString();
        }
    }
}

/*
 Console.WriteLine("Current OS Information:\n");
      Console.WriteLine();
      Console.WriteLine("Version String: {0}", os.VersionString);
      Console.WriteLine("Version Information:");
      Console.WriteLine("   Major: {0}", os.Version.Major);
      Console.WriteLine("   Minor: {0}", os.Version.Minor);
      Console.WriteLine("Service Pack: '{0}'", os.ServicePack);

var memoryInfo = new MemoryInfo(
                totalPhysicalMemoryGB: _getTotalPhysicalMemoryGB.Invoke(),
                availablePhysicalMemoryGB: _getAvailablePhysicalMemoryGB.Invoke());

            var healthInfo = new HealthInfo(
                    date: DateTime.Now,
                    userName: Environment.UserName,
                    machineName: Environment.MachineName,
                    oSVersion: Environment.OSVersion,
                    is64BitOperatingSystem: Environment.Is64BitOperatingSystem,
                    hasShutdownStarted: Environment.HasShutdownStarted,
                    processorCount: Environment.ProcessorCount,
                    version: Environment.Version,
                    workingSet: Environment.WorkingSet,
                    memoryInfo: memoryInfo);

 */