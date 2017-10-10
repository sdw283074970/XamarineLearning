using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HellowWorld
{
    public partial class ImageCirclePage : ContentPage
    {
        static public string gallary = "pa cm pom";
        static string[] ptd = gallary.Split(' ');
        public int currentNum = 0;

        public ImageCirclePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked_left(object sender, System.EventArgs e)
        {
			currentNum--;
			if (currentNum < 0)
			{
				currentNum = 2;
			}
            ic.Source = ImageSource.FromResource(ptd[currentNum]);
        }

        void Handle_Clicked_right(object sender, System.EventArgs e)
        {
            currentNum++;
            if (currentNum > ptd.Length - 1) {
                currentNum = 0;
            }
            ic.Source = ImageSource.FromResource(ptd[currentNum]);
        }
    }
}
