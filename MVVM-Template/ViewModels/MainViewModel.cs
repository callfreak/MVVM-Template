using MVVM_Template.Core;

namespace MVVM_Template.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //The current ViewModel is returning from the ViewModel stored in navigation store
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            //Subscribe to the Invoke
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        //Invoked when the CurrentViewModelChanged
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
