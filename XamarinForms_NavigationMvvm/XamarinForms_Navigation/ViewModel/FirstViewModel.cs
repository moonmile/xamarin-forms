using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms_Navigation
{
    public class FirstViewModel : BindableBase
    {
        protected MyModel _model;
        public FirstViewModel(MyModel model)
        {
            _model = model;
        }
        public string Name
        {
            get { return _model.Name; }
            set
            {
                if (_model.Name != value)
                {
                    _model.Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
        public string Age
        {
            get { return _model.Age.ToString(); }
            set
            {
                if (_model.Age.ToString() != value)
                {
                    _model.Age = int.Parse(value);
                    this.OnPropertyChanged("Age");
                }
            }
        }

    }
}
