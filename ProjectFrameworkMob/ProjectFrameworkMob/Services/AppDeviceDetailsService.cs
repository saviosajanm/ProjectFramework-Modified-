using Newtonsoft.Json;
using ProjectFrameworkMob.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkMob.Services
{
    public partial class AppApiService
    {
        public async Task<bool> SendDeviceDetailsInfo(DeviceDetails details)
        {
            try
            {
                var serializedItem = JsonConvert.SerializeObject(details);
                var requestTask = await AppServiceClient.PostAsync("api/DeviceDetails/ReceiveDeviceDetails", new StringContent(serializedItem, Encoding.UTF8, "application/json"));
                var response = Task.Run(() => requestTask);
                return response.Result.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}