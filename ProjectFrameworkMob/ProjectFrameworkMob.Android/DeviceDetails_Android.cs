using Android.App;
using Android.Content;
using Android.OS;
using ProjectFrameworkMob.Droid;
using ProjectFrameworkMob.Interfaces;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceDetails_Android))]
namespace ProjectFrameworkMob.Droid
{
    public class DeviceDetails_Android : IDeviceDetails
    {
        public int GetProcessorCount()
        {
            return System.Environment.ProcessorCount;
        }

        public Task<string> GetTotalMemory()
        {
            var activityManager = (ActivityManager)Android.App.Application.Context.GetSystemService(Context.ActivityService);
            var memoryInfo = new ActivityManager.MemoryInfo();
            activityManager.GetMemoryInfo(memoryInfo);
            return Task.FromResult(FormatBytes(memoryInfo.TotalMem));
        }

        public Task<string> GetFreeMemory()
        {
            var activityManager = (ActivityManager)Android.App.Application.Context.GetSystemService(Context.ActivityService);
            var memoryInfo = new ActivityManager.MemoryInfo();
            activityManager.GetMemoryInfo(memoryInfo);
            return Task.FromResult(FormatBytes(memoryInfo.AvailMem));
        }

        public Task<string> GetTotalSpace()
        {
            var stat = new StatFs(Android.OS.Environment.DataDirectory.Path);
            return Task.FromResult(FormatBytes(stat.BlockCountLong * stat.BlockSizeLong));
        }

        public Task<string> GetFreeSpace()
        {
            var stat = new StatFs(Android.OS.Environment.DataDirectory.Path);
            return Task.FromResult(FormatBytes(stat.AvailableBlocksLong * stat.BlockSizeLong));
        }

        private string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }
            return $"{dblSByte:0.##} {Suffix[i]}";
        }
    }
}