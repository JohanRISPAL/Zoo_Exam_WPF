using System.Windows;
using System.Windows.Controls;
using Model;

namespace Zoo.UserControls;

public partial class AnimalDetailUC : UserControl
{
    private static readonly DependencyProperty AnimalProperty = 
        DependencyProperty.Register("Animal", typeof(Animal), typeof(AnimalDetailUC));

    private Animal _animal;

    public Animal? Animal
    {
        get { return GetValue(AnimalProperty) as Animal; }
        set
        {
            if (_animal != value)
            {
                SetValue(AnimalProperty, value);
            }
        }
    }
    public AnimalDetailUC()
    {
        InitializeComponent();
    }
}