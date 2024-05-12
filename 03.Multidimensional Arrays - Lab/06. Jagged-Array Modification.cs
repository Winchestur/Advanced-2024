
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];

        InsertNumbersInMatrix(n, matrix);

        List<string> commands = Console.ReadLine().Split(" ").ToList();

        while (commands[0] != "END")
        {
            switch (commands[0])
            {
                case "Add":

                    Add(matrix, commands);

                    break;
                case "Subtract":

                    Subtract(matrix, commands);

                    break;
            }

            commands = Console.ReadLine().Split(" ").ToList();
        }

        PrintResult(matrix);
    }
    private static void PrintResult(int[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]} ");
            }
            Console.WriteLine();
        }
    }
    private static void InsertNumbersInMatrix(int n, int[][] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            matrix[row] = new int[nums.Count];

            for (int cols = 0; cols < nums.Count; cols++)
            {
                matrix[row][cols] = nums[cols];
            }
        }
    }
    private static void Subtract(int[][] matrix, List<string> commands)
    {
        int row = int.Parse(commands[1]);
        int col = int.Parse(commands[2]);
        int number = int.Parse(commands[3]);

        if (row < 0 || row > matrix.Length || col < 0 || col >= matrix.Length)
        {
            Console.WriteLine($"Invalid coordinates");
        }
        else
        {
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (row == rows && col == cols)
                    {
                        matrix[rows][cols] -= number;
                    }
                }
            }
        }
    }
    private static void Add(int[][] matrix, List<string> commands)
    {
        int row = int.Parse(commands[1]);
        int col = int.Parse(commands[2]);
        int number = int.Parse(commands[3]);

        if (row < 0 || row > matrix.Length || col < 0 || col >= matrix.Length)
        {
            Console.WriteLine($"Invalid coordinates");
        }
        else
        {
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (row == rows && col == cols)
                    {
                        matrix[rows][cols] += number;
                    }
                }
            }
        }
    }
}