using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    internal class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public dynamic Weight { get; set; }
        public string Color { get; set; }
        public static List<Car> List = new List<Car>();
        public static List<Car> SecondList = new List<Car>();

        public Car(string model, Engine engine, dynamic weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public static void AddSecondList(Car car)
        {
            SecondList.Add(car);
        }
        public static void Add(Car car)
        {
            List.Add(car);
        }

        public static void AddFirstToSecond()
        {
            foreach (var item in SecondList)
            {
                foreach (var VARIABLE in List)
                {
                    if (VARIABLE.Engine.Model == item.Engine.Model)
                    {
                        item.Engine.Power = VARIABLE.Engine.Power;
                        item.Engine.Displacement = VARIABLE.Engine.Displacement;
                        item.Engine.Efficiency = VARIABLE.Engine.Efficiency;
                        break;
                    }
                }
            }
        }

        public static void Print()
        {
            foreach (var item in SecondList)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($" {item.Engine.Model}:");
                Console.WriteLine($"   Power: {item.Engine.Power}");
                Console.WriteLine($"   Displacement: {item.Engine.Displacement}");
                Console.WriteLine($"   Efficiency: {item.Engine.Efficiency}");
                Console.WriteLine($" Weight: {item.Weight}");
                Console.WriteLine($" Color: {item.Color}");
            }
        }
    }
}
