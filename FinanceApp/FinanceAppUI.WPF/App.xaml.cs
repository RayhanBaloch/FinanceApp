using System.Configuration;
using System.Data;
using System.Windows;

namespace FinanceAppUI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Setup your DI container here
            var viewModel = new MainWindowViewModel(); // or resolve from DI container
            var mainWindow = new MainWindow(viewModel);
            mainWindow.Show();
        }
    }

}
