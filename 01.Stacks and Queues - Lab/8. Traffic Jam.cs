class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string car = Console.ReadLine();

        Queue<string> save = new Queue<string>();

        int countPassedCars = 0;

        while (car != "end" && car.Length > 0)
        {
            if (car != "green")
            {
                save.Enqueue(car);
            }

            if (car == "green")
            {
                int length = save.Count;
                for (int i = 0; i < n; i++)
                {
                    if (i < length)
                    {
                        Console.WriteLine($"{save.Dequeue()} passed!");
                        countPassedCars++;
                    }
                }
            }

            car = Console.ReadLine();
        }

        Console.WriteLine($"{countPassedCars} cars passed the crossroads.");
    }
}
