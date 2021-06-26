using AutoMotoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AutoMotoApp.Data
{
    public sealed class Motorcycles
    {
        private Motorcycles() { }
        private static Motorcycles instance = null;
        public static Motorcycles Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Motorcycles();
                }
                return instance;
            }
        }

        private List<MotorcycleModel> motorcyclesList = new List<MotorcycleModel>()
                {
                new MotorcycleModel("HONDA", Brushes.Orange, "/Resources/hondaImage.png"),
                new MotorcycleModel("DUCATI", Brushes.Red, "/Resources/ducatiImage.png"),
                new MotorcycleModel("YAMAHA", Brushes.Blue, "/Resources/yamahaImage.jpg"),
                new MotorcycleModel("KTM", Brushes.Green, "/Resources/ktmImage.jfif"),
                new MotorcycleModel("APRILIA", Brushes.Yellow, "/Resources/apriliaImage.jpg")
                };

        public MotorcycleModel GetMotorcycle()
        {
            return motorcyclesList[0];
        }

        public List<MotorcycleModel> GetMotorcyclesList()
        {
            return motorcyclesList;
        }



    }
}