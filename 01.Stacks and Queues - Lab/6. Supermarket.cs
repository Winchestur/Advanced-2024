using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>(Console.ReadLine().Split());

        Queue<string> saved = new Queue<string>();

        while (queue.Peek() != "End")
        {
            if (queue.Peek() != "Paid")
            {
                saved.Enqueue(queue.Peek());
            }

            if (queue.Peek() == "Paid")
            {
                while (saved.Any())
                {
                    Console.WriteLine(saved.Dequeue());
                }
            }

            queue = new Queue<string>(Console.ReadLine().Split());
        }

        Console.WriteLine($"{saved.Count} people remaining.");
    }
}