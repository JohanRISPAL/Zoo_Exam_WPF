using System;
using System.Globalization;
using System.Windows.Data;
using Model;

namespace Zoo.Converter;

public class DisplayAnimalTypeConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            if (typeof(Licorn) == value.GetType()) return "Espèce : Licorne";

            if (typeof(Platypus) == value.GetType()) return "Espèce : Ornithorynque";
            
            if (typeof(Pony) == value.GetType()) return "Espèce : Poney";
        }
        
        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}