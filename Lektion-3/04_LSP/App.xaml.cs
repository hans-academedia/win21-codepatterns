using _04_LSP.Helpers;
using _04_LSP.MVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _04_LSP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? app { get; set; }

        public App()
        {
            app = Host.CreateDefaultBuilder().ConfigureServices((context, services) => {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<NavigationStore>();
            }).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            var navStore = app!.Services.GetRequiredService<NavigationStore>();
            navStore.CurrentViewModel = new UserViewModel(navStore);

            
            
            var MainWindow = app!.Services.GetRequiredService<MainWindow>();
            MainWindow.DataContext = new MainViewModel(navStore);
            MainWindow.Show();

            await app!.RunAsync();
            base.OnStartup(e);
        }
    }
}
