using System;
using Xamarin.Forms;

namespace XamarinForms_Navigation
{
    public class SecondPage : ContentPage
    {
        public SecondPage(string[] str)
        {
            this.Title = "Second page";
            this.Padding = new Thickness(5, 10);
            this.Content = new Label { 
                    Text = "Your name is " + str[0] + " Your age is " + str[1],
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };
        }
    }
}

