Func<string, int> parse = (number) => int.Parse(number);
Func<int, bool> evenNum = (number) => { return number % 2 == 0; };
Func<int, int> sort = (number) => number;

List<int> numbers = Console.ReadLine().Split(", ",
    StringSplitOptions.RemoveEmptyEntries).Select(parse).Where(evenNum).OrderBy(sort).ToList();

Console.WriteLine($"{string.Join(", ", numbers)}");