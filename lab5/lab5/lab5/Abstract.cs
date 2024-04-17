using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
     interface ICarrier
    {
       int CalculateTravelTime(int distance, int averageSpeed);
       int CalculateCost(int distance, int averageSpeed);

    }
}

