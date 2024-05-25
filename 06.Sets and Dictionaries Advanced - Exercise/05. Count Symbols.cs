string text = Console.ReadLine();

Queue<char> queue = new Queue<char>();

for (int i = 0; i < text.Length; i++)
{
    queue.Enqueue(text[i]);
}

Dictionary<char, int> dic = new Dictionary<char, int>();

while (queue.Any())
{
    if (!dic.ContainsKey(queue.Peek()))
    {
        dic.Add(queue.Peek(),0);
    }
    dic[queue.Dequeue()]++;
}

dic = dic.OrderBy(a => a.Key).
    ToDictionary(a => a.Key, a => a.Value);

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}