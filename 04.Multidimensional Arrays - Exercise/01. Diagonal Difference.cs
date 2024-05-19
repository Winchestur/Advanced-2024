class Program
{ 
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n,n];

        InsertNumberInMatrix(matrix, n);

        ReadDiagonals(matrix, n);
    }
    private static void ReadDiagonals(int[,] matrix, int n)
    {
        int primarySum = 0;
        int secondarySum = 0;

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                if (rows == cols)
                {
                    primarySum += matrix[rows, cols];
                }

                if (cols == n - 1 - rows)
                {
                    secondarySum += matrix[rows, cols];
                }
            }
        }

        int result = Math.Abs(primarySum - secondarySum);

        Console.WriteLine(result);
    }
    private static void InsertNumberInMatrix(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = numbers[col];
            }
        }
    }
}