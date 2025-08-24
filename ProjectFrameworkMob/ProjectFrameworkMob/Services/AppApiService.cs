using ProjectFrameworkMob;
using ProjectFrameworkMob.Services;
using System;
using System.Net;
using System.Net.Http;
using Xamarin.Essentials;

// Make sure this file is also inside the namespace
namespace ProjectFrameworkMob.Services
{
    public partial class AppApiService
    {
        AppCommunicationClient AppServiceClient;
        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        public HttpStatusCode StatusCode { get; set; }

        public AppApiService()
        {
            InitializeClient();
        }

        public void InitializeClient()
        {
#if DEBUG
            // MODIFIED: This handler will bypass SSL certificate validation for the local dev certificate.
            // This is for DEVELOPMENT ONLY. Do NOT use this in production code.
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };
            AppServiceClient = new AppCommunicationClient(handler);
#else
            // Production code should use the default handler which enforces valid SSL.
            AppServiceClient = new AppCommunicationClient();
#endif

            AppServiceClient.BaseAddress = new Uri($"{App.AzureBackendUrl}/");
        }

        public void SetUserCredentials(int CustomerID, string CustomerEmail, string AuthenticationToken)
        {
            AppServiceClient.SetUserCredentials(CustomerID, CustomerEmail, AuthenticationToken);
        }
    }
}