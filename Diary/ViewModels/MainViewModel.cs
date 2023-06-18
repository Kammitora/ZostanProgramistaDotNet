using Diary.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Diary.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            RefreshStudentsCommand = new RelayCommand(RefreshStudents, CanRefreshStudents);
        }

        public ICommand RefreshStudentsCommand { get; set; }

        private string _test = "XXX";
        public string Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged();
            }
        }
        private void RefreshStudents(object obj)
        {
            //MessageBox.Show("RefreshStudents");
            Test = "YYY";
        }

        private bool CanRefreshStudents(object obj)
        {
            return true;
        }
    }
}
