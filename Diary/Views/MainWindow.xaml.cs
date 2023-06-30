using Diary.ViewModels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diary.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
            DataContext = new MainViewModel();

            }
            catch (Exception)
            {
                _ = HandleProblemWithConnectionString();
            }

        }

        private async Task HandleProblemWithConnectionString()
        {
            var metroWindow = Application.Current.MainWindow as MetroWindow;
            var dialog = await metroWindow.ShowMessageAsync(
                "Błędny ConnectionString",
                $"Twój connection string prawdopodobnie jest nieprawidłowy. Czy chcesz zmienić ustawienia?",
                MessageDialogStyle.AffirmativeAndNegative);

            if (dialog != MessageDialogResult.Affirmative)
            {
                Close();
            }
            else
            {
                var settingWindow = new SettingsWindow();
                settingWindow.ShowDialog();
                RestartApplication();
            }
        }

        private static void RestartApplication()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
