using System;
using System.Globalization;
using System.Windows.Data;
using Model;

namespace Zoo.Converter;

public class DisplayAnimalSpecificity : IValueConverter
{
    public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            if (typeof(Licorn) == value.GetType())
            {
                Licorn licorn = value as Licorn;
                return "Longueur de la corne : " + licorn.CornLength;
            }

            if (typeof(Platypus) == value.GetType()) 
            {
                Platypus platypus = value as Platypus;
                return "Pourcentage de graisse dans la queue : " + platypus.StockFatTail + "%";
            }

            if (typeof(Pony) == value.GetType())
            {
                Pony pony = value as Pony;
                return "Couleur de la crinière : " + pony.ManeColor;
            }
        }
        
        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}