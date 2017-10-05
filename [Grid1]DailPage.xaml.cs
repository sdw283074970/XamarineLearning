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

        void Handle_Clicked1(object sender, System.EventArgs e)
        {
            label.Text = String.Concat(label.Text, "1");
        }

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "2");
		}
		void Handle_Clicked3(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "3");
		}
		void Handle_Clicked4(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "4");
		}
		void Handle_Clicked5(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "5");
		}
		void Handle_Clicked6(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "6");
		}
		void Handle_Clicked7(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "7");
		}
		void Handle_Clicked8(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "8");
		}
		void Handle_Clicked9(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "9");
		}
		void Handle_Clicked0(object sender, System.EventArgs e)
		{
			label.Text = String.Concat(label.Text, "0");
		}
		void Handle_Clicked(object sender, System.EventArgs e)
		{
            DisplayAlert("Error", "Out of service", "OK");
		}
    }
}
