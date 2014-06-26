簡単な解説
==========

複数ページ（FirstPage, SecondPage)のナビゲーションで、データの受け渡しをします。

MVVM パターンを用いて
- ひとつの Model( MyModel )
 - Name : string 
 - Age  : int
- ２つの　View ( FirstPage, SecondPage )
 - FirstView : Name, Age
 - SecondView : NameAndAge string 

がある場合、View にあわせて ViewModel を作る。

- 2つの ViewModel ( FirstViewModel, SecondViewModel )
 - FistViewModel : Name, Age
 - SecondViewModel : NameAndAge 
 
アプリケーションに対して、Model がひとつだけなので、static App.Model にして、唯一の Model にする。

App.cs
```
public class App
{
    public static MyModel model = new MyModel();

    public static Page GetMainPage()
    {
        return new NavigationPage(new FirstPage(new FirstViewModel(App.model)));
    }
}
```

MyModel.cs

```
public class MyModel 
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

FirstViewModel の Age プロパティは本来はテキストコンバータを作るところなのですが、面倒なので ViewModel 内で Parse

```
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
```

FirstPage でのバインド

```
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
```

とコードでやってもよいし、XAML を使って

```
<Entry Text="{Binding Name}" ... />
```

とやってもOK。


