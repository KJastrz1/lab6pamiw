using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services;
using P04WeatherForecastAPI.Client.ViewModels;
using System.Windows;


namespace P04WeatherForecastAPI.Client
{
    //MVVM

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModelV4 _viewModel;
        public MainWindow(MainViewModelV4 viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;           
        }  

    }
}
