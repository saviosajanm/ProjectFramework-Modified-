using System.Threading.Tasks;

namespace ProjectFrameworkMob.Interfaces
{
    public interface IDeviceDetails
    {
        int GetProcessorCount();
        Task<string> GetTotalMemory();
        Task<string> GetFreeMemory();
        Task<string> GetTotalSpace();
        Task<string> GetFreeSpace();
    }
}