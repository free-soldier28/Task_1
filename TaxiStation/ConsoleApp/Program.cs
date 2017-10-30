using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation;
using TaxiStation.Director;
using TaxiStation.Builder;
using TaxiStation.Enum;
using TaxiStation.Interface;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> taxistaxiStation = new List<Car>();

            CarDirector director = new CarDirector();
            BasicEquipmentCarBuilder basicEquipmentCarBuilder = new BasicEquipmentCarBuilder();
            ComfortableEquipmentCarBuilder comfortableEquipmentCarBuilder = new ComfortableEquipmentCarBuilder();
            VIPCarBuilder vipCarBuilder = new VIPCarBuilder();

            director.SetBuilder(basicEquipmentCarBuilder);
            director.ConstructCar(Brand.Toyota, "Camry", Carcass.Hatchback, 10500, 220, 10);
            taxistaxiStation.Add(basicEquipmentCarBuilder.GetCar());
      
            director.ConstructCar(Brand.Volkswagen, "Golf 5", Carcass.Sedan, 8200, 210, 8);
            taxistaxiStation.Add(basicEquipmentCarBuilder.GetCar());

            director.SetBuilder(comfortableEquipmentCarBuilder);
            director.ConstructCar(Brand.BMW, "X5", Carcass.Crossover, 25300, 250, 15);
            taxistaxiStation.Add(comfortableEquipmentCarBuilder.GetCar());

            director.ConstructCar(Brand.Volvo, "s90", Carcass.Hatchback, 21800, 260, 12);
            taxistaxiStation.Add(comfortableEquipmentCarBuilder.GetCar());

            director.SetBuilder(vipCarBuilder);
            director.ConstructCar(Brand.RollsRoyce, "PHANTOM", Carcass.Limousine, 60000, 150, 20);
            taxistaxiStation.Add(vipCarBuilder.GetCar());


            Console.WriteLine("Calculation of the total cost of car taxis. ");
            long carsCost = Autopark.CalculateAutoparkCost(taxistaxiStation);
            Console.WriteLine($"Autopark total cost is:  {carsCost}$");


            Console.WriteLine();
            Console.WriteLine("Sorting cars by fuel consumption.");
            List<Car> sortedListByFuelConsumption = Autopark.SortCarsByFuelConsumption(taxistaxiStation);
            foreach (var car in sortedListByFuelConsumption)
            {
                Console.WriteLine($"{car} - {car.FuelConsumption} liters");
            }


            Console.WriteLine();
            Console.WriteLine("Searching cars by speed:");
            List<Car> carsBySpeed = Autopark.SearchCarsBySpeed(taxistaxiStation, 150, 250);

            if (carsBySpeed.Count == 0)
            {
                Console.WriteLine("There are no cars with defined maximum speed");
            }
            else
            {
                foreach (Car car in carsBySpeed)
                {
                    Console.WriteLine(car);
                }
            }

            Console.ReadKey();

        }
    }
}
