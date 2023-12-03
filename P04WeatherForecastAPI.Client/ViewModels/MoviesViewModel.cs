using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services.SpeechService;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;


namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class MoviesViewModel : ObservableObject
    {
        private readonly IMovieService _MovieService;
        private readonly MovieDetailsView _MovieDetailsView;
        private readonly IMessageDialogService _messageDialogService;
        private readonly ISpeechService _speechService;

        public ObservableCollection<Movie> Movies { get; set; }



        [ObservableProperty]
        private Movie selectedMovie;



        public MoviesViewModel(IMovieService MovieService, MovieDetailsView MovieDetailsView,
            IMessageDialogService messageDialogService, ISpeechService speechService)
        {
            _messageDialogService = messageDialogService;
            _speechService = speechService;
            _MovieDetailsView = MovieDetailsView;
            _MovieService = MovieService;
            Movies = new ObservableCollection<Movie>();
        }

        public async Task GetMovies()
        {
            Movies.Clear();
            var MoviesResult = await _MovieService.GetMoviesAsync();
            if (MoviesResult.Success)
                foreach (var p in MoviesResult.Data)
                    Movies.Add(p);
            else
                _messageDialogService.ShowMessage(MoviesResult.Message);
        }


        public async Task CreateMovie()
        {
            var newMovie = new Movie()
            {
                Title = selectedMovie.Title,
                Director = selectedMovie.Director,
             
            };

            var result =  await _MovieService.CreateMovieAsync(newMovie);
            if (result.Success)
                await GetMovies();
            else
                _messageDialogService.ShowMessage(result.Message);  
        }

        public async Task UpdateMovie()
        {
            var MovieToUpdate = new Movie()
            {
                Id = selectedMovie.Id,
                Title = selectedMovie.Title,
                Director = selectedMovie.Director,
               
            };

            await _MovieService.UpdateMovieAsync(MovieToUpdate);
            GetMovies();
        }

        public async Task DeleteMovie()
        {
            await _MovieService.DeleteMovieAsync(selectedMovie.Id);
            await GetMovies();
        }

        [RelayCommand]
        public async Task ShowDetails(Movie Movie)
        {
            _MovieDetailsView.Show();
            _MovieDetailsView.DataContext = this;
            //selectedMovie = Movie;
            //OnPropertyChanged("SelectedMovie");
            SelectedMovie = Movie;
        }


        [RelayCommand]
        public async Task Save()
        {
            if (selectedMovie.Id == 0)
            {
                CreateMovie();
            }
            else
            {
                UpdateMovie();
            }

        }

        [RelayCommand]
        public async Task Delete()
        {
            DeleteMovie();
        }

        [RelayCommand]
        public async Task New()
        {
            _MovieDetailsView.Show();
            _MovieDetailsView.DataContext = this;
            //selectedMovie = new Movie();
            //OnPropertyChanged("SelectedMovie");
            SelectedMovie = new Movie(); 
        }
      
    }
}
