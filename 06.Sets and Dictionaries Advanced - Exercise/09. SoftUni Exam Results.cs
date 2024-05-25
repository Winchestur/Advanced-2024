List<string> list = Console.ReadLine().Split("-",
    StringSplitOptions.RemoveEmptyEntries).ToList();

Dictionary<string, int> dic = new Dictionary<string,int>();

Dictionary<string,int> language  = new Dictionary<string,int>();

int points = 0;

while (list[0] != "exam finished")
{
    string name = list[0];
    string programmingLanguage = list[1];

    if (programmingLanguage != "banned")
    {
        points = int.Parse(list[2]);

        if (!dic.ContainsKey(name))
        {
            dic.Add(name, 0);
        }

        if (!language.ContainsKey(programmingLanguage))
        {
            language.Add(programmingLanguage, 0);
        }
        language[programmingLanguage]++;

        if (dic[name] < points)
        {
            dic[name] = points;
        }
    }

    else
    {
        dic.Remove(name);
    }

    list = Console.ReadLine().Split("-",
        StringSplitOptions.RemoveEmptyEntries).ToList();
}

dic = dic.OrderByDescending(p=>p.Value)
    .ThenBy(n=>n.Key)
    .ToDictionary(n=>n.Key,
        n=>n.Value);

language = language.OrderByDescending(s=>s.Value)
    .ThenBy(s=>s.Key)
    .ToDictionary(s=>s.Key,
        s=>s.Value);

Console.WriteLine($"Results:");

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key} | {item.Value}");
}

Console.WriteLine($"Submissions:");

foreach (var item in language)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}