using System.Reflection;

namespace _08.CarSalesman
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                string model = list[0];
                int power = int.Parse(list[1]);


                if (list.Count == 3)
                {
                    if (char.IsDigit(list[2][0]))
                    {
                        int displacement = int.Parse(list[2]);

                        Engine engine = new Engine(model, power, displacement);
                        Car car = new Car("n/a", engine, "n/a", "n/a");
                        Car.Add(car);
                    }
                    else
                    {
                        string Efficiency = list[2];
                        Engine engine = new Engine(model, power, Efficiency);
                        Car car = new Car("n/a", engine, "n/a", "n/a");
                        Car.Add(car);
                    }
                }
                else if (list.Count == 4)
                {
                    int displacement = int.Parse(list[2]);
                    string Efficiency = list[3];
                    Engine engine = new Engine(model, power, displacement, Efficiency);
                    Car car = new Car("n/a", engine, "n/a", "n/a");
                    Car.Add(car);
                }
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                List<string> list = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                if (list.Count == 2)
                {
                    Engine engine = new Engine(list[1], "n/a", "n/a" , "n/a");
                    Car car = new Car(list[0], engine, "n/a", "n/a");
                    Car.AddSecondList(car);
                }
                else if (list.Count == 3)
                {
                    if (char.IsDigit(list[2][0]))
                    {
                        Engine engine = new Engine(list[1], "n/a", "n/a");
                        Car car = new Car(list[0], engine, list[2], "n/a");
                        Car.AddSecondList(car);
                    }
                    else
                    {
                        Engine engine = new Engine(list[1], "n/a", "n/a");
                        Car car = new Car(list[0], engine, "n/a", list[2]);
                        Car.AddSecondList(car);
                    }
                }
                else if (list.Count == 4)
                {
                    Engine engine = new Engine(list[1], "n/a", "n/a");
                    Car car = new Car(list[0], engine, list[2], list[3]);
                    Car.AddSecondList(car);
                }
            }
            Car.AddFirstToSecond();
            Car.Print();
        }
    }
}