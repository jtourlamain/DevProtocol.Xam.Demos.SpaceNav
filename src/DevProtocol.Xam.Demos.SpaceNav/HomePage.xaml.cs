using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DevProtocol.Xam.Demos.SpaceNav
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new DetailPage());
        }
    }
}
