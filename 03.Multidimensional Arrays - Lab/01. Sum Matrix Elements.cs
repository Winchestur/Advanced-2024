class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

        int rows = numbers[0];
        int columns = numbers[1];

        int sum = 0;

        int[,] matrix = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            List<int> nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = nums[column];
                sum += nums[column];
            }
        }

        Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine(matrix.GetLength(1));
        Console.WriteLine(sum);
    }
}