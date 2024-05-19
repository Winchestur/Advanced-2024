class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        int rows = list[0];
        int cols = list[1];

        string[,] matrix = new string[rows, cols];

        string word = Console.ReadLine();
        Queue<string> queue = new Queue<string>();

        for (int i = 0; i < word.Length; i++)
        {
            queue.Enqueue(word[i].ToString());
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row % 2 == 0)
                {
                    string letter = queue.Peek();
                    matrix[row, col] = queue.Dequeue();
                    queue.Enqueue(letter);
                }
                else
                {
                    string letter = queue.Peek();
                    matrix[row, cols - 1 - col] = queue.Dequeue();
                    queue.Enqueue(letter);
                }
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write($"{matrix[row,col]}");
            }
            Console.WriteLine();
        }
    }
}