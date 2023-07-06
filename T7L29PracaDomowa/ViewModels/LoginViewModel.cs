using System;
using System.Windows;
using System.Windows.Input;
using T7L29PracaDomowa.Commands;
using T7L29PracaDomowa.Models;
using T7L29PracaDomowa.Views;

namespace T7L29PracaDomowa.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            ConfirmCommand = new RelayCommand(Confirm);
            CancelCommand = new RelayCommand(Cancel);
        }

        public ICommand ConfirmCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        private string _user;

        public string User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        private string _password;

        private void Cancel(object obj)
        {
            Application.Current.Shutdown();
        }

        private void Confirm(object obj)
        {
            var loginParams = obj as LoginParams;
            _password = loginParams.PasswordBox.Password;
            if (Login())
            {
                (obj as Window).Close();
                var mainWindow = new MainWindow();
                _ = mainWindow.ShowDialog();
            }
        }

        private bool Login()
        {
            return _user == "User" && _password == "4";
        }
    }
}
