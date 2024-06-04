Action<List<string>> words = Print;

List<string> text = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

words(text);
void Print(List<string> words)
{
    Console.WriteLine(string.Join(Environment.NewLine, words));
}