class Program
{
    static void Main(string[] args)
    {
        string parentheses = Console.ReadLine();

        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < parentheses.Length; i++)
        {
            if (parentheses[i] == '(' || parentheses[i] == '[' || parentheses[i] == '{')
            {
                stack.Push(parentheses[i].ToString());
            }
            else if (parentheses[i] == ')' || parentheses[i] == ']' || parentheses[i] == '}')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine($"NO");
                    return;
                }
                if (stack.Peek() == "(" && parentheses[i] == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == "{" && parentheses[i] == '}')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == "[" && parentheses[i] == ']')
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine($"NO");
                    break;
                }
            }
        }

        if (stack.Count == 0 && parentheses.Any())
        {
            Console.WriteLine($"YES");
        }
    }
}