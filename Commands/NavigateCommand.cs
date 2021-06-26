using AutoMotoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoMotoApp.Commands
{
    public class NavigateCommand : ICommand
    {
        private MainViewModel viewModel;

        public NavigateCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Car")
            {
                viewModel.SelectedViewModel = new CarViewModel();
            }
            else if (parameter.ToString() == "Motorcycle")
            {
                viewModel.SelectedViewModel = new MotorcycleViewModel();
            }
            else if (parameter.ToString() == "Bus")
            {
                viewModel.SelectedViewModel = new BusViewModel();
            }
        }
    }
}