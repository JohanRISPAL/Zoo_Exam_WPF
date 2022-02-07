using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Model;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public LoadAnimals LoadAnimals;

        public IEnumerable<Animal> Animals;

        public App()
        {
            Animals = new LoadAnimals().Animals;
        }
    }
}