int endNum = int.Parse(Console.ReadLine());

List<int> dividers  = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries)
    .Select(x=>int.Parse(x)).ToList();

Operations(endNum, dividers, (x,y)=>x % y == 0);
void Operations(int endNum, List<int> dividers, Func<int, int, bool> value)
{
    List<int> list = new List<int>();

    for (int i = 1; i <= endNum; i++)
    {
        int count = 0;
        for (int j = 0; j < dividers.Count; j++)
        {
            if (value(i, dividers[j]))
            {
                count++;
            }
        }

        if (count == dividers.Count)
        {
            list.Add(i);
        }
    }

    Console.WriteLine(string.Join(" ", list));
}