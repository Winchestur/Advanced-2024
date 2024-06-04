List<int> numbers = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

int min = int.MaxValue;
int result = Min(numbers, min);

Console.WriteLine(result);
int Min(List<int> x, int minNum)
{
    for (int i = 0; i < x.Count; i++)
    {
        int currentNum = x[i];

        if (currentNum < minNum)
        {
            minNum = currentNum;
        }
    }
    return minNum ;
}