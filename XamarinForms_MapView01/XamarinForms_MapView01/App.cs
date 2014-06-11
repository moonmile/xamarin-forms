using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamarinForms_MapView01
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			Map map = new Map ();
			Position position = new Position (35.681382, 139.766084);
			map.MoveToRegion (new MapSpan (position,0.01,0.01));
			map.Pins.Add (new Pin 
				{
					Label = "東京駅はここです",
					Position = position,
				});
			return new ContentPage { 
				Content = new StackLayout {
					Children = {
						map,
					},
				},
			};

//			return new ContentPage { 
//				Content = new Map (MapSpan.FromCenterAndRadius (new Position (35.681382, 139.766084), Distance.FromKilometers (0.3)))
//			};
		}
	}
}

