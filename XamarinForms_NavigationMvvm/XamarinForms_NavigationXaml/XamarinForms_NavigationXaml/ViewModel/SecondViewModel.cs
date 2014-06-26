using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms_NavigationXaml
{
    public class SecondViewModel :BindableBase
    {
        protected MyModel _model;
        public SecondViewModel(MyModel model)
        {
            _model = model;
        }

        public string NameAndAge
        {
            get
            {
                return
                    string.Format("Your name is {0} Your age is {1}", 
                    _model.Name, _model.Age);
            }
        }

    }
}
