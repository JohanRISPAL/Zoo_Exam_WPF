using System.Collections.ObjectModel;

namespace Model;

public class AnimalList : ObservableObject
{
    private ObservableCollection<Animal> _animals;

    private Animal _currantAnimal;

    public AnimalList()
    {
        _animals = new ObservableCollection<Animal>();
    }
    
    public Animal CurrentAnimal
    {
        get { return _currantAnimal; }
        set
        {
            if (_currantAnimal != value)
            {
                _currantAnimal = value;
                OnNotifyPropertyChanged();
            }
        }
    }


    public ObservableCollection<Animal> Animals
    {
        get { return _animals; }
        set
        {
            if (_animals != value)
            {
                _animals = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}