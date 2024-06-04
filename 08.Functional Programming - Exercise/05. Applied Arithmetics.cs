List<int> numbers = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)).ToList();

string commands = Console.ReadLine();

while (commands != "end")
{
    switch (commands)
    {
        case "add":
            Operations(numbers, x => x + 1, commands);
            break;
        case "multiply":
            Operations(numbers, x => x * 2, commands);
            break;
        case "subtract":
            Operations(numbers, x => x - 1, commands);
            break;
        case "print":
            Print();
            break;
    }
    commands = Console.ReadLine();
}
void Print()
{
    Console.WriteLine(string.Join(" ", numbers));
}
void Operations(List<int> numbers, Func<int,int> y, string command)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (commands == "add")
        {
           numbers[i] = y(numbers[i]);
        }
        else if (commands == "multiply")
        {
           numbers[i] = y(numbers[i]);
        }
        else if (commands == "subtract")
        {
           numbers[i] = y(numbers[i]);
        }
    }
}