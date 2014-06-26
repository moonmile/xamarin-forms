using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms_NavigationXaml.View
{
    public partial class FirstPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        public void OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(
                new SecondPage()
                {
                    BindingContext = new SecondViewModel(App.model)
                });
        }
    }
}
