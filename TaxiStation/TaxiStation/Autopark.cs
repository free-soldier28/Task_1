using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation
{
    public class Autopark
    {
        public long CalculateAutoparkCost(List<Car> cars)
        {
            long cost = 0;
            foreach (Car car in cars)
            {
                cost += car.PriceCar;
            }
            return cost;
        }
    }
}
