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
        public async Task<EmailSettings> GetEmailSettingsInfo()
        {
            try
            {
                var requestTask = await AppServiceClient.GetAsync("api/EmailSettings/GetEmailSettingsInfo");
                var response = Task.Run(() => requestTask);
                if (response.Result.IsSuccessStatusCode)
                {
                    var responseData = await response.Result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<EmailSettings>(responseData);
                }
                else
                {
                    var responseData = await response.Result.Content.ReadAsStringAsync();
                    throw new Exception(responseData);
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public async Task<bool> UpdateEmailSettingsInfo(EmailSettings settings)
        {
            try
            {
                var serializedItem = JsonConvert.SerializeObject(settings);
                var requestTask = await AppServiceClient.PostAsync("api/EmailSettings/UpdateEmailSettingsInfo", new StringContent(serializedItem, Encoding.UTF8, "application/json"));
                var response = Task.Run(() => requestTask);
                if (response.Result.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var responseData = await response.Result.Content.ReadAsStringAsync();
                    throw new Exception(responseData);
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}