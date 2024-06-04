int n = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

Operations(names, x=> x.Length <= n);
void Operations(List<string> names, Func<string, bool> value)
{
    List<string> list = new List<string>();

    for (int i = 0; i < names.Count; i++)
    {
        if (value(names[i]))
        {
            list.Add(names[i]);
        }
    }
    Console.WriteLine(string.Join(Environment.NewLine, list));
}