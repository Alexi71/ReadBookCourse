using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadBooks
{
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            var book = new Books() { Author = "Alex", Name = "Der Master" };
            book.SaveBook();
            
        }
    }
}
