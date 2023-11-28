using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.MessageBox;
using P04WeatherForecastAPI.Client.Services.SpeechService;
using P04WeatherForecastAPI.Client.ViewModels;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.MovieService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        IConfiguration _configuration;
        public App()
        {
            string s = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            //wczytanie appsettings.json do konfiguracji 
            var builder = new ConfigurationBuilder()
            .AddUserSecrets<App>()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable
            ("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true);
            _configuration = builder.Build();
            // pamietac o lunch profiles w visual studio! 


            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services, appSettingsSection);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            // pobranie appsettings z konfiguracji i zmapowanie na klase AppSettings 
            //Microsoft.Extensions.Options.ConfigurationExtensions
            var appSettings = _configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();

            // services.Configure<AppSettings>(appSettings);
            services.AddSingleton(appSettingsSection);
            return appSettingsSection;
        }

        private void ConfigureAppServices(IServiceCollection services, AppSettings appSettings)
        {

            // konfiguracja serwisów           
            services.AddSingleton<IMovieService, MovieService>();
            services.AddSingleton<IMessageDialogService, WpfMesageDialogService>();
            services.AddSingleton<ISpeechService>(_ => new SpeechService(appSettings.SpeechSettings));
        }

        private void ConfigureViewModels(IServiceCollection services)
        {

            // konfiguracja viewModeli 
            services.AddSingleton<MainViewModelV4>();
            services.AddSingleton<MoviesViewModel>();

        }

        private void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddTransient<MainWindow>();
            services.AddTransient<MovieDetailsView>();
            services.AddTransient<MoviesView>();
        }

        private void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {

            };
            Console.Error.WriteLine($"Base API URL: {uriBuilder.Uri}");
            //Microsoft.Extensions.Http

            services.AddHttpClient<IMovieService, MovieService>(client => client.BaseAddress = uriBuilder.Uri);
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
