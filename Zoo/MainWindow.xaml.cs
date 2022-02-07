using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IEnumerable<Animal> _animals
            = ((App) Application.Current).Animals;

        public AnimalList AnimalList { get; set; } = new AnimalList();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadAnimal(object sender, RoutedEventArgs e)
        {
            AnimalList.Animals = new ObservableCollection<Animal>(_animals);
        }
    }
}