class Program
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        int rows = nums[0];
        int columns = nums[1];

        string[,] matrix = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            List<string> letters = Console.ReadLine().Split(" ").ToList();

            for (int col = 0; col < columns; col++)
            {
                matrix[row,col] = letters[col].ToString();
            }
        }

        int count = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < columns - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1] &&
                    matrix[row + 1, col] == matrix[row + 1, col + 1] &&
                    matrix[row,col] == matrix[row + 1,col])
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}