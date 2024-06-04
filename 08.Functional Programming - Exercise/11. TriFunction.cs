int n = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

string name = Result(n, names);
Console.WriteLine(name);
string Result(int n, List<string> names)
{
    string name = "";
    int result = 0;

    for (int i = 0; i < names.Count; i++)
    {
        for (int j = 0; j < names[i].ToString().Length; j++)
        {
            result += names[i][j];
        }

        if (result >= n)
        {
            name = names[i].ToString();
            break;
        }

        result = 0;
    }
    return name;
}