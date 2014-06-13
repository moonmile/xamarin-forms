using System;
using Xamarin.Forms;

namespace XamarinForms_TabbedPage
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			var tabPage1 = new ContentPage () { 
				Title = "Page 1",
				Icon = "1.png",
				Content = new Label { 
					Text = "Page 1 Label",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
				},
			};

			var label = new Label { 
				Text = "Page 2 Label",
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
			};

			var button = new Button {
				Text = "Page Name",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			var tabPage2 = new ContentPage () { 
				Title = "Page 2",
				Icon = "2.png",
				Content = new StackLayout {
					Children = {
						label,
						button,
					},
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
				},
				BackgroundColor = Color.FromHex("666666"),
			};

			var mainPage = new TabbedPage { 
				Children = {
					tabPage1,
					tabPage2,
				},
			};

			button.Clicked += (sender, e) => {
				mainPage.DisplayAlert("Alert Title", mainPage.CurrentPage.Title + " is selected.", "OK", "Cancel");
			};

			return mainPage;

		}
	}
}

