using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Enum;

namespace TaxiStation
{
    public abstract class Car
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public Carcass Carcass { get; set; }

        public int PriceCar { get; set; }
        public int MaxSpeed { get; set; }
        public int FuelConsumption { get; set; }

        public bool AirConditioning { get; set; }
        public bool HeatingSeats { get; set; }  
        public bool VentilationSeats { get; set; }
        public bool ZonalClimateControl { get; set; }
        public bool MiniBar { get; set; }
    }
}
