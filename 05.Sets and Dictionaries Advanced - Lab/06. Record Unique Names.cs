﻿int n = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();

    names.Add(name);
}

Console.WriteLine(string.Join(Environment.NewLine ,names));