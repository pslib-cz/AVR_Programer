using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AVR_Programer
{
    class Command : ICommand
    {
        Action<object> executeMethod;
        Func<object, bool> canexecuteMethod;
        public event EventHandler CanExecuteChanged;

        public Command(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}

