using System;
using Xamarin.Forms;

namespace XamarinForms_Navigation
{
    public class App
    {
        public static Page GetMainPage()
        {	
            return new NavigationPage(new FirstPage());
        }
    }
}

