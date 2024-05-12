using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        int greenLightInSeconds = int.Parse(Console.ReadLine());
        int freeWindowSeconds = int.Parse(Console.ReadLine());

        string commands = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        Queue<string> cars = new Queue<string>();
        Queue<string> parts = new Queue<string>();

        int currentGreenLightSeconds = greenLightInSeconds;
        int currentFreeWindowSeconds = freeWindowSeconds;

        string saveLetter = "";
        int count = 0;


        while (commands != "END")
        {
            if (commands == "green")
            {
                //read all the cars in queue
                for (int i = 0; i < cars.Count; i++)
                {
                    sb.Clear();
                    sb.Append(cars.Dequeue());
                    i--;

                    //make string to char
                    for (int j = 0; j < sb.Length; j++)
                    {
                        parts.Enqueue(sb[j].ToString());
                    }

                    //checks if greenLightSeconds is bigger than 0 
                    if (currentGreenLightSeconds > 0 && currentGreenLightSeconds + currentFreeWindowSeconds >= parts.Count)
                    {
                        count++;

                        for (int j = 0; j < parts.Count; j++)
                        {
                            if (currentGreenLightSeconds > 0)
                            {
                                saveLetter = parts.Peek();
                                currentGreenLightSeconds -= parts.Dequeue().Length;
                                j--;
                            }
                            else if (currentFreeWindowSeconds > 0)
                            {
                                saveLetter = parts.Peek();
                                currentFreeWindowSeconds -= parts.Dequeue().Length;
                                j--;
                            }
                            else
                            {
                                saveLetter = parts.Dequeue();
                                Console.WriteLine($"A crash happened!");
                                Console.WriteLine($"{sb.ToString()} was hit at {parts.Peek()}.");
                                return;
                            }
                        }
                    }
                    else if (currentGreenLightSeconds == 0)
                    {
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < parts.Count; j++)
                        {

                            if (currentGreenLightSeconds > 0)
                            {
                                saveLetter = parts.Peek();
                                currentGreenLightSeconds -= parts.Dequeue().Length;
                                j--;
                            }
                            else if (currentFreeWindowSeconds > 0)
                            {
                                saveLetter = parts.Peek();
                                currentFreeWindowSeconds -= parts.Dequeue().Length;
                                j--;
                            }
                            else
                            {
                                saveLetter = parts.Dequeue();
                                Console.WriteLine($"A crash happened!");
                                Console.WriteLine($"{sb.ToString()} was hit at {saveLetter}.");
                                return;
                            }
                        }
                    }
                }
            }

            else
            {
                //new cars on greenlight
                cars.Enqueue(commands);
            }

            // reset seconds of greenLight and freeWindow
            currentGreenLightSeconds = greenLightInSeconds;
            currentFreeWindowSeconds = freeWindowSeconds;

            commands = Console.ReadLine();
        }

        Console.WriteLine($"Everyone is safe.");
        Console.WriteLine($"{count} total cars passed the crossroads.");
    }
}