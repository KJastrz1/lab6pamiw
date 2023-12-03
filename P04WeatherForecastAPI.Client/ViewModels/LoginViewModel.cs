using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P06Shop.Shared.Auth;
using P06Shop.Shared.Services.AuthService;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string message = "";

        private readonly IAuthService _authService;
        public static string Token { get; set; } = string.Empty;

        public LoginViewModel(IAuthService authService)
        {
            UserLoginDTO = new UserLoginDTO();
            _authService = authService;
        }

        [ObservableProperty]
        private UserLoginDTO userLoginDTO;

        public async Task Login(string password)
        {
            UserLoginDTO.Password = password;
            var response = await _authService.Login(UserLoginDTO);
            if (response.Success)
            {
                Token = response.Data;

         

            }
            else
            {
               Message= response.Message;
            }
        }

        [RelayCommand]
        public async Task MouseEnter()
        {
         
        }

       
    }
}
