using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Checkers.Commands
{
    class RelayCommand<T> : ICommand
    {
        private Action<T> commandAct;
        private Predicate<T> canDoAct;

        public RelayCommand(Action<T> toDo) : this(toDo, null)
        {
        }

        public RelayCommand(Action<T> toDo, Predicate<T> canDo)
        {
            commandAct = toDo;
            canDoAct = canDo;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canDoAct == null || canDoAct((T)parameter);
        }

        public void Execute(object parameter)
        {
            commandAct((T)parameter);
        }
    }
}
