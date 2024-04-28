class Program
{
    static void Main(string[] args)
    {
        int quantityOfFood = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        Console.WriteLine(queue.Max());

        while (queue.Any())
        {
            if (quantityOfFood >= queue.Peek())
            {
                quantityOfFood -= queue.Dequeue();
            }
            else
            {
                break;
            }
        }

        if (queue.Count == 0)
        {
            Console.WriteLine($"Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}