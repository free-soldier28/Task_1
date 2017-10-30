using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Interface;
using TaxiStation.Enum;

namespace TaxiStation.Builder
{
    public class VIPCarBuilder : ICarBuilder
    {
        VIPCar vipCar;

        public void CreateCar()
        {
            vipCar = new VIPCar();
        }

        public VIPCar GetCar()
        {
            return vipCar;
        }

        public void SetBrand(Brand brand)
        {
            vipCar.Brand = brand;
        }
        public void SetModel(string model)
        {
            vipCar.Model = model;
        }

        public void SetCarcas(Carcass carcass)
        {
            vipCar.Carcass = carcass;
        }

        public void SetPriceCar(int priceCar)
        {
            vipCar.PriceCar = priceCar;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            vipCar.MaxSpeed = maxSpeed;
        }

        public void SetFuelConsumption(int fuelConsumption)
        {
            vipCar.FuelConsumption = fuelConsumption;
        }
        public void AddAirConditioning()
        {
            vipCar.AirConditioning = true;
        }

        public void AddHeatingSeats()
        {
            vipCar.HeatingSeats = true;
        }

        public void AddVentilationSeats()
        {
            vipCar.VentilationSeats = true;
        }

        public void AddZonalClimateControl()
        {
            vipCar.ZonalClimateControl = true;
        }
        public void AddMiniBar()
        {
            vipCar.MiniBar = true;
        }
    }
}
