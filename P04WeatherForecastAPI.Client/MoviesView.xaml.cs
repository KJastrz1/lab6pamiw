using P04WeatherForecastAPI.Client.ViewModels;
using System.Windows;


namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for MoviesView.xaml
    /// </summary>
    public partial class MoviesView : Window
    {
        public MoviesView(MoviesViewModel MoviesViewModel)
        {
            DataContext = MoviesViewModel;
            InitializeComponent();
        }
    }
}
