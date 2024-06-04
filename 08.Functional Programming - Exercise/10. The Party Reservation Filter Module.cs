List<string> names = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

List<string> commands = Console.ReadLine().Split(";",
    StringSplitOptions.RemoveEmptyEntries).ToList();

List<string> gointToParty = new List<string>();

while (commands[0] != "Print")
{
    Result(names, commands);

    commands = Console.ReadLine().Split(";",
        StringSplitOptions.RemoveEmptyEntries).ToList();
}

Console.WriteLine(string.Join(" ", names));
void Result(List<string> names, List<string> commands)
{
    switch (commands[1])
    {
        case "Starts with":
            Operations(names,commands, x => x.StartsWith(commands[2]));
            break;
        case "Ends with":
            Operations(names, commands, x => x.EndsWith(commands[2]));
            break;
        case "Length":
            Operations(names, commands, x => x.Length == int.Parse(commands[2]));
            break;
        case "Contains":
            Operations(names, commands, x => x.Contains(commands[2]));
            break;
    }
}
void Operations(List<string> names, List<string> commands, Func<string, bool> value)
{
    if (commands[0] == "Add filter")
    {
        for (int i = 0; i < names.Count; i++)
        {
            if (value(names[i]))
            {
                gointToParty.Add(names[i]);
                names.RemoveAt(i);
                i--;
            }
        }
    }
    else if (commands[0] == "Remove filter")
    {
        for (int i = 0; i < gointToParty.Count; i++)
        {
            if (value(gointToParty[i]))
            {
                names.Add(gointToParty[i]);
                gointToParty.RemoveAt(i);
                i--;
            }
        }
    }
}