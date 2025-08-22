using ProjectFrameworkMob.Interfaces;
using ProjectFrameworkMob.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFrameworkMob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDetailsPage : ContentPage
    {
        private readonly IDeviceDetails _deviceDetails;

        public DeviceDetailsPage()
        {
            InitializeComponent();
            HeaderControl.ShowBurgerMenuOption(false);
            HeaderControl.ShowNavigationOption(true);

            _deviceDetails = DependencyService.Get<IDeviceDetails>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadDeviceDetails();
        }

        private async Task LoadDeviceDetails()
        {
            if (_deviceDetails == null)
            {
                lblStatus.Text = "Could not retrieve device details implementation.";
                return;
            }

            LabelProcessorCount.Text = $"Processor Count: {_deviceDetails.GetProcessorCount()}";
            LabelTotalMemory.Text = $"Total Memory: {await _deviceDetails.GetTotalMemory()}";
            LabelMemoryLeft.Text = $"Memory Left: {await _deviceDetails.GetFreeMemory()}";
            LabelTotalSpace.Text = $"Total Space: {await _deviceDetails.GetTotalSpace()}";
            LabelSpaceLeft.Text = $"Space Left: {await _deviceDetails.GetFreeSpace()}";
        }

        private async void SendDetails_Clicked(object sender, EventArgs e)
        {
            if (_deviceDetails == null)
            {
                lblStatus.Text = "Could not send details; implementation not found.";
                return;
            }

            try
            {
                lblStatus.Text = "Sending device details...";
                var details = new DeviceDetails
                {
                    ProcessorCount = _deviceDetails.GetProcessorCount(),
                    TotalMemory = await _deviceDetails.GetTotalMemory(),
                    MemoryLeft = await _deviceDetails.GetFreeMemory(),
                    TotalSpace = await _deviceDetails.GetTotalSpace(),
                    SpaceLeft = await _deviceDetails.GetFreeSpace()
                };

                bool success = await App.ApiServiceObj.SendDeviceDetailsInfo(details);

                if (success)
                {
                    lblStatus.Text = "Details sent successfully!";
                }
                else
                {
                    lblStatus.Text = "Failed to send details.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }
    }
}