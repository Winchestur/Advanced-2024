List<int> numbers = Console.ReadLine().Split(" ",
        StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)).ToList();

int n = int.Parse(Console.ReadLine());

Operations(numbers, n, x => x % n == 0);
void Operations(List<int> numbers, int n, Func<int, bool> value)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (value(numbers[i]))
        {
            numbers.RemoveAt(i);
            i--;
        }
    }

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        Console.Write($"{numbers[i]} ");
    }
}