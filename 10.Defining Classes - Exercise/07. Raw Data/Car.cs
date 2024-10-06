using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingCars
{
    internal class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires = new Tires[4];
        public static List<Car> Cars = new List<Car>();

        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public static void Adding(Car car)
        {
            Cars.Add(car);
        }

        public static void Print(string command)
        {

            foreach (var item in Cars)
            {
                if (command == "fragile" && item.Cargo.Type == "fragile")
                {
                    int check = 0;
                    foreach (var VARIABLE in item.Tires)
                    {
                        if (VARIABLE.Pressure < 1)
                        {
                            check++;
                            break;
                        }
                    }
                    if (check == 1)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
                else if (command == "flammable" && item.Cargo.Type == "flammable")
                {
                    if (item.Engine.Power > 250)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
        }
    }
}
