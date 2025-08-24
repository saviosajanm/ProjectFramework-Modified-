using Newtonsoft.Json;
using ProjectFrameworkMob.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectFrameworkMob.Services
{
    public partial class AppApiService
    {
        public async Task<List<HomePageBox>> GetHomePageBoxes()
        {
            try
            {
                var requestTask = await AppServiceClient.GetAsync("api/HomePageBox/GetHomePageBoxes");
                var response = Task.Run(() => requestTask);
                if (response.Result.IsSuccessStatusCode)
                {
                    var responseData = await response.Result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<HomePageBox>>(responseData);
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