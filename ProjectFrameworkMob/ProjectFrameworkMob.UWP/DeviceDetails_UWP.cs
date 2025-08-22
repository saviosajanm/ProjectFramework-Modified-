using ProjectFrameworkMob.Interfaces;
using ProjectFrameworkMob.UWP;
using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.System;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceDetails_UWP))]
namespace ProjectFrameworkMob.UWP
{
    public class DeviceDetails_UWP : IDeviceDetails
    {
        public int GetProcessorCount()
        {
            return Environment.ProcessorCount;
        }

        public Task<string> GetTotalMemory()
        {
            return Task.FromResult(FormatBytes(MemoryManager.AppMemoryUsageLimit));
        }

        public Task<string> GetFreeMemory()
        {
            var limit = MemoryManager.AppMemoryUsageLimit;
            var used = MemoryManager.AppMemoryUsage;
            return Task.FromResult(FormatBytes(limit > used ? limit - used : 0));
        }

        public async Task<string> GetTotalSpace()
        {
            return await GetSpace("System.Capacity");
        }

        public async Task<string> GetFreeSpace()
        {
            return await GetSpace("System.FreeSpace");
        }

        private async Task<string> GetSpace(string property)
        {
            try
            {
                var folder = ApplicationData.Current.LocalFolder;
                var properties = await folder.GetBasicPropertiesAsync();
                var extendedProperties = await properties.RetrievePropertiesAsync(new[] { property });
                return FormatBytes((ulong)extendedProperties[property]);
            }
            catch
            {
                return "Not Available";
            }
        }

        private string FormatBytes(ulong bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i = 0;
            double dblSByte = bytes;
            while (dblSByte >= 1024 && i < Suffix.Length - 1)
            {
                dblSByte /= 1024.0;
                i++;
            }
            return $"{dblSByte:0.##} {Suffix[i]}";
        }
    }
}