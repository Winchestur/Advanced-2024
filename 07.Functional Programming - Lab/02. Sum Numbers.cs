Func<string, int> parse = number => int.Parse(number);
Func<List<int>, int> count = number => Count(number);
Func<List<int>, int> sum = number => Sum(number);

List<int> numbers = Console.ReadLine().Split(", ",
    StringSplitOptions.RemoveEmptyEntries).Select(parse).ToList();

int countNums = count(numbers);
int sumNums = sum(numbers);

Console.WriteLine(countNums);
Console.WriteLine(sumNums);
int Sum(List<int> number)
{
    int sum = 0;

    for (int i = 0; i < number.Count; i++)
    {
        sum += number[i];
    }

    return sum;
}
int Count(List<int> number)
{
    int result = 0;

    for (int i = 0; i < number.Count; i++)
    {
        result++;
    }

    return result;
}