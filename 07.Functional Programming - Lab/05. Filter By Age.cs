int n = int.Parse(Console.ReadLine());

Func<string, int> parse = (num) => int.Parse(num);

Dictionary<string, int> people = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    List<string> person = Console.ReadLine().Split(", ",
        StringSplitOptions.RemoveEmptyEntries).ToList();

    string name = person[0];
    int age = parse(person[1]);

    if (!people.ContainsKey(name))
    {
        people.Add(name, age);
    }
}

string type = Console.ReadLine();
int ageToCheck = int.Parse(Console.ReadLine());

switch (type)
{
    case "older":
        OlderPeople(people, ageToCheck);
        break;
    case "younger":
        YoungerPeople(people, ageToCheck);
        break;
}

string whatToPrint = Console.ReadLine();

switch (whatToPrint)
{
    case "name":
        foreach (var item in people)
        {
            Console.WriteLine($"{item.Key}");
        }
        break;
    case "age":
        foreach (var item in people)
        {
            Console.WriteLine($"{item.Value}");
        }
        break;
    case "name age":
        foreach (var item in people)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        break;
}
void YoungerPeople(Dictionary<string, int> people, int checkAge)
{
    foreach (var item in people)
    {
        if (item.Value >= checkAge)
        {
            people.Remove(item.Key);
        }
    }
}

void OlderPeople(Dictionary<string, int> people, int checkAge)
{
    foreach (var item in people)
    {
        if (item.Value < checkAge)
        {
            people.Remove(item.Key);
        }
    }
}