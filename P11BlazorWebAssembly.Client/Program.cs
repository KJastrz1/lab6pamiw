using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.Services.MovieService;

using P11BlazorWebAssembly.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
var appSettingsSection = appSettings.Get<AppSettings>();


var uriBuilderMovies = new UriBuilder(appSettingsSection.BaseAPIUrl)
{
    // Path = appSettingsSection.BaseMovieEndpoint.Base_url,
};
//Microsoft.Extensions.Http
builder.Services.AddHttpClient<IMovieService, MovieService>(client => client.BaseAddress = uriBuilderMovies.Uri);

builder.Services.AddSingleton<IOptions<AppSettings>>(new OptionsWrapper<AppSettings>(appSettingsSection));


await builder.Build().RunAsync();
