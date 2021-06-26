using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AutoMotoApp.Helpers
{
    public static class RandomFunctions
    {
        public static Dictionary<MotorcycleType, SolidColorBrush> ReturnRandomValueFromDictionary
            (Dictionary<MotorcycleType, SolidColorBrush> TypesWithColors)
        {
            if (TypesWithColors.Count > 0)
            {
                Random random = new Random();
                int number = random.Next(0, TypesWithColors.Count);
                var keyValuePairReturning = new[] { TypesWithColors.ElementAt(number) }.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                return keyValuePairReturning;
            }
            return null;

        }

        public static int ReturnRandomNumber (int higherNumber)
        {
            if (higherNumber > 0)
            {
                Random random = new Random();
                return random.Next(0, higherNumber);
            }
            return 0;

        }
    }
}
