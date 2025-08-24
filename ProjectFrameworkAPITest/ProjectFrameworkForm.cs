using Newtonsoft.Json;
using ProjectFrameworkAPITest.Properties;
using ProjectFrameworkCommonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFrameworkAPITest
{
    public partial class ProjectFrameworkForm : Form
    {
        AuthInfo AuthInfo;
        public ProjectFrameworkForm()
        {
            InitializeComponent();
            AuthInfo = new AuthInfo();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SetResponseData(string Response)
        {
            textBoxResponseData.Text = Response;
        }

        private async void buttonLogin_ClickAsync(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(textBoxURL.Text);
                HttpResponseMessage response = await client.GetAsync("api/Auth/ValidateUser?UserID=" + textBoxUserID.Text + "&Password=" + textBoxPassword.Text);
                string ResponseData = "";
                if (response.IsSuccessStatusCode)
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                    AuthInfo = JsonConvert.DeserializeObject<AuthInfo>(ResponseData);
                    labelAuthTokenValue.Text = AuthInfo.AuthenticationToken;
                }
                else
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrEmpty(ResponseData))
                    {
                        SetResponseData("No Error Response Data");
                    }
                    else
                    {
                        SetResponseData(ResponseData);
                    }

                }

            }
        }

        private async void buttonGet_ClickAsync(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(textBoxURL.Text);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", labelAuthTokenValue.Text);

                HttpResponseMessage response = await client.GetAsync("api/Settings/GetSettingsInfo");
                string ResponseData = "";
                if (response.IsSuccessStatusCode)
                {
                    ResponseData = await response.Content.ReadAsStringAsync();

                    AppSettings Settings = JsonConvert.DeserializeObject<AppSettings>(ResponseData);
                    textBoxAppName.Text = Settings.AppName;
                    textBoxMainHeading.Text = Settings.MainHeading;
                    textBoxDescription.Text = Settings.MainDesc;

                    SetResponseData(ResponseData);

                }
                else
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
            }
        }

        private async void buttonSet_ClickAsync(object sender, EventArgs e)
        {
            var settingsDict = new Dictionary<string, string>
            {
                { "AppName", textBoxAppName.Text },
                { "MainHeading", textBoxMainHeading.Text },
                { "MainDesc", textBoxDescription.Text }
            };

            string Paramters = "api/Settings/UpdateSettingsInfo";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(textBoxURL.Text);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", labelAuthTokenValue.Text);
                var serializedItem = JsonConvert.SerializeObject(settingsDict);

                HttpResponseMessage response = await client.PostAsync(Paramters, new StringContent(serializedItem, Encoding.UTF8, "application/json"));
                string ResponseData = "";
                if (response.IsSuccessStatusCode)
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
                else
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
            }
        }

        private async void buttonGetEmail_ClickAsync(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(textBoxURL.Text);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", labelAuthTokenValue.Text);

                HttpResponseMessage response = await client.GetAsync("api/EmailSettings/GetEmailSettingsInfo");
                string ResponseData = "";
                if (response.IsSuccessStatusCode)
                {
                    ResponseData = await response.Content.ReadAsStringAsync();

                    EmailSettings settings = JsonConvert.DeserializeObject<EmailSettings>(ResponseData);
                    textBoxSmtpServer.Text = settings.SMTPServer;
                    textBoxSmtpPort.Text = settings.SMTPPort.ToString();
                    textBoxEmailAddress.Text = settings.EMail;
                    textBoxEmailPassword.Text = settings.Password;
                    checkBoxEnableSsl.Checked = settings.EnableSSL;

                    SetResponseData(ResponseData);
                }
                else
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
            }
        }

        private async void buttonSetEmail_ClickAsync(object sender, EventArgs e)
        {
            EmailSettings settings = new EmailSettings
            {
                SMTPServer = textBoxSmtpServer.Text,
                SMTPPort = int.TryParse(textBoxSmtpPort.Text, out int port) ? port : 0,
                EMail = textBoxEmailAddress.Text,
                Password = textBoxEmailPassword.Text,
                EnableSSL = checkBoxEnableSsl.Checked
            };

            string Paramters = "api/EmailSettings/UpdateEmailSettingsInfo";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(textBoxURL.Text);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", labelAuthTokenValue.Text);
                var serializedItem = JsonConvert.SerializeObject(settings);

                HttpResponseMessage response = await client.PostAsync(Paramters, new StringContent(serializedItem, Encoding.UTF8, "application/json"));
                string ResponseData = "";
                if (response.IsSuccessStatusCode)
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
                else
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
            }
        }

        private async void buttonGetDevice_ClickAsync(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(textBoxURL.Text);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", labelAuthTokenValue.Text);

                HttpResponseMessage response = await client.GetAsync("api/DeviceDetails/GetDeviceDetails");
                string ResponseData = "";
                if (response.IsSuccessStatusCode)
                {
                    ResponseData = await response.Content.ReadAsStringAsync();

                    DeviceDetails details = JsonConvert.DeserializeObject<DeviceDetails>(ResponseData);
                    textBoxProcessorCount.Text = details.ProcessorCount.ToString();
                    textBoxTotalMemory.Text = details.TotalMemory;
                    textBoxMemoryLeft.Text = details.MemoryLeft;
                    textBoxTotalSpace.Text = details.TotalSpace;
                    textBoxSpaceLeft.Text = details.SpaceLeft;

                    SetResponseData(ResponseData);
                }
                else
                {
                    ResponseData = await response.Content.ReadAsStringAsync();
                    SetResponseData(ResponseData);
                }
            }
        }
    }

    // Models needed for deserialization
    public class EmailSettings
    {
        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool EnableSSL { get; set; }
    }

    public class DeviceDetails
    {
        public int ProcessorCount { get; set; }
        public string TotalMemory { get; set; }
        public string MemoryLeft { get; set; }
        public string TotalSpace { get; set; }
        public string SpaceLeft { get; set; }
    }
}