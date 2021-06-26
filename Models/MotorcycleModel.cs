using AutoMotoApp.Commands;
using AutoMotoApp.Data;
using AutoMotoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace AutoMotoApp.Models
{
    public class MotorcycleModel : BaseViewModel
    {
        public List<MotorcycleModel> motorcyclesList = new List<MotorcycleModel>();
        public ICommand ChangeTypeCommand { get; set; }
        public MotorcycleModel()
        {
            motorcyclesList = Motorcycles.Instance.GetMotorcyclesList();
            ChangeTypeCommand = new ChangeTypeCommand(this);
        }
        public MotorcycleModel(string _typeArrived, SolidColorBrush _typeColorArrived, string imageSourceLink)
        {
            Type = _typeArrived;
            TypeColor = _typeColorArrived;
            ImageLink = imageSourceLink;
        }

        private string _imageLink = "/Resources/hondaImage.png";
        public string ImageLink
        {
            get
            {
                return _imageLink;
            }
            set
            {
                _imageLink = value;
                OnPropertyChanged(nameof(ImageLink));
            }
        }

        private string _type = "HONDA";
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
                OnPropertyChanged(nameof(MotorcyclePosition));

            }
        }

        private SolidColorBrush _typeColor = Brushes.Orange;
        public SolidColorBrush TypeColor
        {
            get
            {
                return _typeColor;
            }
            set
            {
                _typeColor = value;
                OnPropertyChanged(nameof(TypeColor));
            }
        }


        private int _motorcyclePosition = 1;
        public int MotorcyclePosition
        {
            get
            {
                _motorcyclePosition = Helpers.RandomFunctions.ReturnRandomNumber(Motorcycles.Instance.GetMotorcyclesList().Count);
                return _motorcyclePosition;
            }
            set
            {
                _motorcyclePosition = value;
                OnPropertyChanged(nameof(MotorcyclePosition));
            }
        }



    }
}
