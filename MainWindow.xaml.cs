using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace mrmr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        private Films selectedFilms;

        public List<Films> Film { get; set; }
        public Films SelectedFilm
        {
            get => selectedFilms;
            set
            {
                selectedFilms = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(SelectedFilm)));
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            Film = new List<Films>();
            Film.Add(new Films
            {
                Name = "Five Nigts At Freddy",
                Janr = "Ужасы",
                Year = "2023"
            });
            Film.Add(new Films
            {
                Name = "Барби",
                Janr = "Комедия",
                Year = "2023"
            });
            Film.Add(new Films
            {
                Name = "Оно",
                Janr = "Ужасы",
                Year = "2017"
            });
            Film.Add(new Films
            {
                Name = "Ходячий замок",
                Janr = "Мелодрама",
                Year = "2004"
            });
            DataContext = this;
        }

           public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = SelectedFilm == null ?
                "Ничего не выбрано" :
                SelectedFilm.ToString();
            MessageBox.Show(message);
        }

    }
}

    

