using System.Windows.Input;

namespace MVVM_Template.Core
{
    public class CommandBase : ICommand
    {
        private readonly Action<object?> execute;
        private readonly Func<object?, bool> canExecute;

        //Inherit from ICommand
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        //Constructor
        public CommandBase(Action<object?> execute, Func<object?, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        //Button is Enabled? (if no parameter -> its enabled(true)) || Inherit from ICommand
        public bool CanExecute(object? parameter)
        {
            if(parameter == null) { return true; }

            return canExecute(parameter);
        }

        //On Button is pressed || Inherit from ICommand
        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
