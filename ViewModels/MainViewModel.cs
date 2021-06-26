using AutoMotoApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoMotoApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand NavigateCommand { get; set; }

        public MainViewModel()
        {
            NavigateCommand = new NavigateCommand(this);
        }
    }
}
