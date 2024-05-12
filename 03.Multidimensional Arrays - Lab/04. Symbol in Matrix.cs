using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, n];

        InsertMatrix(matrix, n);

        string symbol = Console.ReadLine();

        for (int rows = 0; rows < n; rows++)
        {
            for (int columns = 0; columns < n; columns++)
            {
                if (symbol == matrix[rows, columns])
                {
                    Console.WriteLine($"({rows}, {columns})");
                    return;
                }
            }
        }

        Console.WriteLine($"{symbol} does not occur in the matrix");
    }
    private static void InsertMatrix(string[,] matrix, int n)
    {
        Queue<string> queue = new Queue<string>();

        for (int rows = 0; rows < n; rows++)
        {
            string nums = Console.ReadLine();

            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i].ToString());
            }

            for (int column = 0; column < n; column++)
            {
                matrix[rows, column] = queue.Dequeue();
            }
        }
    }
}