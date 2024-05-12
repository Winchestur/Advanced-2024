class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        long[][] matrix = new long[n][];

        matrix[0] = new long[1];
        matrix[0][0] = 1;

        int count = 0;
        string nums = "1";

        for (int row = 1; row < matrix.Length; row++)
        {
            nums += "1";
            matrix[row] = new long[nums.Length];

            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (col == 0 || col == matrix[row].Length - 1)
                {
                    matrix[row][col] = 1;
                }
                else
                {
                    matrix[row][col] = matrix[row - 1][col-1] + matrix[row - 1][col];
                }
            }
        }

        foreach (var VARIABLE in matrix)
        {
            Console.WriteLine(string.Join(" ", VARIABLE));
        }
    }
}