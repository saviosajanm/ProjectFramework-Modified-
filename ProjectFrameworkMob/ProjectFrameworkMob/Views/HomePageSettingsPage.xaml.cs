using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFrameworkMob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageSettingsPage : ContentPage
    {
        public HomePageSettingsPage()
        {
            InitializeComponent();
            HeaderControl.ShowBurgerMenuOption(false);
            HeaderControl.ShowNavigationOption(true);
        }

        private async void GetHomePageBoxes_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Getting Home Page Boxes...";
                var boxes = await App.ApiServiceObj.GetHomePageBoxes();
                ListViewHomePageBoxes.ItemsSource = boxes;
                lblStatus.Text = "Success.";
            }
            catch (Exception Ex)
            {
                lblStatus.Text = "Failed: " + Ex.Message;
            }
        }
    }
}