using System;
using Xamarin.Forms;

namespace XamarinForms_Navigation
{
    public class SecondPage : ContentPage
    {
        private SecondViewModel _vm;
        public SecondPage(SecondViewModel vm)
        {
            this._vm = vm;

            this.Title = "Second page";
            this.Padding = new Thickness(5, 10);

            var label = 

            new Label { 
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };

            this.BindingContext = _vm;
            label.SetBinding(Label.TextProperty, "NameAndAge");

            this.Content = label;

        }
    }
}

