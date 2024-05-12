class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = ConsoleRead(", ");

        int rows = numbers[0];
        int cols = numbers[1];

        int[,] matrix = new int[rows,cols];

        for (int row = 0; row < rows; row++)
        {
            List<int> nums = ConsoleRead(", ");

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = nums[col];
            }
        }

        int savedResult = 0;

        List<int> top = new List<int>();
        List<int> bottom = new List<int>();

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] > savedResult)
                {
                    top.Clear();
                    bottom.Clear();

                    savedResult = matrix[row, col] + matrix[row,col + 1] +
                                  matrix[row + 1,col] + matrix[row + 1,col + 1];

                    top.Add(matrix[row,col]);
                    top.Add(matrix[row,col + 1]);
                    bottom.Add(matrix[row + 1, col]);
                    bottom.Add(matrix[row + 1, col + 1]);
                }
            }
        }

        Console.WriteLine(string.Join(" ", top));
        Console.WriteLine(string.Join(" ", bottom));
        Console.WriteLine(savedResult);
    }
    private static List<int> ConsoleRead(string separator)
    {
        return Console.ReadLine().Split(separator).Select(int.Parse).ToList();
    }
}