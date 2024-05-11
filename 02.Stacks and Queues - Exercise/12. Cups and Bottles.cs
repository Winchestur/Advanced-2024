class Program
{
    static void Main(string[] args)
    {
        Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        int wastedWater = 0;

        while (cups.Any() && bottles.Any())
        {
            if (cups.Peek() > bottles.Peek())
            {
                int result = cups.Dequeue() - bottles.Pop();
                Queue<int> cup = new Queue<int>(cups);
                cups.Clear();
                cups.Enqueue(result);

                for (int i = 0; i < cup.Count; i++)
                {
                    cups.Enqueue(cup.Dequeue());
                    i--;
                }
                cup.Clear();
            }
            else if (cups.Peek() == bottles.Peek())
            {
                cups.Dequeue();
                bottles.Pop();
            }
            else
            {
                wastedWater += bottles.Pop() - cups.Dequeue();
            }
        }

        if (cups.Count == 0)
        {
            Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
        else if (bottles.Count == 0)
        {
            Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}