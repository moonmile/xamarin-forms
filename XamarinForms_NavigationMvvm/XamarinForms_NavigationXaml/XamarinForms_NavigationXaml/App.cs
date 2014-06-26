using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinForms_NavigationXaml
{
    public class App
    {
        public static MyModel model = new MyModel();

        public static Page GetMainPage()
        {
            return new NavigationPage( 
                new View.FirstPage() {
                    BindingContext = new FirstViewModel(App.model)
            });
        }
    }
}
