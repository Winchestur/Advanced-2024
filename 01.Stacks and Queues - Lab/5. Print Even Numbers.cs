class Program
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

        Queue<int> queue = new Queue<int>(nums);

        Queue<int> newQueue = new Queue<int>();

        int count = 0;

        while (queue.Any())
        {
            if (queue.Peek() % 2 == 0)
            {
                queue.Dequeue();
            }
            else
            {
                newQueue.Enqueue(queue.Dequeue());
            }
            count++;
        }

        Console.WriteLine(string.Join(", " , newQueue));
    }
}