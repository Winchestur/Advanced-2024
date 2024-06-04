List<string> name =Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

List<string> commands = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

while (commands[0] != "Party!")
{
    switch (commands[1])
    {
        case "StartsWith":
            Operations(name, commands, x => x.StartsWith(commands[2]));
            break;
        case "EndsWith":
            Operations(name, commands, x => x.EndsWith(commands[2]));
            break;
        case "Length":
            Operations(name, commands, x => x.Length == int.Parse(commands[2]));
            break;
    }
    commands = Console.ReadLine().Split(" ",
        StringSplitOptions.RemoveEmptyEntries).ToList();
}

if (name.Count > 0)
{
    Console.WriteLine($"{string.Join(", ", name)} are going to the party!");
}
else
{
    Console.WriteLine($"Nobody is going to the party!");
}

void Operations(List<string> name, List<string> commands, Func<string, bool> value)
{
    if (commands[0] == "Remove")
    {
        if (commands[1] == "StartsWith")
        {
            Remove(name, value);
        }
        else if (commands[1] == "EndsWith")
        {
            Remove(name, value);
        }
        else if (commands[1] == "Length")
        {
            Remove(name, value);
        }
    }
    else if (commands[0] == "Double")
    {
        if (commands[1] == "StartsWith")
        {
            Double(name, value);
        }
        else if (commands[1] == "EndsWith")
        {
            Double(name, value);
        }
        else if (commands[1] == "Length")
        {
            Double(name, value);
        }
    }
}

void Double(List<string> name, Func<string, bool> value)
{
    for (int i = 0; i < name.Count; i++)
    {
        if (value(name[i]))
        {
            name.Insert(i, name[i]);
            i++;
        }
    }
}

void Remove(List<string> name, Func<string, bool> value)
{
    for (int i = 0; i < name.Count; i++)
    {
        if (value(name[i]))
        {
            name.RemoveAt(i);
            i--;
        }
    }
}