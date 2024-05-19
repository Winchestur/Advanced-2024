List<string> list = Console.ReadLine().Split(",").ToList();

HashSet<string> cars = new HashSet<string>();

while (list[0] != "END")
{
    switch (list[0])
    {
        case "IN":
            cars.Add(list[1]);
            break;
        case "OUT":
            cars.Remove(list[1]);
            break;
    }

    list = Console.ReadLine().Split(",").ToList();
}

if (cars.Any())
{
    Console.WriteLine(string.Join(Environment.NewLine, cars));
}
else
{
    Console.WriteLine($"Parking Lot is Empty");
}