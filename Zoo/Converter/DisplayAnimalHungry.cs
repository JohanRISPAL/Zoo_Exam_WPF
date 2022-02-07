using System;
using System.Globalization;
using System.Windows.Data;
using Model;

namespace Zoo.Converter;

public class DisplayAnimalHungry : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            Animal animal = value as Animal;

            if (animal.IsHungry)
            {
                return "Non";
            }

            return "Oui";
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}