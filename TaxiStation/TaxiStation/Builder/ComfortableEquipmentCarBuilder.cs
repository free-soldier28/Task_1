using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Enum;
using TaxiStation.Interface;

namespace TaxiStation.Builder
{
    public class ComfortableEquipmentCarBuilder : ICarBuilder
    {
        ComfortableEquipmentCar comfortableEquipmentCar;

        public void CreateCar()
        {
            comfortableEquipmentCar = new ComfortableEquipmentCar();
        }

        public ComfortableEquipmentCar GetCar()
        {
            return comfortableEquipmentCar;
        }

        public void SetBrand(Brand brand)
        {
            comfortableEquipmentCar.Brand = brand;
        }
        public void SetModel(string model)
        {
            comfortableEquipmentCar.Model = model;
        }

        public void SetCarcas(Carcass carcass)
        {
            comfortableEquipmentCar.Carcass = carcass;
        }

        public void SetPriceCar(int priceCar)
        {
            comfortableEquipmentCar.PriceCar = priceCar;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            comfortableEquipmentCar.MaxSpeed = maxSpeed;
        }
        public void SetFuelConsumption(int fuelConsumption)
        {
            comfortableEquipmentCar.FuelConsumption = fuelConsumption;
        }
        public void AddAirConditioning()
        {
            comfortableEquipmentCar.AirConditioning = true;
        }

        public void AddHeatingSeats()
        {
            comfortableEquipmentCar.HeatingSeats = true;
        }

        public void AddVentilationSeats()
        {
            comfortableEquipmentCar.VentilationSeats = true;
        }

        public void AddZonalClimateControl()
        {

        }

        public void AddMiniBar()
        {

        }


    }
}
