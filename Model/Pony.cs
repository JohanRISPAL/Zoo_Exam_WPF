namespace Model;

public class Pony : Animal
{

    public string _maneColor;
    public Pony(string name, bool isHungry, string maneColor) : base(name, isHungry)
    {
        ManeColor = maneColor;
    }
    
    public string  ManeColor
    {
        get { return _maneColor; }
        set
        {
            if (_maneColor != value)
            {
                _maneColor = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}