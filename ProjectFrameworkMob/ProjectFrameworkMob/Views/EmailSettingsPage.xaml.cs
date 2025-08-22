using ProjectFrameworkMob.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFrameworkMob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailSettingsPage : ContentPage
    {
        public EmailSettingsPage()
        {
            InitializeComponent();
            HeaderControl.ShowBurgerMenuOption(false);
            HeaderControl.ShowNavigationOption(true);
        }

        private async void GetEmailSettings_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Getting E-Mail Settings...";
                EmailSettings settings = await App.ApiServiceObj.GetEmailSettingsInfo();
                EntrySmtpServer.Text = settings.SMTPServer;
                EntrySmtpPort.Text = settings.SMTPPort.ToString();
                EntryEmail.Text = settings.EMail;
                EntryPassword.Text = settings.Password;
                SwitchEnableSSL.IsToggled = settings.EnableSSL;
                lblStatus.Text = "Success.";
            }
            catch (Exception Ex)
            {
                lblStatus.Text = "Failed: " + Ex.Message;
            }
        }

        private async void UpdateEmailSettings_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Updating E-Mail Settings...";
                EmailSettings settings = new EmailSettings
                {
                    SMTPServer = EntrySmtpServer.Text,
                    SMTPPort = Convert.ToInt32(EntrySmtpPort.Text),
                    EMail = EntryEmail.Text,
                    Password = EntryPassword.Text,
                    EnableSSL = SwitchEnableSSL.IsToggled
                };

                bool bResult = await App.ApiServiceObj.UpdateEmailSettingsInfo(settings);

                if (bResult)
                {
                    lblStatus.Text = "Success.";
                }
                else
                {
                    lblStatus.Text = "Failed to Update.";
                }
            }
            catch (Exception Ex)
            {
                lblStatus.Text = "Failed: " + Ex.Message;
            }
        }
    }
}