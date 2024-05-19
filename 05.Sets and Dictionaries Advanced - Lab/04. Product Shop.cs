List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

Dictionary<string, Dictionary<string, double>> dic = new Dictionary<string, Dictionary<string, double>>();

while (list[0] != "Revision")
{
    string shop = list[0];
    string product = list[1];
    double price = double.Parse(list[2]);

    if (!dic.ContainsKey(shop))
    {
        dic.Add(shop, new Dictionary<string, double>());
    }

    if (dic[shop].ContainsKey(product))
    {
        dic[shop].Add(product, 0);
    }

    dic[shop][product] = price;

    list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
}

dic = dic.OrderBy(p => p.Key)
    .ToDictionary(p => p.Key, p => p.Value);

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key}->");

    foreach (var VARIABLE in item.Value)
    {
        Console.Write($"Product: {VARIABLE.Key}, Price: {VARIABLE.Value}");
        Console.WriteLine();
    }
}