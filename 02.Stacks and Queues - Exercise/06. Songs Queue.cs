class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>(Console.ReadLine()
            .Split(", "));

        List<string> commands = Console.ReadLine().Split(" ").ToList();

        bool type = false;

        while (queue.Count >= 0 && type != true)
        {
            switch (commands[0])
            {
                case "Play":
                   type = Play(queue);
                    break;
                case "Add":
                    Add(queue,commands);
                    break;
                case "Show":
                    Show(queue);
                    break;
            }

            if (type == false)
            {
                commands = Console.ReadLine().Split(" ").ToList();
            }
        }

        
    }

    private static void Show(Queue<string> queue)
    {
        Console.WriteLine(string.Join(", ", queue));
    }

    private static void Add(Queue<string> queue, List<string> commands)
    {
        string song = "";

        for (int i = 1; i < commands.Count; i++)
        {
            if (i < commands.Count - 1)
            {
                song += commands[i] + " ";
            }
            else
            {
                song += commands[i];
            }
        }

        if (!queue.Contains(song))
        {
            queue.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }

    private static bool Play(Queue<string> queue)
    {
        bool type = false;

        if (queue.Any())
        {
            queue.Dequeue();
        }

        if (queue.Count == 0)
        {
            Console.WriteLine($"No more songs!");
            type = true;
        }

        return type; 
    }
}