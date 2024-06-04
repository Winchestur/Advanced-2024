List<int> nums = Console.ReadLine().Split(" ",
        StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x)).ToList();

string command = Console.ReadLine();

if (command == "even")
{
    Even(nums[0], nums[1], x => x % 2 == 0);
}
else if (command == "odd")
{
    Odd(nums[0], nums[1], x => x % 2 == 1 || x % 2 == -1);
}
void Even(int numOne, int numTwo, Predicate<int> isItTrue)
{
    List<int> list = new List<int>();

    for (int i = numOne; i <= numTwo; i++)
    {
        if (isItTrue(i))
        {
            list.Add(i);
        }
    }
    Console.WriteLine(string.Join(" ", list));
}
void Odd(int numOne, int numTwo, Predicate<int> isItTrue)
{
    List<int> list = new List<int>();

    for (int i = numOne; i <= numTwo; i++)
    {
        if (isItTrue(i))
        {
            list.Add(i);
        }
    }
    Console.WriteLine(string.Join(" ", list));
}