int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> dic =
    new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    List<string> list = Console.ReadLine().Split(" ",
        StringSplitOptions.RemoveEmptyEntries).ToList();

    string continent = list[0];
    string country = list[1];
    string city = list[2];

    if (!dic.ContainsKey(continent))
    {
        dic.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!dic[continent].ContainsKey(country))
    {
        dic[continent].Add(country, new List<string>());
    }
    
    dic[continent][country].Add(city);
}

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key}:");

    foreach (var VARIABLE in item.Value)
    {
        Console.Write($"{VARIABLE.Key} -> {string.Join(", ", VARIABLE.Value)}");
        Console.WriteLine();
    }
}