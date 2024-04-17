using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    
        public class Airplane : ICarrier
        {

            public int CalculateTravelTime(int distance, int averageSpeed)
            {
                return distance / averageSpeed;
            }

            public int CalculateCost(int distance, int  averageSpeed)
            {
                return CalculateTravelTime(distance, averageSpeed) * 100;
            }
        }

        public class CarBus : ICarrier
        {

            public int CalculateTravelTime(int distance, int averageSpeed)
            {
                return distance / averageSpeed;
            }

            public int CalculateCost(int distance, int averageSpeed)
            {
                int fuelConsumption = 10;
                int fuelPrice = 30; // Припустима вартість пального за літр
                return (fuelConsumption * distance / 100) * fuelPrice;
            }
        }

        public class Train : ICarrier
        {

            public int CalculateTravelTime(int distance, int averageSpeed)
            {
                return distance / averageSpeed;
            }

            public int CalculateCost(int distance, int averageSpeed)
            {
                return CalculateTravelTime(distance, averageSpeed) * 15;
            }
        }


        public class FlyingDevice : ICarrier
        {

            public int CalculateTravelTime(int distance, int averageSpeed)
            {
                return distance / averageSpeed;
            }

            public int CalculateCost(int distance, int averageSpeed)
            {
                return CalculateTravelTime(distance, averageSpeed) * 50;
            }
        }

        public class Helicopter : ICarrier
        {

            public int CalculateTravelTime(int distance, int averageSpeed)
            {
                return distance / averageSpeed;
            }

            public int CalculateCost(int distance, int averageSpeed)
            {
                return CalculateTravelTime(distance, averageSpeed) * 150;
            }
        }
}
