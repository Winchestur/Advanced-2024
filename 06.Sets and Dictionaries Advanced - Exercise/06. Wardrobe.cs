int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    List<string> dress = Console.ReadLine().Split(new string[] {",", " -> " },
        StringSplitOptions.RemoveEmptyEntries).ToList();

    string color = dress[0];
    List<string> type = new List<string>();
    type.AddRange(dress.Skip(1));

    if (!dic.ContainsKey(color))
    {
        dic.Add(color, new Dictionary<string, int>());
    }

    for (int j = 0; j < type.Count; j++)
    {
        string text = type[j];

        if (!dic[color].ContainsKey(text))
        {
            dic[color].Add(text,0);
        }
        
        dic[color][text]++;
    }
}

List<string> dressToFind = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

string colorToFind = dressToFind[0];
string dressNeeded = dressToFind[1];

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key} clothes:");

    foreach (var variable in item.Value)
    {
        if (colorToFind == item.Key && dressNeeded == variable.Key)
        {
            Console.WriteLine($"* {variable.Key} - {variable.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {variable.Key} - {variable.Value}");
        }
    }
}