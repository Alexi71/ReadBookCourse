using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadBooks
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("login_intent");
            await Navigation.PushModalAsync(new LoginPage());
            
          
        }

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("add_book_intend");
            await Navigation.PushAsync(new NewBookPage());
        }
    }
}
