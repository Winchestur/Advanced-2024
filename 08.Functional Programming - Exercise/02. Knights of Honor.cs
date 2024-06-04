Action<List<string>> words = Print;

List<string> text = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

words(text);
void Print(List<string> words)
{
    for (int i = 0; i < words.Count; i++)
    {
        Console.WriteLine($"Sir {words[i]}");
    }
}