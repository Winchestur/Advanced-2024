using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int greenLightInSeconds = int.Parse(Console.ReadLine());
        int freeWindowSeconds = int.Parse(Console.ReadLine());

        string commands = Console.ReadLine();

        List<string> list = new List<string>();

        Queue<string> queue = new Queue<string>();


        int currentGreenLightInSeconds = 0;
        int currentFreeWindowSeconds = 0;
        int count = 0;

        while (commands != "END")
        {
             currentGreenLightInSeconds = greenLightInSeconds;
             currentFreeWindowSeconds = freeWindowSeconds;

            if (commands != "green")
            {
                list.Add(commands);
            }

            else if (commands == "green")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (currentGreenLightInSeconds >= 1)
                    {
                        count++;
                        for (int j = 0; j < list[i].Length; j++)
                        {
                            queue.Enqueue(list[i][j].ToString());
                        }
                    }

                    while (queue.Any())
                    {
                        if (currentGreenLightInSeconds > 0)
                        {
                            currentGreenLightInSeconds--;
                            queue.Dequeue();
                        }
                        else if (currentGreenLightInSeconds + currentFreeWindowSeconds > 0 )
                        {
                            currentFreeWindowSeconds--;
                            queue.Dequeue();
                        }
                        else if (currentGreenLightInSeconds == 0 && currentFreeWindowSeconds == 0)
                        {
                            Console.WriteLine($"A crash happened!");
                            Console.WriteLine($"{list[i]} was hit at {queue.Dequeue()}.");
                            return;
                        }
                    }
                }
                list.Clear();
            }
            commands = Console.ReadLine();
        }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
    }
}