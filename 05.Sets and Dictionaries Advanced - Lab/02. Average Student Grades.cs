int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> dic = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    List<string> list = Console.ReadLine().Split(" ", 
        StringSplitOptions.RemoveEmptyEntries).ToList();

    string name = list[0];
    decimal grade = decimal.Parse(list[1]);

    if (!dic.ContainsKey(name))
    {
        dic.Add(name, new List<decimal>());
    }

    dic[name].Add(grade);
}

foreach (var item in dic)
{
    Console.Write($"{item.Key} -> ");

    foreach (var VARIABLE in item.Value)
    {
        Console.Write($"{VARIABLE:F2} ");
    }

    Console.WriteLine($"(avg: {item.Value.Average():F2})");
}