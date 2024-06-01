Func<List<string>, List<string>> takeWords = word => StartsWithUpperCase(word);

List<string> StartsWithUpperCase(List<string> word)
{
    List<string> newText = new List<string>();
    string currentWord = "";

    for (int i = 0; i < word.Count; i++)
    {
        currentWord = word[i];

        if (currentWord[0].ToString().ToUpper() == word[i][0].ToString())
        {
            newText.Add(word[i]);
        }
    }

    return newText;
}

List<string> text = Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).ToList();

Console.WriteLine(string.Join(Environment.NewLine, takeWords(text)));