using AutoMotoApp.Commands;
using AutoMotoApp.Data;
using AutoMotoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace AutoMotoApp.ViewModels
{
    public class MotorcycleViewModel : BaseViewModel
    {
        public ICommand ChangeTypeCommand { get { return _motorcycleModelProperty.ChangeTypeCommand; } }

        public MotorcycleViewModel()
        {
            _motorcycleModelProperty = new MotorcycleModel();
        }


        private MotorcycleModel _motorcycleModelProperty;
        public MotorcycleModel MotorcycleModelProperty
        {
            get
            {
                return _motorcycleModelProperty;
            }
            set
            {
                _motorcycleModelProperty = value;
                OnPropertyChanged(nameof(MotorcycleModelProperty));
            }
        }
    }
}