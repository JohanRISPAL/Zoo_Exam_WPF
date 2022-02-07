namespace Model;

public class Platypus : Animal
{

    public int _stockFatTail;
    public Platypus(string name, bool isHungry, int stockFatTail) : base(name, isHungry)
    {
        StockFatTail = stockFatTail;
    }
    
    public int StockFatTail
    {
        get { return _stockFatTail; }
        set
        {
            if (_stockFatTail != value)
            {
                _stockFatTail = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}