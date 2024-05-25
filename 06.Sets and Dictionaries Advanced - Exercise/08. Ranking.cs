List<string> contest = Console.ReadLine().Split(":",
    StringSplitOptions.RemoveEmptyEntries).ToList();

Dictionary<string, string> contestDictionary = new Dictionary<string, string>();

while (contest[0] != "end of contests")
{
    if (!contestDictionary.ContainsKey(contest[0]))
    {
        contestDictionary.Add(contest[0], "");
    }

    contestDictionary[contest[0]] = contest[1];

    contest = Console.ReadLine().Split(":",
        StringSplitOptions.RemoveEmptyEntries).ToList();
}

List<string> commands = Console.ReadLine().Split("=>",
    StringSplitOptions.RemoveEmptyEntries).ToList();

Dictionary<string, Dictionary<string, int>> dic =
    new Dictionary<string, Dictionary<string, int>>();

while (commands[0] != "end of submissions")
{
    if (contestDictionary.ContainsKey(commands[0]) && contestDictionary[commands[0]] == commands[1])
    {
        if (!dic.ContainsKey(commands[2]))
        {
            dic.Add(commands[2], new Dictionary<string, int>());
        }

        if (!dic[commands[2]].ContainsKey(commands[0]))
        {
            dic[commands[2]].Add(commands[0], 0);
        }

        if (dic[commands[2]][commands[0]] < int.Parse(commands[3]))
        {
            dic[commands[2]][commands[0]] = int.Parse(commands[3]);
        }
    }
    commands = Console.ReadLine().Split( "=>",
        StringSplitOptions.RemoveEmptyEntries).ToList();
}

string bestUser = dic.OrderBy(x => x.Value.Values.Sum()).Last().Key;
int bestPoints = dic.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");

Console.WriteLine($"Ranking: ");

foreach (var item in dic.OrderBy(s=>s.Key))
{
    Console.WriteLine(item.Key);

    foreach (var VARIABLE in item.Value.OrderByDescending(p =>p.Value))
    {
        Console.WriteLine($"#  {VARIABLE.Key} -> {VARIABLE.Value}");
    }
}