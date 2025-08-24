using ProjectFrameworkCommonLib;
using ProjectFrameworkMob.Services;
using ProjectFrameworkMob.Utils;
using ProjectFrameworkMob.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFrameworkMob
{
    // Define an enumeration to represent the different backend types.
    public enum BackendType
    {
        AspNetCore,
        AspNetWebForms
    }

    public partial class App : Application
    {
        // *** CONFIGURATION SWITCH ***
        // Change this value to switch between your web projects.
        // BackendType.AspNetCore for ProjectFramework.Web (port 51000)
        // BackendType.AspNetWebForms for ProjectFrameworkWeb (port 52371)
        public static readonly BackendType CurrentBackend = BackendType.AspNetCore;
        //public static readonly BackendType CurrentBackend = BackendType.AspNetWebForms;

        private const string AppEncryptionKey = "KtsInfotechPalaKeralaIndia";

        // Backend URLs are now set dynamically based on the CurrentBackend switch.
        public static string LocalDevelopmentURL { get; private set; }
        public static string AzureBackendUrl { get; private set; }

        #region --- Dynamic Page URLs ---
        // These properties will return the correct full URL for web pages
        // based on the selected backend, resolving the different routing patterns.

        public static string LoginPageUrl
        {
            get
            {
                return CurrentBackend == BackendType.AspNetCore
                    ? AzureBackendUrl + "Home/Login"
                    : AzureBackendUrl + "Login";
            }
        }

        public static string AboutPageUrl
        {
            get
            {
                return CurrentBackend == BackendType.AspNetCore
                    ? AzureBackendUrl + "Home/About"
                    : AzureBackendUrl + "Page/About";
            }
        }

        public static string ContactPageUrl
        {
            get
            {
                return CurrentBackend == BackendType.AspNetCore
                    ? AzureBackendUrl + "Home/Contact"
                    : AzureBackendUrl + "Page/Contact";
            }
        }

        // Add other page URLs here if they differ between projects.
        #endregion

        public static AppSettingsManager SettingsManagerObj = null;
        public static AppApiService ApiServiceObj = null;
        public static MainPage MainPageObj { get; set; }

        public App()
        {
            // Set the backend URL based on the configuration switch.
            switch (CurrentBackend)
            {
                case BackendType.AspNetCore:
                    // URL for ProjectFramework.Web
                    LocalDevelopmentURL = "http://192.168.31.178:51000";
                    break;
                case BackendType.AspNetWebForms:
                    // URL for ProjectFrameworkWeb
                    // Note: 10.0.2.2 is the standard IP for the host machine from the Android emulator.
                    LocalDevelopmentURL = "http://192.168.31.178:52371/";
                    break;
            }

            // Set the final backend URL for the application to use.
            AzureBackendUrl = DeviceInfo.Platform == DevicePlatform.Android ? LocalDevelopmentURL : "http://localhost:51000";


            try
            {
                InitializeComponent();

                // Set the Encryption Key. This key must match the one in your web project.
                PFCrypt.Key = AppEncryptionKey;

                if (SettingsManagerObj == null)
                {
                    SettingsManagerObj = new AppSettingsManager();
                }

                if (ApiServiceObj == null)
                {
                    ApiServiceObj = new AppApiService();
                }

                SettingsManagerObj.LoadSettings();
                if (!string.IsNullOrEmpty(SettingsManagerObj.AuthenticationToken))
                {
                    ApiServiceObj.SetUserCredentials(SettingsManagerObj.UserID, SettingsManagerObj.EMail, SettingsManagerObj.AuthenticationToken);
                }
                LaunchForms();
            }
            catch (Exception Ex)
            {
                MainPageObj = new MainPage(Ex.Message);
                MainPage = new NavigationPage(MainPageObj);
            }
        }

        private void LaunchForms()
        {
            MainPageObj = new MainPage();
            if (string.IsNullOrEmpty(App.SettingsManagerObj.AuthenticationToken))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(MainPageObj);
            }
        }

        public void RelaunchMasterForm()
        {
            MainPage = new NavigationPage(MainPageObj);
        }

        public void RelaunchLoginForm()
        {
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}