List<int> list = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int length = list[0] + list[1];

HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();

for (int i = 0; i < length; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i <= list[0] - 1)
    {
        first.Add(number);
    }
    else
    {
        second.Add(number);
    }
}

List<int> result = new List<int>();

first.IntersectWith(second);

Console.WriteLine(string.Join(" ", first));