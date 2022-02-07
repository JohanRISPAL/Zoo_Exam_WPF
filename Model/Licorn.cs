namespace Model;

public class Licorn : Animal
{
    public int _cornLenght;
    public Licorn(string name, bool isHungry, int cornLenght) : base(name, isHungry)
    {
        CornLength = cornLenght;
    }
    
    public int CornLength
    {
        get { return _cornLenght; }
        set
        {
            if (_cornLenght != value)
            {
                _cornLenght = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}