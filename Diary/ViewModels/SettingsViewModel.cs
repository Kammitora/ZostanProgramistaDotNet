using Diary.Commands;
using Diary.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Diary.ViewModels
{
    class SettingsViewModel : ViewModelBase
    {
        public SettingsViewModel()
        {
            ConfirmCommand = new RelayCommand(ApplyChanges);
            CancelCommand = new RelayCommand(Close);
        }
        public ICommand CancelCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        private SettingsWrapper _settings =  new SettingsWrapper();
        public SettingsWrapper Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;
                OnPropertyChanged();
            }
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void ApplyChanges(object obj)
        {
            Properties.Settings.Default.ServerAddress = _settings.ServerAddress;
            Properties.Settings.Default.ServerName = _settings.ServerName;
            Properties.Settings.Default.DatabaseName = _settings.DatabaseName;
            Properties.Settings.Default.User = _settings.User;
            Properties.Settings.Default.Password = _settings.Password;
            Properties.Settings.Default.Save();
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
