
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = ConsoleRead(", ");

        int matrixRows = numbers[0];
        int matrixColumns = numbers[1];

        int[,] matrix = new int[matrixRows,matrixColumns];

        //add numbers to matrix
        for (int rows = 0; rows < matrixRows; rows++)
        {
            List<int> nums = ConsoleRead(" ");

            for (int column = 0; column < matrixColumns; column++)
            {
                matrix[rows, column] = nums[column];
            }
        }

        int sum = 0;

        //sum columns of matrix
        for (int columns = 0; columns < matrixColumns; columns++)
        {
            for (int rows = 0; rows < matrixRows; rows++)
            {
                sum += matrix[rows, columns];
            }

            Console.WriteLine(sum);
            sum = 0;
        }
    }

    private static List<int> ConsoleRead(string separator)
    {
        return Console.ReadLine().Split(separator).Select(int.Parse).ToList();
    }
}