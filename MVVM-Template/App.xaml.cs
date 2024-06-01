using MVVM_Template.Core;
using MVVM_Template.ViewModels;
using MVVM_Template.Views;
using System.Windows;

namespace MVVM_Template
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //The Only NavigationStore
        private readonly NavigationStore _navigationStore;

        public App()
        {
            //Create the only NavigationStore in our app
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            //Set the Startup ViewModel
            _navigationStore.CurrentViewModel = new StartupViewModel(_navigationStore);

            //Create a new Window and the the MainViewModel to it
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            //Show the main Window
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
