class Program
{
    static void Main(string[] args)
    {
        List<string> list = Console.ReadLine().Split().ToList();

        Queue<string> queue = new Queue<string>(list);

        int counter = int.Parse(Console.ReadLine());

        int count = 1;

        string saveKid = "";

        while (queue.Count > 1)
        {
            while (count <= counter)
            {
               saveKid = queue.Dequeue();

               if (count == counter)
               {
                   Console.WriteLine($"Removed {saveKid}");
                   break;
               }
               else
               {
                   queue.Enqueue(saveKid);
               }
               count++;
            }

            count = 1;
        }

        Console.WriteLine($"Last is {string.Join(" ", queue)}");
    }
}