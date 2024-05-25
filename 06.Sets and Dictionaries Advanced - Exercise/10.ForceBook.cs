string list = Console.ReadLine();

Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();

while (list != "Lumpawaroo")
{
    if (list.Contains("|"))
    {
        string team = list.Split(" | ")[0];
        string name = list.Split(" | ")[1];

        if (!dic.ContainsKey(team))
            dic.Add(team, new List<string>());

        if (!dic[team].Contains(name))
        {
            List<string> index = dic.Where(kvp => kvp.Value.Contains(name))
                .Select(kvp => kvp.Key).ToList();

            if (index.Count == 0)
                dic[team].Add(name);
        }
    }

    else if (list.Contains(" -> "))
    {
        string team = list.Split(" -> ")[1];
        string name = list.Split(" -> ")[0];

        if (!dic.ContainsKey(team))
            dic.Add(team, new List<string>());

        List<string> index = dic.Where(kvp => kvp.Value.Contains(name))
            .Select(kvp => kvp.Key).ToList();

        if (index.Count > 0)
        {
            dic[index[0]].Remove(name);
            dic[team].Add(name);
            Console.WriteLine($"{name} joins the {team} side!");
        }
        
        if (index.Count == 0 && dic.ContainsKey(team) && !dic[team].Contains(name))
        {
            dic[team].Add(name);
            Console.WriteLine($"{name} joins the {team} side!");
        }
    }
    list = Console.ReadLine();
}

foreach (var item in dic.OrderByDescending(u => u.Value.Count)
             .ThenBy(n => n.Key))
{
    if (item.Value.Count > 0)
    {
        Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

        foreach (var VARIABLE in item.Value.OrderBy(n=>n))
        {
            Console.WriteLine($"! {VARIABLE}");
        }
    }
}