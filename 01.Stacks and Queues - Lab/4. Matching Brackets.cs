using System;

class Program
{
    static void Main(string[] args)
    {   
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>(input);

        Stack<char> newStack = new Stack<char>(stack);

        Stack<int> indexOpenBrackets = new Stack<int>();

        int count = 0;

        string text = "";

        while (newStack.Any())
        {
            if (newStack.Peek() == '(')
            {
                indexOpenBrackets.Push(count);
            }
            else if (newStack.Peek() == ')')
            {
                text = input.Substring(indexOpenBrackets.Peek(), count +1 - indexOpenBrackets.Pop());

                Console.WriteLine(text);
                text = "";
            }

            newStack.Pop();
            count++;
        }


    }
}