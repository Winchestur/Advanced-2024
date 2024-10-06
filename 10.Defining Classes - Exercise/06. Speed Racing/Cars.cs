using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AddingCars
{
    internal class Cars
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set;}

        public double TravelledDistance { get; set; }

        public static List<Cars> CarList = new List<Cars>();

        public Cars(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionFor1km = fuelConsumptionFor1Km;
        }

        public static void AddCars(Cars car)
        {
            CarList.Add(car);
        }

        public static void Drive(string model, double amountOfKm)
        {
            foreach (var item in CarList)
            {
                if (item.Model == model && item.FuelAmount >= amountOfKm * item.FuelConsumptionFor1km)
                {
                    item.FuelAmount -= amountOfKm * item.FuelConsumptionFor1km;
                    item.TravelledDistance += amountOfKm;
                }
                else if (amountOfKm * item.FuelConsumptionFor1km > item.FuelAmount && item.Model == model)
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }
        }

        public static void Print()
        {
            foreach (var item in CarList)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}
