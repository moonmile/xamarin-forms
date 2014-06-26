using System;
using Xamarin.Forms;

namespace XamarinForms_Navigation
{
public class FirstPage : ContentPage
{
    protected FirstViewModel _vm;
    public FirstPage(FirstViewModel vm)
    {
        this._vm = vm;

        var editorName = new Entry {
                Keyboard = Keyboard.Text,
                Placeholder = "Input your name.",
            };
        var editorAge = new Entry {  
                Keyboard = Keyboard.Numeric,
                Placeholder = "Input your age.",
            };

        this.BindingContext = _vm;
        editorName.SetBinding( Entry.TextProperty, "Name");
        editorAge.SetBinding(Entry.TextProperty, "Age");

            var button = new Button {
                    Text = "Push me",
                    HorizontalOptions = LayoutOptions.Fill,
                };
            button.Clicked += (sender, e) =>
                {
                    Navigation.PushAsync(new SecondPage(new SecondViewModel(App.model)));
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

