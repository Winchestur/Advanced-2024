namespace AddingCars
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> car = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                string model = car[0];
                int engineSpeed = int.Parse(car[1]);
                int enginePower = int.Parse(car[2]);
                int cargoWeight = int.Parse(car[3]);
                string cargoType = car[4];
                double tire1Pressure = double.Parse(car[5]);
                int tire1Age = int.Parse(car[6]);
                double tire2Pressure = double.Parse(car[7]);
                int tire2Age = int.Parse(car[8]);
                double tire3Pressure = double.Parse(car[9]);
                int tire3Age = int.Parse(car[10]);
                double tire4Pressure = double.Parse(car[11]);
                int tire4Age = int.Parse(car[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires[] tires = new Tires[4]
                {
                    new Tires(tire1Age, tire1Pressure),
                    new Tires(tire2Age, tire2Pressure),
                    new Tires(tire3Age, tire3Pressure),
                    new Tires(tire4Age, tire4Pressure)
                };

                Car cars = new Car(model, engine, cargo, tires);

                Car.Adding(cars);
            }

            string commands = Console.ReadLine();

            Car.Print(commands);
        }
    }
}

