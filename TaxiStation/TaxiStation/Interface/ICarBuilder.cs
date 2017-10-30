using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Enum;

namespace TaxiStation.Interface
{
    public interface ICarBuilder
    {
        void CreateCar();
        void SetBrand(Brand brand);
        void SetModel(String model);
        void SetCarcas(Carcass carcass);
        void SetPriceCar(int priceCar);
        void SetMaxSpeed(int maxSpeed);
        void SetFuelConsumption(int fuelConsumption);

        void AddAirConditioning();
        void AddHeatingSeats();  
        void AddVentilationSeats();
        void AddZonalClimateControl();
        void AddMiniBar();
    }
}
