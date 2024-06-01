int n = int.Parse(Console.ReadLine());

Queue<List<int>> trucks = new Queue<List<int>>();

for (int i = 0; i < n; i++)
{
    List<int> list = Console.ReadLine().Split(" ",
        StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

    trucks.Enqueue(list);
}
int check = 0;
int index = 0;
int result = 0;

while (true)
{
    result = 0;
    foreach (var item in trucks)
    {
        result += item[0] - item[1];

        if (result < 0)
        {
            trucks.Enqueue(trucks.Dequeue());
            index++;
            break;
        }
    }

    if (result >= 0)
    {
        break;
    }
}

Console.WriteLine(index);