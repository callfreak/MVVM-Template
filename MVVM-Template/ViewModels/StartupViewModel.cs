using MVVM_Template.Core;

namespace MVVM_Template.ViewModels
{
    public class StartupViewModel(NavigationStore navigationStore) : ViewModelBase(navigationStore)
    {
        //Example Integer
        private int exampleVar;
        public int ExampleProperty 
        { 
            get 
            { 
                return exampleVar; 
            } 
            set 
            {
                exampleVar = value; 
                OnPropertyChanged(nameof(ExampleProperty));
            }
        }

        //Describing a Button
        public CommandBase NavigateToLogin => new CommandBase
            (
                action => StartNavigate()
            );

        public void StartNavigate()
        {
            //StartNavigateTo (from the ViewModelBase) -> new LoginViewModel will return that we switch to the LoginView
            StartNavigateTo(new LoginViewModel(_navigationStore));
        }
    }
}
