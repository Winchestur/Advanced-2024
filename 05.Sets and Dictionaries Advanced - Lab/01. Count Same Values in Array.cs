List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

Dictionary<double, int> dic = new Dictionary<double, int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (!dic.ContainsKey(numbers[i]))
    {
        dic.Add(numbers[i], 0);
    }
    dic[numbers[i]]++;
}

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}