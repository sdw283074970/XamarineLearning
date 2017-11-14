using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HellowWorld
{
    public partial class DailPage : ContentPage
    {
        public DailPage()
        {
            InitializeComponent();
        }
	void Handle_Clicked(object sender, System.EventArgs e)
	{
		var button = sender as Button;
		label.Text = String.Concat(label.Text, button.Text);
	}
	void Handle_Clicked_Dail(object sender, System.EventArgs e)
	{
		DisplayAlert("Error", "Out of service", "OK");
	}
    }
}
