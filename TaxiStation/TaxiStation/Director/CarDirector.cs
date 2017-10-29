using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Interface;
using TaxiStation.Enum;

namespace TaxiStation.Director
{
    public class CarDirector
    {
        ICarBuilder builder;
        public void SetBuilder(ICarBuilder _builder)
        {
            builder = _builder; 
        }

        public void ConstructCar(Brand brand, string model, Carcass carcass, int priceCar, int maxSpeed, int fuelConsumption)
        {
            builder.SetBrand(brand);
            builder.SetModel(model);
            builder.SetCarcas(carcass);
            builder.SetPriceCar(priceCar);
            builder.SetMaxSpeed(maxSpeed);
            builder.SetFuelConsumption(fuelConsumption);
            builder.AddAirConditioning();
            builder.AddHeatingSeats();
            builder.AddVentilationSeats();
            builder.AddZonalClimateControl();
        }
    }
}
