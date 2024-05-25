int n = int.Parse(Console.ReadLine());

Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (!dic.ContainsKey(num))
    {
        dic.Add(num, 0);
    }

    dic[num]++;
}

foreach (var VARIABLE in dic)
{
    if (VARIABLE.Value % 2 == 0)
    {
        Console.WriteLine(VARIABLE.Key);
    }
}