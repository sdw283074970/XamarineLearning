using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HellowWorld
{
    public partial class PayPage2 : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var response = await DisplayActionSheet("How much would u donate?", "Cancel", "Delete", "$0.99", "$4.99", "$14.99");
            await DisplayAlert("Response", "Paid " + response + " successfully", "Ok");
        }

        public PayPage2()
        {
            InitializeComponent();
        }
    }
}
