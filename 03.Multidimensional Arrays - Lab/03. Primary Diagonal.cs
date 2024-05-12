
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n,n];

        InsertMatrix(matrix,n);

        int sum = 0;

        for (int row = 0; row < n; row++)
        {
            for (int column = row; column <= row; column++)
            {
                sum += matrix[row,column];
            }
        }
        Console.WriteLine(sum);
    }

    private static void InsertMatrix(int[,] matrix ,int n)
    {
        for (int rows = 0; rows < n; rows++)
        {
            List<int> nums = ConsoleRead(" ");

            for (int column = 0; column < n; column++)
            {
                matrix[rows, column] = nums[column];
            }
        }

         static List<int> ConsoleRead(string separator)
        {
            return Console.ReadLine().Split(separator).Select(int.Parse).ToList();
        }
    }
}