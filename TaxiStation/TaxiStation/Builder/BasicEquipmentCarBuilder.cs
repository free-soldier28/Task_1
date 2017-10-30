using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Interface;
using TaxiStation.Enum;

namespace TaxiStation.Builder
{
    public class BasicEquipmentCarBuilder: ICarBuilder
    {
        BasicEquipmentCar basicEquipmentCar = new BasicEquipmentCar();

        public void Reset()
        {
            basicEquipmentCar = null;
        }

        public BasicEquipmentCar GetCar()
        {
            return basicEquipmentCar;
        }

        public void SetBrand(Brand brand)
        {
            basicEquipmentCar.Brand = brand;
        }

        public void SetModel(string model)
        {
            basicEquipmentCar.Model = model;
        }

        public void SetCarcas(Carcass carcass)
        {
            basicEquipmentCar.Carcass = carcass;
        }

        public void SetPriceCar(int priceCar)
        {
            basicEquipmentCar.PriceCar = priceCar;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            basicEquipmentCar.MaxSpeed = maxSpeed;
        }

        public void SetFuelConsumption(int fuelConsumption)
        {
            basicEquipmentCar.FuelConsumption = fuelConsumption;
        }

        public void AddAirConditioning()
        {
            basicEquipmentCar.AirConditioning = true;
        }

        public void AddHeatingSeats()
        {

        }

        public void AddVentilationSeats()
        {

        }

        public void AddZonalClimateControl()
        {

        }

        public void AddMiniBar()
        {

        }
    }
}
