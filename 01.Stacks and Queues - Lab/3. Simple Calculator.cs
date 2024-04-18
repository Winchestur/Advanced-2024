
class Program
{
    static void Main(string[] args)
    {
        List<string> list = Console.ReadLine().Split(" ").ToList();

        Stack<string> stack = new Stack<string>(list);

        Stack<string> newStack = new Stack<string>(stack);

        int result = int.Parse(newStack.Pop());

        for (int i = 1; i < newStack.Count; i++)
        {
                switch (newStack.Peek())
                {
                    case "+":
                       result = adding(newStack, result);
                       i--;
                        break;
                    case "-":
                       result = substraction(newStack, result);
                       i--;
                        break;
                }
        }

        Console.WriteLine(Math.Abs(result));
    }

    private static int substraction(Stack<string> newStack,int result)
    {
        newStack.Pop();
        result -= int.Parse(newStack.Pop());

        return result;
    }

    private static int adding(Stack<string> newStack , int result)
    {
        newStack.Pop();
        result += int.Parse(newStack.Pop());

        return result;
    }
}