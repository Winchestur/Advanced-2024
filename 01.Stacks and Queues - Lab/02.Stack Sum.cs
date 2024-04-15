using System.Runtime.InteropServices.ComTypes;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        Stack<int> stack = new Stack<int>(numbers);

        List<string> commands = Console.ReadLine().Split(" ").ToList();

        while (commands[0].ToLower() != "end")
        {
            string typeOfCommand = commands[0].ToLower();

            switch (typeOfCommand)
            {
                case "add":
                    add(stack, commands);
                    break;
                case "remove":
                    remove(stack, commands);
                    break;
            }

            commands = Console.ReadLine().Split(" ").ToList();
        }

        int result = 0;

        while (stack.Count != 0)
        {
            result += stack.Pop();
        }

        Console.WriteLine($"Sum: {result}");
    }

    private static void remove(Stack<int> stack, List<string> commands)
    {
        int count = int.Parse(commands[1]);

        if (count <= stack.Count)
        {
            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }
        }
    }

    private static void add(Stack<int> stack, List<string> commands)
    {
        int firstNum = int.Parse(commands[1]);
        int secondNum = int.Parse(commands[2]);

        stack.Push(firstNum);
        stack.Push(secondNum);
    }
}