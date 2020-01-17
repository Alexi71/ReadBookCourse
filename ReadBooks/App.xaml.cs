using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        protected override async void OnStart()
        {
            AppCenter.Start("ios=9de751a1-17a2-46a5-a082-41911f615657;android=b3744649-43bb-431e-9665-7b459cc2d16c",
                typeof(Analytics), typeof(Crashes));

            var didAppCrashed = await Crashes.HasCrashedInLastSessionAsync();
            if(didAppCrashed)
            {
                await MainPage.DisplayAlert("I'm sorry", "It apears some issues", "Ok");
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
