using System.Runtime.InteropServices.ComTypes;

class Program
{
    static void Main(string[] args)
    {
        List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        Stack<int> stack = new Stack<int>(list);

        int length = stack.Count;

        for (int i = 0; i < commands[1]; i++)
        {
            if (length >= i)
            {
                stack.Pop();
            }
        }

        if (stack.Contains(commands[2]))
        {
            Console.WriteLine($"true");
        }
        else if (!stack.Contains(commands[2]) && stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
        else if (stack.Count == 0)
        {
            Console.WriteLine(0);
        }
        
    }
}
