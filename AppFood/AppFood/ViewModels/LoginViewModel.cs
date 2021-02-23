using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
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

        public LoginViewModel()
        {

        }
    }
}
