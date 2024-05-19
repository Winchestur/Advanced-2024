string text = Console.ReadLine();

List<string> guests = new List<string>();

List<string> waiting = new List<string>();

while (text != "PARTY")
{
    if (char.IsDigit(text[0]) && text.Length == 8)
    {
        guests.Add(text);
    }
    else if (text.Length == 8)
    {
        waiting.Add(text);
    }

    text = Console.ReadLine();
}

guests.AddRange(waiting);

while (text != "END")
{
    if (guests.Contains(text))
    {
        guests.Remove(text);
    }

    text = Console.ReadLine();
}

Console.WriteLine(guests.Count);
Console.WriteLine(string.Join(Environment.NewLine, guests));