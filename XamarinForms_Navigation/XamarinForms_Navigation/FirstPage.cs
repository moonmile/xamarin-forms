using System;
using Xamarin.Forms;

namespace XamarinForms_Navigation
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            var editorName = new Entry {
                    Keyboard = Keyboard.Text,
                    Placeholder = "Input your name.",
                };
            var editorAge = new Entry {  
                    Keyboard = Keyboard.Numeric,
                    Placeholder = "Input your age.",
                };
            var button = new Button {
                    Text = "Push me",
                    HorizontalOptions = LayoutOptions.Fill,
                };
            button.Clicked += (sender, e) =>
                {
                    string[] yourData = { editorName.Text, editorAge.Text };
                    Navigation.PushAsync(new SecondPage(yourData));
                };

            this.Title = "First page";
            this.Padding = new Thickness(5, 10);
            this.Content = new StackLayout { 
                    Children = {
                            editorName,
                            editorAge,
                            button
                        },
                };
        }
    }
}

