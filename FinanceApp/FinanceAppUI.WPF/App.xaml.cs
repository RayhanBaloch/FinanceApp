using FinanceAppUI.WPF.Pages;
using Microsoft.Extensions.DependencyInjection;
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
        public static IServiceProvider Services { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            // Register ViewModels
            services.AddSingleton<ShellViewModel>();
            services.AddTransient<HomePageViewModel>();

            // Register services (example)
            // services.AddSingleton<IMyService, MyService>();

            Services = services.BuildServiceProvider();

            base.OnStartup(e);
        }
    }

}
