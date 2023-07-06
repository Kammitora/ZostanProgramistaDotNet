using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using T7L29PracaDomowa.ViewModels;

namespace T7L29PracaDomowa.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            //Login();
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Login()
        {
            LoginWindow loginWindow = new LoginWindow();
            _ = loginWindow.ShowDialog();
        }
        
    }
}
