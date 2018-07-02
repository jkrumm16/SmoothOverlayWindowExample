using System;
using System.Windows.Input;

namespace WpfApp
{
    public class SimpleRelayCommand : ICommand
    {
        private Action _commandAction;
        private Func<bool> _canExecuteCommand;

        public event EventHandler CanExecuteChanged
        {

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SimpleRelayCommand(Action commandAction, Func<bool> canExecuteCommand = null)
        {
            _commandAction = commandAction;
            _canExecuteCommand = canExecuteCommand;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteCommand == null) return true;

            return _canExecuteCommand.Invoke();
        }

        public void Execute(object parameter)
        {
            _commandAction.Invoke();
        }
    }
}
