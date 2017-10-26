using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation
{
    public abstract class InternalСombustionEngineCar: Car
    {
        public int TankCapacity { get; set; } // Объем бака
        public int FuelRemainder { get; set; } // Остаток топлива
        public int FuelConsumption { get; set; }  // Расход топлива
    }
}
