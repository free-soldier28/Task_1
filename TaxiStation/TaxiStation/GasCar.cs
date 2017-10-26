using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation
{
    public class GasCar: GasolineCar
    {
        public int BalloonCapacity { get; set; } // Объем баллона газа
        public int GasRemainder { get; set; } // Остаток газа
        public int GasConsumption { get; set; }  // Расход газа

        protected GasCar()
        {

        }
    }
}
