namespace Model;

public class Animal : ObservableObject
{
    protected string _name;
    protected bool _isHungry;
    
    public string Name {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnNotifyPropertyChanged();
            }
        }
    }

    public bool IsHungry
    {
        get { return _isHungry; }
        set
        {
            if (_isHungry != value)
            {
                _isHungry = value;
                OnNotifyPropertyChanged();
            }
        }
    }

    public Animal(string name, bool isHungry)
    {
        Name = name;
        IsHungry = isHungry;
    }
}