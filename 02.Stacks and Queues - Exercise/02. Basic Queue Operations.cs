class Program
{
    static void Main(string[] args)
    {
        List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        Queue<int> queue = new Queue<int>(list);

        int length = queue.Count;

        for (int i = 0; i < commands[1]; i++)
        {
            if (length >= i)
            {
                queue.Dequeue();
            }
        }

        if (queue.Contains(commands[2]))
        {
            Console.WriteLine($"true");
        }
        else if (!queue.Contains(commands[2]) && queue.Any())
        {
            Console.WriteLine(queue.Min());
        }
        else if (queue.Count == 0)
        {
            Console.WriteLine(0);
        }

    }
}
