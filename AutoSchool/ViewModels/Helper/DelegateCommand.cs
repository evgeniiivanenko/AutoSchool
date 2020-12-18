﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoSchool.ViewModels.Helper
{
    public class DelegateCommand : ICommand
    {
        private Action<object> executionAction;

        private Predicate<object> canExexutePredicate;

        public DelegateCommand(Action<object> execute) : this(execute, null)
        {

        }

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            this.executionAction = execute;
            this.canExexutePredicate = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExexutePredicate == null ? true : this.canExexutePredicate(parameter);
        }

        public void Execute(object parameter)
        {
            if (!this.CanExecute(parameter))
            {
                throw new InvalidOperationException("The command is not valid for execution, check the CanExecute method before attempting to execute.");
            }
            this.executionAction(parameter);
        }
    }
}
