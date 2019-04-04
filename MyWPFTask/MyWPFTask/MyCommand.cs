using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFTask
{
    internal interface IMyCommand
    {
    }

    internal class MyCommand : IMyCommand
    {
        {​
        public ObservableCollection<Student> Collection { get; set; }​
        public bool CanExecute(object parameter)​
        {​
            return true;​
        }​
        public event EventHandler CanExecuteChanged;​
        public void Execute(object parameter)​
        {​
            Collection.Remove(parameter as Student);​
        }​
    }
}
