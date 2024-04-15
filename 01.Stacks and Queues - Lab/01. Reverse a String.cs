using System.Runtime.InteropServices.ComTypes;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Stack<char> stack = new Stack<char>(text);

        string newText = "";

        while (stack.Count != 0)
        {
            newText += stack.Pop();
        }

        Console.WriteLine(newText);
    }
}