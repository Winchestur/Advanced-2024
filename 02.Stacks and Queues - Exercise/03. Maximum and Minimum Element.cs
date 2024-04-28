class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

            switch (commands[0])
            {
                case 1:
                    stack.Push(commands[1]);
                    break;
                case 2:
                    stack.Pop();
                    break;
                case 3:
                    if (stack.Any())
                    Console.WriteLine(stack.Max());
                    break;
                case 4:
                    if (stack.Any())
                    Console.WriteLine(stack.Min());
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}