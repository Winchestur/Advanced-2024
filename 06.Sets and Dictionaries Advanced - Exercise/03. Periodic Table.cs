int n = int.Parse(Console.ReadLine());

List<string> save = new List<string>();
SortedSet<string> chemicalCompounds = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    List<string> list = Console.ReadLine().Split(" ",
        StringSplitOptions.RemoveEmptyEntries).ToList();

    save.AddRange(list);
}

for (int i = 0; i < save.Count; i++)
{
    chemicalCompounds.Add(save[i]);
}

Console.WriteLine(string.Join(" ", chemicalCompounds));