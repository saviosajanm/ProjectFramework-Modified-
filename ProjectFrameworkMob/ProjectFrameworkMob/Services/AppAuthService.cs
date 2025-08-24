using Newtonsoft.Json;
using ProjectFrameworkCommonLib;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjectFrameworkMob.Services
{
    public partial class AppApiService
    {
        public async Task<AuthInfo> ValidateUser(string UserID, string Password)
        {
            AuthInfo Info = new AuthInfo();
            try
            {
                // MODIFICATION: Ensure this URL exactly matches the new route attribute.
                // It is case-sensitive.
                string Paramters = $"api/Auth/ValidateUser?UserID={Uri.EscapeDataString(UserID)}&Password={Uri.EscapeDataString(Password)}";
                var response = await AppServiceClient.GetAsync(Paramters);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Info = JsonConvert.DeserializeObject<AuthInfo>(responseData);
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Info.UserID = -1;
                    Info.AuthenticationToken = !string.IsNullOrWhiteSpace(errorContent)
                        ? errorContent
                        : $"Request failed: {response.ReasonPhrase} ({(int)response.StatusCode})";
                }
                return Info;
            }
            catch (Exception Ex)
            {
                Info.UserID = -1;
                Info.AuthenticationToken = $"Exception: {Ex.Message}";
                if (Ex.InnerException != null)
                {
                    Info.AuthenticationToken += $" | InnerException: {Ex.InnerException.Message}";
                }
                return Info;
            }
        }
    }
}