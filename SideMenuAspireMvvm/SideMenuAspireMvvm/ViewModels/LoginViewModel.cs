using System;
using MvvmAspire;
using Xamarin.Forms;

namespace SideMenuAspireMvvm.ViewModels
{
    public class LoginViewModel : AppViewModel
    {
        public RelayCommand LoginCommand { get; set; }

        public string _buttonName;
        public string ButtonName
        {
            get => _buttonName;
            set => SetProperty(ref _buttonName, value);
        }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            ButtonName = "Login";
        }

        async void Login()
        {
            LoginCommand.CanRun = false;
            await Navigation.PushAsync<MasterNavigationPageViewModel>();
            LoginCommand.CanRun = true;

        }


    }
}
