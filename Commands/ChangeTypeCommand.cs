using AutoMotoApp.Data;
using AutoMotoApp.Helpers;
using AutoMotoApp.Models;
using AutoMotoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace AutoMotoApp.Commands
{
    public class ChangeTypeCommand : ICommand
    {
        private readonly MotorcycleModel _vehicleModel;

        public ChangeTypeCommand(MotorcycleModel vehicleModel)
        {
            _vehicleModel = vehicleModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int positionArrived = (int)(parameter);
            _vehicleModel.Type = _vehicleModel.motorcyclesList[positionArrived].Type;
            _vehicleModel.TypeColor = _vehicleModel.motorcyclesList[positionArrived].TypeColor;
            _vehicleModel.ImageLink = _vehicleModel.motorcyclesList[positionArrived].ImageLink;

        }
    }
}
