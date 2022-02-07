using System.Windows;
using System.Windows.Controls;
using Model;

namespace Zoo.UserControls;

public partial class AnimalListUC : UserControl
{
    private static readonly DependencyProperty AnimalListProperty = 
        DependencyProperty.Register("AnimalList", typeof(AnimalList), typeof(AnimalListUC));

    private AnimalList _animalList;

    public AnimalList? AnimalList
    {
        get { return GetValue(AnimalListProperty) as AnimalList; }
        set
        {
            if (_animalList != value)
            {
                SetValue(AnimalListProperty, value);
            }
        }
    }
    public AnimalListUC()
    {
        InitializeComponent();
    }
}