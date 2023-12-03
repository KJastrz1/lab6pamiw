using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.Commands;
using P04WeatherForecastAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    // przekazywanie wartosci do innego formularza 
    public partial class MainViewModelV4 : ObservableObject
    {
        [ObservableProperty]
        private string message = "";
        private readonly IServiceProvider _serviceProvider;

        public MainViewModelV4(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

      

        [RelayCommand]
        public void OpenMoviesWindow()
        {
            if (!string.IsNullOrEmpty(LoginViewModel.Token))
            {
                MoviesView moviesView = _serviceProvider.GetService<MoviesView>();
                MoviesViewModel moviesViewModel = _serviceProvider.GetService<MoviesViewModel>();
                moviesView.Show();
                moviesViewModel.GetMovies();
            }
            else
            {
                Message = "You need to login first!";
            }
        }

        [RelayCommand]
        public void OpenLoginWindow()
        {
            LoginView loginView = _serviceProvider.GetService<LoginView>();
            LoginViewModel loginViewModel = _serviceProvider.GetService<LoginViewModel>();
            loginView.Show();
        }
    }


}

