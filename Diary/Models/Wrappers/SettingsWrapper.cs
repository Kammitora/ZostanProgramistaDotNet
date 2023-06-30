using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Diary.Models.Wrappers
{
    public class SettingsWrapper
    {
        public string ServerAddress 
        {
            get 
            {
                return Properties.Settings.Default.ServerAddress;
            } 
            set 
            {
                Properties.Settings.Default.ServerAddress = value;
            } 
        }
        public string ServerName
        {
            get
            {
                return Properties.Settings.Default.ServerName;
            }
            set
            {
                Properties.Settings.Default.ServerName = value;
            }
        }
        public string DatabaseName
        {
            get
            {
                return Properties.Settings.Default.DatabaseName;
            }
            set
            {
                Properties.Settings.Default.DatabaseName = value;
            }
        }
        public string User
        {
            get
            {
                return Properties.Settings.Default.User;
            }
            set
            {
                Properties.Settings.Default.User = value;
            }
        }
        public string Password
        {
            get
            {
                return Properties.Settings.Default.Password;
            }
            set
            {
                Properties.Settings.Default.Password = value;
            }
        }
    }
}
