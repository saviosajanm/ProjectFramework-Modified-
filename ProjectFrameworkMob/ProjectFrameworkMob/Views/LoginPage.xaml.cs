using ProjectFrameworkCommonLib;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFrameworkMob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Checking Login Credentials...";
                AuthInfo Info = await App.ApiServiceObj.ValidateUser(lblUsername.Text, lblPassword.Text);
                if (Info.UserID > 0)
                {
                    App.SettingsManagerObj.UserID = Info.UserID;
                    App.SettingsManagerObj.AuthenticationToken = Info.AuthenticationToken;
                    App.SettingsManagerObj.EMail = lblUsername.Text;
                    App.SettingsManagerObj.SaveSettings();
                    App.ApiServiceObj.SetUserCredentials(Info.UserID, lblUsername.Text, Info.AuthenticationToken);
                    lblStatus.Text = "Login Success..";
                    await Task.Delay(500);

                    ((App)(App.Current)).RelaunchMasterForm();
                }
                else
                {
                    lblStatus.Text = "Login Failed: " + Info.AuthenticationToken;
                }
            }
            catch (Exception Ex)
            {
                lblStatus.Text = "Error: " + Ex.Message;
            }
        }

        private async void ButtonSignup_Clicked(object sender, EventArgs e)
        {
            // MODIFIED: Use the dynamic LoginPageUrl property from the App class.
            // This ensures the WebView points to the correct URL for either backend.
            await Navigation.PushAsync(new WebViewPage(App.LoginPageUrl));
        }
    }
}