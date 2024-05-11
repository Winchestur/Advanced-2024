class Program
{
    static void Main(string[] args)
    {
        int pricePerBullet = int.Parse(Console.ReadLine());
        int sizeBarrel = int.Parse(Console.ReadLine());
        Stack<int> bullet = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
        Queue<int> locks = new Queue<int>( Console.ReadLine().Split().Select(int.Parse).ToList());
        int valueOfTheIntelligence = int.Parse(Console.ReadLine());

        int counter = 0;

        while (bullet.Any() && locks.Any())
        {
            counter++;

            if (bullet.Peek() <= locks.Peek())
            {
                bullet.Pop();
                locks.Dequeue();
                Console.WriteLine($"Bang!");
            }
            else
            {
                bullet.Pop();
                Console.WriteLine($"Ping!");
            }

            if (bullet.Any() && counter % sizeBarrel == 0)
            {
                Console.WriteLine($"Reloading!");
            }
        }

        if (bullet.Count == 0 && locks.Count > 0)
        {
            int bulletCost = counter * pricePerBullet;
            int earned = valueOfTheIntelligence - bulletCost;

            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        }
        else if (locks.Count == 0)
        {
            int bulletCost = counter * pricePerBullet;
            int earned = valueOfTheIntelligence - bulletCost;

            Console.WriteLine($"{bullet.Count} bullets left. Earned ${earned}");
        }
    }
}