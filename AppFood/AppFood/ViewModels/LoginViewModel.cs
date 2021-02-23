using AppFood.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppFood.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        //propriedades para receber os dados de usuario
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; OnPropertyChanged(); }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; OnPropertyChanged(); }
        }
        private bool _isBusy;
        public bool isBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }

        private bool _Result;
        public bool Result
        {
            get { return _Result; }
            set { _Result = value; OnPropertyChanged(); }
        }


        //comandos

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private async Task RegisterCommandAsync()
        {
            if (isBusy)
                return;
            try
            {
                isBusy = true;
                var userService = new UserService();
                Result = await userService.RegistrarUsuario(Username,Password);
                if (Result)
                    await Application.Current.MainPage.DisplayAlert("BEM VINDO", "Usuario criado com sucesso", "OK");
                else
                    await Application.Current.MainPage.DisplayAlert("Erro", "O usuario já existe", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                isBusy = false;
            }
        }

        private async Task LoginCommandAsync()
        {
            if (isBusy)
                return;
            try
            {
                isBusy = true;
                var userservice = new UserService();
                Result = await userservice.LoginUsuario(Username, Password);
                if (Result) 
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ProductsView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Erro", "Não foi possível efetuar o login, usuario ou senha incorretos.", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                isBusy = false;
            }
        }
    }
}
