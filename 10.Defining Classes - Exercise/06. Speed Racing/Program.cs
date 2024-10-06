namespace AddingCars
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Cars> cars = new List<Cars>();

            for (int i = 0; i < n; i++)
            {
                List<string> list = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                Cars car = new Cars(list[0], double.Parse(list[1]), double.Parse(list[2]));
                Cars.AddCars(car);
            }

            List<string> carsAndDistance = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).ToList();

            while (carsAndDistance[0] != "End")
            {
                Cars.Drive(carsAndDistance[1], double.Parse(carsAndDistance[2]));

                carsAndDistance = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Cars.Print();
        }
    }
}