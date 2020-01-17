using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace ReadBooks
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            //todo adding logging
            AppCenterHelper.TrackEvent("logged_in");
            await  Navigation.PopModalAsync(true);
        }
    }
}
