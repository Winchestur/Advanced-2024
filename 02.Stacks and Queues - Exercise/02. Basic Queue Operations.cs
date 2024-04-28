class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {

            if (commands[0] == 1)
            {
                stack.Push(commands[1]);
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            else if (commands[0] == 2 && stack.Any())
            {
                Console.WriteLine(stack.Pop());
            }
            else if (commands[0] == 3 && stack.Any())
            {
                Console.WriteLine(stack.Max());
            }
            else if (commands[0] == 4 && stack.Any())
            {
                Console.WriteLine(stack.Min());
            }

            commands = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}
