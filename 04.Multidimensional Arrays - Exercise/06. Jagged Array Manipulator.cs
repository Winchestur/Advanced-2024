class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];

        //insert numbers to matrix
        InsertNumsToMatrix(n, matrix);

        //divide or multiply 
        DivideOrMultiply(n, matrix);

        List<string> commands = Console.ReadLine().Split().ToList();

        while (commands[0] != "End")
        {
            switch (commands[0])
            {
                case "Add":
                    Add(matrix,commands);
                    break;
                case "Subtract":
                    Subtract(matrix,commands);
                    break;
            }

            commands = Console.ReadLine().Split().ToList();
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]} ");
            }

            Console.WriteLine();
        }
    }
    private static void Add(int[][] matrix, List<string> commands)
    {
        int rows = int.Parse(commands[1]);
        int columns = int.Parse(commands[2]);
        int number = int.Parse(commands[3]);

        if (rows >= 0 && rows < matrix.Length && columns >= 0 && columns < matrix[rows].Length)
        {
            matrix[rows][columns] += number;
        }
    }
    private static void Subtract(int[][] matrix, List<string> commands)
    {
        int rows = int.Parse(commands[1]);
        int columns = int.Parse(commands[2]);
        int number = int.Parse(commands[3]);

        if (rows >= 0 && rows < matrix.Length && columns >= 0 && columns < matrix[rows].Length)
        {
            matrix[rows][columns] -= number;
        }
    }
    private static void DivideOrMultiply(int n, int[][] matrix)
    {
        for (int row = 1; row < n; row++)
        {
            if (matrix[row - 1].Length > matrix[row].Length)
            {
                for (int col = 0; col < matrix[row - 1].Length; col++)
                {
                    if (matrix[row - 1].Length == matrix[row].Length)
                    {
                        matrix[row - 1][col] *= 2;

                        if (col <= matrix[row].Length)
                        {
                            matrix[row][col] *= 2;
                        }
                    }
                    else
                    {
                        if ((col < matrix[row - 1].Length))
                        {
                            matrix[row - 1][col] /= 2;
                        }

                        if (col < matrix[row].Length)
                        {
                            matrix[row][col] /= 2;
                        }
                    }
                }
            }
            else
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row - 1].Length == matrix[row].Length)
                    {
                        matrix[row - 1][col] *= 2;
                        matrix[row][col] *= 2;
                    }
                    else
                    {
                        if ((col < matrix[row - 1].Length))
                        {
                            matrix[row - 1][col] /= 2;
                        }

                        if (col < matrix[row].Length)
                        {
                            matrix[row][col] /= 2;
                        }
                    }
                }
            }
        }
    }
    private static void InsertNumsToMatrix(int n, int[][] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            matrix[row] = new int[nums.Count];

            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] = nums[col];
            }
        }
    }
}