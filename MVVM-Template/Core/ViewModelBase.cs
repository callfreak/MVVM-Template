using System.ComponentModel;

namespace MVVM_Template.Core
{
    public class ViewModelBase(NavigationStore navigationStore) : INotifyPropertyChanged
    {
        protected readonly NavigationStore _navigationStore = navigationStore;

        public event PropertyChangedEventHandler? PropertyChanged;

        //Did any View Property change in the Backend? Raise this event to update the View
        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        //Start the Navigation to a new ViewModel and its View
        protected void StartNavigateTo(ViewModelBase newViewModel) 
        { 
            _navigationStore.CurrentViewModel = newViewModel;
        }

    }
}
