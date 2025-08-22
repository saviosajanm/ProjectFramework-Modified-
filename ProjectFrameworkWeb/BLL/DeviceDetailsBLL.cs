using ProjectFrameworkWeb.Models;

namespace ProjectFrameworkWeb.BLL
{
    public class DeviceDetailsBLL : BLLBase
    {
        public DeviceDetails GetDeviceDetails()
        {
            return new DeviceDetails
            {
                ProcessorCount = int.TryParse(GetValue("Device_ProcessorCount"), out int count) ? count : 0,
                TotalMemory = GetValue("Device_TotalMemory"),
                MemoryLeft = GetValue("Device_MemoryLeft"),
                TotalSpace = GetValue("Device_TotalSpace"),
                SpaceLeft = GetValue("Device_SpaceLeft")
            };
        }

        public void SaveDeviceDetails(DeviceDetails details)
        {
            SetValue("Device_ProcessorCount", details.ProcessorCount.ToString());
            SetValue("Device_TotalMemory", details.TotalMemory);
            SetValue("Device_MemoryLeft", details.MemoryLeft);
            SetValue("Device_TotalSpace", details.TotalSpace);
            SetValue("Device_SpaceLeft", details.SpaceLeft);
        }
    }
}